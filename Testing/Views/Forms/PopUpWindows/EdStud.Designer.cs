namespace Testing.Views.Forms.PopUpWindows
{
    partial class EdStud
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
            this.numericUpDownExBook = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxGroups = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.txtBoxSurn = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownAvMark = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAvMark)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownExBook
            // 
            this.numericUpDownExBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownExBook.Location = new System.Drawing.Point(99, 164);
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
            this.numericUpDownExBook.Size = new System.Drawing.Size(191, 26);
            this.numericUpDownExBook.TabIndex = 44;
            this.numericUpDownExBook.Tag = "ExamBook";
            this.numericUpDownExBook.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownCourse
            // 
            this.numericUpDownCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownCourse.Location = new System.Drawing.Point(99, 132);
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
            this.numericUpDownCourse.Size = new System.Drawing.Size(191, 26);
            this.numericUpDownCourse.TabIndex = 43;
            this.numericUpDownCourse.Tag = "Course";
            this.numericUpDownCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label13.Location = new System.Drawing.Point(8, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // txtBoxGroups
            // 
            this.txtBoxGroups.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxGroups.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxGroups.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxGroups.Location = new System.Drawing.Point(99, 227);
            this.txtBoxGroups.Name = "txtBoxGroups";
            this.txtBoxGroups.Size = new System.Drawing.Size(191, 26);
            this.txtBoxGroups.TabIndex = 39;
            this.txtBoxGroups.Tag = "IdGroup";
            this.txtBoxGroups.TextChanged += new System.EventHandler(this.txtBoxGroups_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Surname";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 8.25F);
            this.btnExit.Location = new System.Drawing.Point(275, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 20);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label7.Location = new System.Drawing.Point(8, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Sex";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(77, 259);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 31);
            this.btnSubmit.TabIndex = 38;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label15.Location = new System.Drawing.Point(8, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label4.Location = new System.Drawing.Point(7, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Birthday";
            // 
            // txtBoxName
            // 
            this.txtBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxName.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxName.Location = new System.Drawing.Point(99, 8);
            this.txtBoxName.MaxLength = 32;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(191, 25);
            this.txtBoxName.TabIndex = 32;
            this.txtBoxName.Tag = "Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label16.Location = new System.Drawing.Point(8, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 42;
            this.label16.Text = "ExamBook";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.comboBoxSex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(99, 102);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(191, 25);
            this.comboBoxSex.TabIndex = 36;
            this.comboBoxSex.Tag = "SexInt";
            this.comboBoxSex.SelectedIndexChanged += new System.EventHandler(this.comboBoxSex_SelectedIndexChanged);
            // 
            // txtBoxSurn
            // 
            this.txtBoxSurn.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSurn.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxSurn.Location = new System.Drawing.Point(99, 39);
            this.txtBoxSurn.MaxLength = 32;
            this.txtBoxSurn.Name = "txtBoxSurn";
            this.txtBoxSurn.Size = new System.Drawing.Size(191, 25);
            this.txtBoxSurn.TabIndex = 34;
            this.txtBoxSurn.Tag = "Surname";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 70);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 2, 26, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 26);
            this.dateTimePicker1.TabIndex = 35;
            this.dateTimePicker1.Tag = "BirthdayDT";
            this.dateTimePicker1.Value = new System.DateTime(2018, 2, 26, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label2.Location = new System.Drawing.Point(7, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "AverageMark";
            // 
            // numUpDownAvMark
            // 
            this.numUpDownAvMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numUpDownAvMark.Location = new System.Drawing.Point(99, 195);
            this.numUpDownAvMark.Name = "numUpDownAvMark";
            this.numUpDownAvMark.Size = new System.Drawing.Size(191, 26);
            this.numUpDownAvMark.TabIndex = 44;
            this.numUpDownAvMark.Tag = "AverageMark";
            this.numUpDownAvMark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EdStud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numUpDownAvMark);
            this.Controls.Add(this.numericUpDownExBook);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxGroups);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.txtBoxSurn);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdStud";
            this.Text = "EdStud";
            this.Load += new System.EventHandler(this.EdStud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownAvMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownExBook;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxGroups;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.TextBox txtBoxSurn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownAvMark;
    }
}