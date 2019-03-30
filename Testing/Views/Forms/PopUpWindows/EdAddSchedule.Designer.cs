namespace Testing.Views.Forms.PopUpWindows
{
    partial class EdAddSchedule
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
            this.btnExit = new System.Windows.Forms.Button();
            this.numericUpDownSubj = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxSubj = new System.Windows.Forms.TextBox();
            this.txtBoxGroup = new System.Windows.Forms.TextBox();
            this.txtBoxLecturer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubj)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Britannic Bold", 8.25F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(276, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(41, 22);
            this.btnExit.TabIndex = 80;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // numericUpDownSubj
            // 
            this.numericUpDownSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownSubj.Location = new System.Drawing.Point(85, 39);
            this.numericUpDownSubj.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSubj.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSubj.Name = "numericUpDownSubj";
            this.numericUpDownSubj.Size = new System.Drawing.Size(205, 26);
            this.numericUpDownSubj.TabIndex = 79;
            this.numericUpDownSubj.Tag = "Experience";
            this.numericUpDownSubj.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.label1.Location = new System.Drawing.Point(0, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 68;
            this.label1.Text = "Lecturer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.label5.Location = new System.Drawing.Point(0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 69;
            this.label5.Text = "Day";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.label7.Location = new System.Drawing.Point(-1, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 70;
            this.label7.Text = "Subject";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(63, 164);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(172, 31);
            this.btnSubmit.TabIndex = 76;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.label15.Location = new System.Drawing.Point(0, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 21);
            this.label15.TabIndex = 78;
            this.label15.Text = "Subject N";
            // 
            // txtBoxSubj
            // 
            this.txtBoxSubj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxSubj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxSubj.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxSubj.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxSubj.Location = new System.Drawing.Point(85, 71);
            this.txtBoxSubj.MaxLength = 20;
            this.txtBoxSubj.Name = "txtBoxSubj";
            this.txtBoxSubj.Size = new System.Drawing.Size(205, 25);
            this.txtBoxSubj.TabIndex = 72;
            this.txtBoxSubj.Tag = "Name";
            // 
            // txtBoxGroup
            // 
            this.txtBoxGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxGroup.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxGroup.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxGroup.Location = new System.Drawing.Point(85, 102);
            this.txtBoxGroup.MaxLength = 20;
            this.txtBoxGroup.Name = "txtBoxGroup";
            this.txtBoxGroup.Size = new System.Drawing.Size(205, 25);
            this.txtBoxGroup.TabIndex = 72;
            this.txtBoxGroup.Tag = "Name";
            // 
            // txtBoxLecturer
            // 
            this.txtBoxLecturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxLecturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxLecturer.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxLecturer.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.txtBoxLecturer.Location = new System.Drawing.Point(85, 133);
            this.txtBoxLecturer.MaxLength = 20;
            this.txtBoxLecturer.Name = "txtBoxLecturer";
            this.txtBoxLecturer.Size = new System.Drawing.Size(205, 25);
            this.txtBoxLecturer.TabIndex = 72;
            this.txtBoxLecturer.Tag = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.label2.Location = new System.Drawing.Point(-1, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Group";
            // 
            // comboBoxDays
            // 
            this.comboBoxDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxDays.FormattingEnabled = true;
            this.comboBoxDays.Location = new System.Drawing.Point(85, 5);
            this.comboBoxDays.Name = "comboBoxDays";
            this.comboBoxDays.Size = new System.Drawing.Size(205, 28);
            this.comboBoxDays.TabIndex = 81;
            // 
            // EdAddSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 202);
            this.Controls.Add(this.comboBoxDays);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.numericUpDownSubj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtBoxLecturer);
            this.Controls.Add(this.txtBoxGroup);
            this.Controls.Add(this.txtBoxSubj);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EdAddSchedule";
            this.Text = "EdAddSchedule";
            this.Load += new System.EventHandler(this.EdAddSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSubj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown numericUpDownSubj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxSubj;
        private System.Windows.Forms.TextBox txtBoxGroup;
        private System.Windows.Forms.TextBox txtBoxLecturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDays;
    }
}