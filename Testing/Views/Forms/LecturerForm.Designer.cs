namespace Testing
{
    partial class LecturerForm
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
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxMark = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.listBoxSubj = new System.Windows.Forms.ListBox();
            this.dtTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxExperience = new System.Windows.Forms.TextBox();
            this.txtBoxSex = new System.Windows.Forms.TextBox();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(210, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(623, 416);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 226;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Surname";
            this.columnHeader2.Width = 280;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "AverageMark";
            this.columnHeader4.Width = 112;
            // 
            // txtBoxMark
            // 
            this.txtBoxMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBoxMark.Location = new System.Drawing.Point(288, 434);
            this.txtBoxMark.MaxLength = 3;
            this.txtBoxMark.Name = "txtBoxMark";
            this.txtBoxMark.Size = new System.Drawing.Size(190, 26);
            this.txtBoxMark.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.Location = new System.Drawing.Point(210, 434);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(77, 26);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.listBoxSubj);
            this.groupBox1.Controls.Add(this.dtTimePickerBirthday);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxExperience);
            this.groupBox1.Controls.Add(this.txtBoxSex);
            this.groupBox1.Controls.Add(this.txtBoxSurname);
            this.groupBox1.Controls.Add(this.txtBoxEmail);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 453);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROFILE";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnConfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirm.Location = new System.Drawing.Point(56, 422);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 26);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // listBoxSubj
            // 
            this.listBoxSubj.FormattingEnabled = true;
            this.listBoxSubj.Location = new System.Drawing.Point(8, 296);
            this.listBoxSubj.Name = "listBoxSubj";
            this.listBoxSubj.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxSubj.Size = new System.Drawing.Size(178, 121);
            this.listBoxSubj.TabIndex = 3;
            this.listBoxSubj.Tag = "ListSubjectsLecturer";
            // 
            // dtTimePickerBirthday
            // 
            this.dtTimePickerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTimePickerBirthday.Location = new System.Drawing.Point(8, 167);
            this.dtTimePickerBirthday.Name = "dtTimePickerBirthday";
            this.dtTimePickerBirthday.Size = new System.Drawing.Size(159, 23);
            this.dtTimePickerBirthday.TabIndex = 2;
            this.dtTimePickerBirthday.Tag = "BirthdayDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label6.Location = new System.Drawing.Point(5, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Experience";
            this.label6.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label5.Location = new System.Drawing.Point(6, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Subjects";
            this.label5.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label4.Location = new System.Drawing.Point(6, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sex";
            this.label4.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label3.Location = new System.Drawing.Point(5, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birthday";
            this.label3.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.label1.Location = new System.Drawing.Point(5, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname";
            this.label1.UseMnemonic = false;
            // 
            // txtBoxExperience
            // 
            this.txtBoxExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxExperience.Location = new System.Drawing.Point(8, 253);
            this.txtBoxExperience.MaxLength = 3;
            this.txtBoxExperience.Name = "txtBoxExperience";
            this.txtBoxExperience.Size = new System.Drawing.Size(162, 23);
            this.txtBoxExperience.TabIndex = 0;
            this.txtBoxExperience.Tag = "Experience";
            // 
            // txtBoxSex
            // 
            this.txtBoxSex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxSex.Location = new System.Drawing.Point(8, 210);
            this.txtBoxSex.MaxLength = 5;
            this.txtBoxSex.Name = "txtBoxSex";
            this.txtBoxSex.ReadOnly = true;
            this.txtBoxSex.Size = new System.Drawing.Size(162, 23);
            this.txtBoxSex.TabIndex = 0;
            this.txtBoxSex.Tag = "SexLect";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxSurname.Location = new System.Drawing.Point(8, 124);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(162, 23);
            this.txtBoxSurname.TabIndex = 0;
            this.txtBoxSurname.Tag = "Surname";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxEmail.Location = new System.Drawing.Point(8, 38);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(162, 23);
            this.txtBoxEmail.TabIndex = 0;
            this.txtBoxEmail.Tag = "Email";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxName.Location = new System.Drawing.Point(8, 81);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(162, 23);
            this.txtBoxName.TabIndex = 0;
            this.txtBoxName.Tag = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(787, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxMark);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LecturerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LecturerForm";
            this.Load += new System.EventHandler(this.LecturerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtBoxMark;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtTimePickerBirthday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxExperience;
        private System.Windows.Forms.TextBox txtBoxSex;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.ListBox listBoxSubj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button button1;
    }
}