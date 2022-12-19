using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WorkflowObject
{
    partial class Form1
    {
        private TextBox userName;
        private TextBox password;
        private TextBox dbName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox serverName;
        private Label label4;
        private RichTextBox richTextBox1;
        private DataGridView dataGridView1;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn FromTime;
        private DataGridViewTextBoxColumn ToTime;
        private DataGridViewTextBoxColumn EquivalentHours;
        private DataGridViewTextBoxColumn OriginalType;
        private DataGridViewTextBoxColumn NewType;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.dbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.serverName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquivalentHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(205, 82);
            this.userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(179, 26);
            this.userName.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(205, 129);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(179, 26);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            // 
            // dbName
            // 
            this.dbName.Location = new System.Drawing.Point(205, 170);
            this.dbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(179, 26);
            this.dbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Database Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "Get Workflow Instance Property Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serverName
            // 
            this.serverName.Location = new System.Drawing.Point(205, 39);
            this.serverName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverName.Name = "serverName";
            this.serverName.Size = new System.Drawing.Size(179, 26);
            this.serverName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(420, 221);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(309, 59);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.FromTime,
            this.ToTime,
            this.EquivalentHours,
            this.OriginalType,
            this.NewType,
            this.remark});
            this.dataGridView1.Location = new System.Drawing.Point(11, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1242, 264);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RequestedDate";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "EmployeeID";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "FirstName";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LastName";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "IdentificationNumber";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "RequestEmployeeID";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "RequestEmployeeName";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TransferDate";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // FromTime
            // 
            this.FromTime.HeaderText = "FromTime";
            this.FromTime.MinimumWidth = 8;
            this.FromTime.Name = "FromTime";
            this.FromTime.Width = 150;
            // 
            // ToTime
            // 
            this.ToTime.HeaderText = "ToTime";
            this.ToTime.MinimumWidth = 8;
            this.ToTime.Name = "ToTime";
            this.ToTime.Width = 150;
            // 
            // EquivalentHours
            // 
            this.EquivalentHours.HeaderText = "EquivalentHours";
            this.EquivalentHours.MinimumWidth = 8;
            this.EquivalentHours.Name = "EquivalentHours";
            this.EquivalentHours.Width = 150;
            // 
            // OriginalType
            // 
            this.OriginalType.HeaderText = "OriginalType";
            this.OriginalType.MinimumWidth = 8;
            this.OriginalType.Name = "OriginalType";
            this.OriginalType.Width = 150;
            // 
            // NewType
            // 
            this.NewType.HeaderText = "NewType";
            this.NewType.MinimumWidth = 8;
            this.NewType.Name = "NewType";
            this.NewType.Width = 150;
            // 
            // remark
            // 
            this.remark.HeaderText = "remark";
            this.remark.MinimumWidth = 8;
            this.remark.Name = "remark";
            this.remark.Width = 150;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1100, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Export to Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 643);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.serverName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "WorkflowObject";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DataGridViewTextBoxColumn remark;
    }
}

