using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Xml;
using System.Threading;
using System.IO;

namespace WorkflowObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Visible = false;
            this.button2.Enabled = false;

            //this.serverName.Text = "sql2016";
            //this.dbName.Text = "AUBTEST";
            //this.userName.Text = "sa";
            //this.password.Text = "sasql";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Visible = false;
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows[0].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8f, FontStyle.Bold);
            var res = this.GetWorkflowInstancePropertyValue();

            foreach (Form1.WorkflowInstancePropertyValue instancePropertyValue in res)
            {
                try
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(instancePropertyValue.Value);

                    string originalPresenceType = string.Empty;
                    string newPresenceType = string.Empty;

                    foreach (XmlNode xmlNode in xmlDocument.GetElementsByTagName("ModifiedPresenceTypeDTO"))
                    {
                        string presenceTypeDate = xmlNode.Attributes[0].OwnerElement["_x003C_PresenceTypeDate_x003E_k__BackingField"].InnerText;
                        string fromTime = xmlNode.Attributes[0].OwnerElement["_x003C_FromTime_x003E_k__BackingField"].InnerText;
                        string toTime = xmlNode.Attributes[0].OwnerElement["_x003C_ToTime_x003E_k__BackingField"].InnerText;
                        string equivalentHours = xmlNode.Attributes[0].OwnerElement["_x003C_EquivalentHours_x003E_k__BackingField"].InnerText;
                        string remark = xmlNode.Attributes[0].OwnerElement["_x003C_Remark_x003E_k__BackingField"].InnerText;
                        
                        try
                        {
                            originalPresenceType = xmlNode.Attributes[0].OwnerElement["_x003C_OriginalPresenceType_x003E_k__BackingField"].Attributes[0].OwnerElement["a:_x003C_AttendanceTypeDescription_x003E_k__BackingField"].InnerText;
                        }
                        catch { }

                        try
                        {
                            newPresenceType = xmlNode.Attributes[0].OwnerElement["_x003C_NewPresenceType_x003E_k__BackingField"].Attributes[0].OwnerElement["a:_x003C_AttendanceTypeDescription_x003E_k__BackingField"].InnerText;
                        }
                        catch { }

                        string employeeFullName = string.Empty;
                        string employeeFullName1 = string.Empty;

                        try
                        {
                            employeeFullName = instancePropertyValue.RequestedBy;
                            employeeFullName1 = employeeFullName.Split()[0];
                        }
                        catch { }

                        string equivalentHours2 = string.Empty;

                        try
                        {
                            equivalentHours2 = DateTime.Parse(equivalentHours).TimeOfDay.TotalHours.ToString("0.##");
                        }
                        catch { }

                        this.dataGridView1.Rows.Add(
                            instancePropertyValue.RequestedDate,
                            instancePropertyValue.EmployeeID,
                            instancePropertyValue.FirstName,
                            instancePropertyValue.LastName,
                            instancePropertyValue.Status,
                            instancePropertyValue.IdentificationNumber,
                            employeeFullName1,
                            employeeFullName,
                            presenceTypeDate,
                            fromTime,
                            toTime,
                            equivalentHours2,
                            originalPresenceType,
                            newPresenceType,
                            remark
                            );

                    }
                }
                catch
                {
                }
            }

            //Thread.Sleep(5000);
            this.button2.Enabled = true;
        }

        private List<WorkflowInstancePropertyValue> GetWorkflowInstancePropertyValue()
        {
            //List<WorkflowInstancePropertyValue> res = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkflowInstancePropertyValue>>(File.ReadAllText(@".\res.json"));
            //return res;

            string cmdText = @" SELECT DISTINCT e2.EmployeeID + ' ' + p2.FirstName + ' ' + p2.LastName AS RequestedBy, 
                                RequestedDate, OwnerID, e.EmployeeID, p.FirstName, 
                                p.LastName, [Status], FaultedReason, IdentificationNumber, [Value] 
                                FROM [WorkflowInstance] wi 
                                INNER JOIN [WorkflowInstancePropertyValue] wipv on wi.InstanceID = wipv.InstanceID
                                INNER JOIN Person p ON p.PersonID = OwnerID 
                                INNER JOIN Employee e ON e.PersonID = OwnerID 
								INNER JOIN Person p2 ON p2.PersonID = RequestedBy 
                                INNER JOIN Employee e2 ON e2.PersonID = RequestedBy 
                                WHERE PropertyID = 'DC4B8F0E-C9F8-42BA-9F72-5BA6337FE0AE' 
	                                  AND TemplateID IN ( SELECT TemplateID 
						                                  FROM WorkflowTemplateDefinition 
						                                  WHERE WorkflowTypeID = '45B8DA55-E63D-4957-8847-0256B112B55B' ) ";
            string connectionString = "Server=" + this.serverName.Text + ";Database=" + this.dbName.Text + ";User Id=" + this.userName.Text + ";Password=" + this.password.Text + ";";
            List<WorkflowInstancePropertyValue> instancePropertyValue = new List<WorkflowInstancePropertyValue>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
                    connection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    try
                    {
                        while (sqlDataReader.Read())
                            instancePropertyValue.Add(new WorkflowInstancePropertyValue()
                            {
                                RequestedBy = sqlDataReader["RequestedBy"]?.ToString(),
                                RequestedDate = sqlDataReader["RequestedDate"]?.ToString(),
                                OwnerID = sqlDataReader["OwnerID"]?.ToString(),
                                EmployeeID = sqlDataReader["EmployeeID"]?.ToString(),
                                FirstName = sqlDataReader["FirstName"]?.ToString(),
                                LastName = sqlDataReader["LastName"]?.ToString(),
                                Status = sqlDataReader["Status"]?.ToString(),
                                FaultedReason = sqlDataReader["FaultedReason"]?.ToString(),
                                IdentificationNumber = sqlDataReader["IdentificationNumber"]?.ToString(),
                                Value = sqlDataReader["Value"]?.ToString()
                            });
                    }
                    catch (Exception ex)
                    {
                        this.richTextBox1.Visible = true;
                        this.richTextBox1.Text = ex.Message;
                        if (ex.InnerException != null)
                            this.richTextBox1.Text = ex.Message + " \n " + ex.InnerException.Message;
                    }
                    finally
                    {
                        sqlDataReader.Close();
                    }
                }
                catch (Exception ex)
                {
                    this.richTextBox1.Visible = true;
                    this.richTextBox1.Text = ex.Message;
                    if (ex.InnerException != null)
                        this.richTextBox1.Text = ex.Message + " \n " + ex.InnerException.Message;
                }
            }
            return instancePropertyValue;
        }

        private void ExportGridToExcel()
        {
            Microsoft.Office.Interop.Excel.Application instance = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = instance.Application.Workbooks.Add(true);
            Microsoft.Office.Interop.Excel.Worksheet worksheet2 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

            worksheet2.Name = "Exported from gridview";
            for (int ColumnIndex = 1; ColumnIndex < this.dataGridView1.Columns.Count + 1; ++ColumnIndex)
                worksheet2.Cells[(object)1, (object)ColumnIndex] = (object)this.dataGridView1.Columns[ColumnIndex - 1].HeaderText;

            for (int index1 = 0; index1 < this.dataGridView1.Rows.Count - 1; ++index1)
            {
                for (int index2 = 0; index2 < this.dataGridView1.Columns.Count; ++index2)
                    worksheet2.Cells[(object)(index1 + 2), (object)(index2 + 1)] = (object)this.dataGridView1.Rows[index1].Cells[index2].Value.ToString();
            }

            instance.Visible = true;
            string Filename = System.Windows.Forms.Application.StartupPath + "\\Vithal" + DateTimeOffset.Now.ToUnixTimeSeconds().ToString() + ".xls";

            workbook.SaveAs((object)Filename, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, XlSaveAsAccessMode.xlExclusive, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing, System.Type.Missing);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Enabled = false;
            this.button2.Text = "waiting ...";
            this.ExportGridToExcel();
            this.button2.Text = "Export to Excel";
            this.button2.Enabled = true;
        }

        private class WorkflowInstancePropertyValue
        {
            public string RequestedBy { get; set; }

            public string RequestedDate { get; set; }

            public string OwnerID { get; set; }

            public string EmployeeID { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Status { get; set; }

            public string FaultedReason { get; set; }

            public string IdentificationNumber { get; set; }

            public string Value { get; set; }
        }

        string jsonString = "";
    }
}
