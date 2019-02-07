namespace TestFormGUI
{
    partial class FormTest
    {
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingTestData = new System.Windows.Forms.BindingSource(this.components);
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGetID = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.radNew = new System.Windows.Forms.RadioButton();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTestData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingTestData;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(253, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(7, 147);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnGetID
            // 
            this.btnGetID.Location = new System.Drawing.Point(88, 147);
            this.btnGetID.Name = "btnGetID";
            this.btnGetID.Size = new System.Drawing.Size(75, 23);
            this.btnGetID.TabIndex = 2;
            this.btnGetID.Text = "Get By ID";
            this.btnGetID.UseVisualStyleBackColor = true;
            this.btnGetID.Click += new System.EventHandler(this.btnGetID_Click);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(169, 150);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(76, 20);
            this.num.TabIndex = 3;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(0, 1);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(116, 24);
            this.lblIntro.TabIndex = 4;
            this.lblIntro.Text = "New Model";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(4, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(7, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(4, 66);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(4, 105);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone Number";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(7, 121);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(170, 118);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(125, 43);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(122, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.Checked = true;
            this.radNew.Location = new System.Drawing.Point(6, 5);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(47, 17);
            this.radNew.TabIndex = 14;
            this.radNew.TabStop = true;
            this.radNew.Text = "New";
            this.radNew.UseVisualStyleBackColor = true;
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Location = new System.Drawing.Point(59, 6);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(57, 18);
            this.radRadioButton1.TabIndex = 15;
            this.radRadioButton1.Text = "Update";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNew);
            this.groupBox1.Controls.Add(this.radRadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(122, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 38);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.num);
            this.Controls.Add(this.btnGetID);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTest";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingTestData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingTestData;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGetID;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.RadioButton radNew;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

