namespace Testing
{
    partial class RegisterStudent
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
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxSurn = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxConfPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxGroups = new System.Windows.Forms.TextBox();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExBook = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExBook)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.comboBoxSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(85, 133);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(191, 25);
            this.comboBoxSex.TabIndex = 8;
            this.comboBoxSex.Tag = "SexInt";
            this.comboBoxSex.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(73, 328);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 31);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 101);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 2, 26, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Tag = "BirthdayDT";
            this.dateTimePicker1.Value = new System.DateTime(2018, 2, 26, 0, 0, 0, 0);
            // 
            // txtBoxSurn
            // 
            this.txtBoxSurn.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSurn.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxSurn.Location = new System.Drawing.Point(85, 70);
            this.txtBoxSurn.MaxLength = 32;
            this.txtBoxSurn.Name = "txtBoxSurn";
            this.txtBoxSurn.Size = new System.Drawing.Size(191, 25);
            this.txtBoxSurn.TabIndex = 6;
            this.txtBoxSurn.Tag = "Surname";
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxPass.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxPass.Location = new System.Drawing.Point(85, 260);
            this.txtBoxPass.MaxLength = 32;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(191, 25);
            this.txtBoxPass.TabIndex = 5;
            this.txtBoxPass.Tag = "Password";
            this.txtBoxPass.UseSystemPasswordChar = true;
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxName.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxName.Location = new System.Drawing.Point(85, 39);
            this.txtBoxName.MaxLength = 32;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(191, 25);
            this.txtBoxName.TabIndex = 5;
            this.txtBoxName.Tag = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label4.Location = new System.Drawing.Point(8, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label7.Location = new System.Drawing.Point(9, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sex";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label3.Location = new System.Drawing.Point(11, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label5.Location = new System.Drawing.Point(8, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxEmail.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxEmail.Location = new System.Drawing.Point(85, 8);
            this.txtBoxEmail.MaxLength = 32;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(191, 25);
            this.txtBoxEmail.TabIndex = 4;
            this.txtBoxEmail.Tag = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label13.Location = new System.Drawing.Point(9, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 18;
            this.label13.Text = "Group";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label15.Location = new System.Drawing.Point(9, 205);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "Course";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label16.Location = new System.Drawing.Point(9, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 21;
            this.label16.Text = "ExamBook";
            // 
            // txtBoxConfPass
            // 
            this.txtBoxConfPass.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxConfPass.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxConfPass.Location = new System.Drawing.Point(85, 293);
            this.txtBoxConfPass.MaxLength = 32;
            this.txtBoxConfPass.Name = "txtBoxConfPass";
            this.txtBoxConfPass.Size = new System.Drawing.Size(191, 25);
            this.txtBoxConfPass.TabIndex = 5;
            this.txtBoxConfPass.Tag = "ConfirmPassword";
            this.txtBoxConfPass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label8.Location = new System.Drawing.Point(11, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Confirm\r\nPassword";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxGroups
            // 
            this.txtBoxGroups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxGroups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxGroups.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxGroups.Location = new System.Drawing.Point(85, 164);
            this.txtBoxGroups.Name = "txtBoxGroups";
            this.txtBoxGroups.Size = new System.Drawing.Size(191, 26);
            this.txtBoxGroups.TabIndex = 15;
            this.txtBoxGroups.Tag = "IdGroup";
            this.txtBoxGroups.TextChanged += new System.EventHandler(this.Course_TextChanged);
            // 
            // numericUpDownCourse
            // 
            this.numericUpDownCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownCourse.Location = new System.Drawing.Point(87, 196);
            this.numericUpDownCourse.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new System.Drawing.Size(189, 26);
            this.numericUpDownCourse.TabIndex = 22;
            this.numericUpDownCourse.Tag = "Course";
            this.numericUpDownCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownExBook
            // 
            this.numericUpDownExBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownExBook.Location = new System.Drawing.Point(87, 228);
            this.numericUpDownExBook.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericUpDownExBook.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExBook.Name = "numericUpDownExBook";
            this.numericUpDownExBook.Size = new System.Drawing.Size(189, 26);
            this.numericUpDownExBook.TabIndex = 22;
            this.numericUpDownExBook.Tag = "ExamBook";
            this.numericUpDownExBook.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Tomato;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(240, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(298, 383);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.numericUpDownExBook);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxGroups);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.txtBoxSurn);
            this.Controls.Add(this.txtBoxConfPass);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegisterStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RegistrationFormStudent";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxSurn;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxConfPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxGroups;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.NumericUpDown numericUpDownExBook;
        private System.Windows.Forms.Button btnClose;
    }
}