namespace EF_Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_employees = new DataGridView();
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_salary = new TextBox();
            txt_address = new TextBox();
            cb_dept = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_employees).BeginInit();
            SuspendLayout();
            // 
            // dgv_employees
            // 
            dgv_employees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_employees.Location = new Point(31, 245);
            dgv_employees.Margin = new Padding(3, 2, 3, 2);
            dgv_employees.Name = "dgv_employees";
            dgv_employees.RowHeadersWidth = 51;
            dgv_employees.Size = new Size(658, 151);
            dgv_employees.TabIndex = 0;
            dgv_employees.RowHeaderMouseDoubleClick += dgv_employees_RowHeaderMouseDoubleClick;
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(293, 27);
            txt_fname.Margin = new Padding(3, 2, 3, 2);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(110, 23);
            txt_fname.TabIndex = 1;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(293, 61);
            txt_lname.Margin = new Padding(3, 2, 3, 2);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(110, 23);
            txt_lname.TabIndex = 1;
            // 
            // txt_salary
            // 
            txt_salary.Location = new Point(293, 94);
            txt_salary.Margin = new Padding(3, 2, 3, 2);
            txt_salary.Name = "txt_salary";
            txt_salary.Size = new Size(110, 23);
            txt_salary.TabIndex = 2;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(293, 136);
            txt_address.Margin = new Padding(3, 2, 3, 2);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(110, 23);
            txt_address.TabIndex = 3;
            // 
            // cb_dept
            // 
            cb_dept.FormattingEnabled = true;
            cb_dept.Location = new Point(293, 172);
            cb_dept.Margin = new Padding(3, 2, 3, 2);
            cb_dept.Name = "cb_dept";
            cb_dept.Size = new Size(133, 23);
            cb_dept.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Fname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 180);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 136);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(232, 93);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 8;
            label4.Text = "salary";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(381, 208);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(82, 22);
            btn_add.TabIndex = 9;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(293, 208);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(82, 22);
            btn_update.TabIndex = 10;
            btn_update.Text = "update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(205, 208);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(82, 22);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 61);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 12;
            label5.Text = "Lname";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 407);
            Controls.Add(label5);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cb_dept);
            Controls.Add(txt_address);
            Controls.Add(txt_salary);
            Controls.Add(txt_fname);
            Controls.Add(txt_lname);
            Controls.Add(dgv_employees);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_employees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_employees;
        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_salary;
        private TextBox txt_address;
        private ComboBox cb_dept;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Label label5;
    }
}
