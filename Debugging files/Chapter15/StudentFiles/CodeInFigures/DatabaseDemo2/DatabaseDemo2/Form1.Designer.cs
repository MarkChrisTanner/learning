namespace DatabaseDemo2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.components = new System.ComponentModel.Container();
            this.cartmanCollegeDataSet = new DatabaseDemo2.CartmanCollegeDataSet();
            this.tblStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStudentsTableAdapter = new DatabaseDemo2.CartmanCollegeDataSetTableAdapters.tblStudentsTableAdapter();
            this.showButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.cartmanCollegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cartmanCollegeDataSet
            // 
            this.cartmanCollegeDataSet.DataSetName = "CartmanCollegeDataSet";
            this.cartmanCollegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudentsBindingSource
            // 
            this.tblStudentsBindingSource.DataMember = "tblStudents";
            this.tblStudentsBindingSource.DataSource = this.cartmanCollegeDataSet;
            // 
            // tblStudentsTableAdapter
            // 
            this.tblStudentsTableAdapter.ClearBeforeFill = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(52, 44);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(173, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show students with high GPA";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(82, 101);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(120, 95);
            this.outputListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.showButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cartmanCollegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CartmanCollegeDataSet cartmanCollegeDataSet;
        private System.Windows.Forms.BindingSource tblStudentsBindingSource;
        private CartmanCollegeDataSetTableAdapters.tblStudentsTableAdapter tblStudentsTableAdapter;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox outputListBox;
    }
}

