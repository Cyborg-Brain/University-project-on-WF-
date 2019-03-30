namespace Testing.Views.Forms.PopUpWindows
{
    partial class EdLecturer
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
            this.numericUpDownExp = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.txtBoxSurn = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxSubject = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExp)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownExp
            // 
            this.numericUpDownExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownExp.Location = new System.Drawing.Point(84, 135);
            this.numericUpDownExp.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownExp.Name = "numericUpDownExp";
            this.numericUpDownExp.Size = new System.Drawing.Size(205, 26);
            this.numericUpDownExp.TabIndex = 65;
            this.numericUpDownExp.Tag = "Experience";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label13.Location = new System.Drawing.Point(8, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 16);
            this.label13.TabIndex = 62;
            this.label13.Text = "Subjects";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label5.Location = new System.Drawing.Point(7, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 48;
            this.label5.Text = "Surname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label7.Location = new System.Drawing.Point(8, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 49;
            this.label7.Text = "Sex";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(68, 255);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(172, 31);
            this.btnSubmit.TabIndex = 61;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label15.Location = new System.Drawing.Point(8, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 16);
            this.label15.TabIndex = 63;
            this.label15.Text = "Experience";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label4.Location = new System.Drawing.Point(7, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Birthday";
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxName.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxName.Location = new System.Drawing.Point(84, 10);
            this.txtBoxName.MaxLength = 20;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(205, 25);
            this.txtBoxName.TabIndex = 56;
            this.txtBoxName.Tag = "Name";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.comboBoxSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(84, 104);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(205, 25);
            this.comboBoxSex.TabIndex = 60;
            this.comboBoxSex.Tag = "SexInt";
            // 
            // txtBoxSurn
            // 
            this.txtBoxSurn.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSurn.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxSurn.Location = new System.Drawing.Point(84, 41);
            this.txtBoxSurn.MaxLength = 20;
            this.txtBoxSurn.Name = "txtBoxSurn";
            this.txtBoxSurn.Size = new System.Drawing.Size(205, 25);
            this.txtBoxSurn.TabIndex = 58;
            this.txtBoxSurn.Tag = "Surname";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 72);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 2, 18, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1933, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 26);
            this.dateTimePicker1.TabIndex = 59;
            this.dateTimePicker1.Tag = "BirthdayDt";
            this.dateTimePicker1.Value = new System.DateTime(2018, 2, 18, 0, 0, 0, 0);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 8.25F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(271, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 21);
            this.btnExit.TabIndex = 66;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBoxSubject
            // 
            this.listBoxSubject.FormattingEnabled = true;
            this.listBoxSubject.Location = new System.Drawing.Point(84, 167);
            this.listBoxSubject.Name = "listBoxSubject";
            this.listBoxSubject.ScrollAlwaysVisible = true;
            this.listBoxSubject.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSubject.Size = new System.Drawing.Size(205, 82);
            this.listBoxSubject.Sorted = true;
            this.listBoxSubject.TabIndex = 67;
            this.listBoxSubject.Tag = "Subjects";
            // 
            // EdLecturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 299);
            this.Controls.Add(this.listBoxSubject);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.numericUpDownExp);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.txtBoxSurn);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdLecturer";
            this.Text = "EdLecturer";
            this.Load += new System.EventHandler(this.EdLecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownExp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxName;
        public System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.TextBox txtBoxSurn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxSubject;
    }
}