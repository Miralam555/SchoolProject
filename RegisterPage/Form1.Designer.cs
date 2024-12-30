namespace RegisterPage
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameAd = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Fin = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Email = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.TextBox();
            this.teacher = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ixtisas = new System.Windows.Forms.TextBox();
            this.sinif = new System.Windows.Forms.TextBox();
            this.SagirdT = new System.Windows.Forms.TextBox();
            this.SagirdS = new System.Windows.Forms.TextBox();
            this.QeydiyyatdanKec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(232, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qeydiyyat Formu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameAd
            // 
            this.NameAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameAd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameAd.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NameAd.Location = new System.Drawing.Point(52, 135);
            this.NameAd.Multiline = true;
            this.NameAd.Name = "NameAd";
            this.NameAd.Size = new System.Drawing.Size(132, 26);
            this.NameAd.TabIndex = 3;
            this.NameAd.Text = "Ad";
            this.NameAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameAd.TextChanged += new System.EventHandler(this.NameAd_TextChanged);
            this.NameAd.Enter += new System.EventHandler(this.Name_TextEnter);
            this.NameAd.Leave += new System.EventHandler(this.Name_TextLeave);
            // 
            // Surname
            // 
            this.Surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Surname.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Surname.Location = new System.Drawing.Point(275, 135);
            this.Surname.Multiline = true;
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(134, 26);
            this.Surname.TabIndex = 4;
            this.Surname.Text = "Soyad";
            this.Surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            this.Surname.Enter += new System.EventHandler(this.Surname_TextEnter);
            this.Surname.Leave += new System.EventHandler(this.Surname_textLeave);
            // 
            // Fin
            // 
            this.Fin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Fin.Location = new System.Drawing.Point(479, 135);
            this.Fin.Multiline = true;
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(149, 26);
            this.Fin.TabIndex = 5;
            this.Fin.Text = "FİN";
            this.Fin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Fin.Enter += new System.EventHandler(this.Fin_TextEnter);
            this.Fin.Leave += new System.EventHandler(this.Fin_TextLeave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(479, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 26);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Email.Location = new System.Drawing.Point(52, 180);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(132, 26);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Enter += new System.EventHandler(this.Email_TextEnter);
            this.Email.Leave += new System.EventHandler(this.Email_textLeave);
            // 
            // Telefon
            // 
            this.Telefon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Telefon.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefon.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Telefon.Location = new System.Drawing.Point(275, 180);
            this.Telefon.Multiline = true;
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(134, 26);
            this.Telefon.TabIndex = 8;
            this.Telefon.Text = "Əlaqə Telefonu";
            this.Telefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefon.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.Telefon.Enter += new System.EventHandler(this.Telefon_textEnter);
            this.Telefon.Leave += new System.EventHandler(this.Telefon_textLeave);
            // 
            // teacher
            // 
            this.teacher.AutoSize = true;
            this.teacher.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.teacher.Location = new System.Drawing.Point(175, 222);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(92, 26);
            this.teacher.TabIndex = 9;
            this.teacher.TabStop = true;
            this.teacher.Text = "Müəllim";
            this.teacher.UseVisualStyleBackColor = true;
            this.teacher.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.radioButton1.Location = new System.Drawing.Point(391, 222);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 26);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Şagird";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ixtisas
            // 
            this.ixtisas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ixtisas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ixtisas.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ixtisas.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ixtisas.Location = new System.Drawing.Point(52, 270);
            this.ixtisas.Multiline = true;
            this.ixtisas.Name = "ixtisas";
            this.ixtisas.Size = new System.Drawing.Size(132, 26);
            this.ixtisas.TabIndex = 11;
            this.ixtisas.Text = "İxtisası";
            this.ixtisas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ixtisas.Visible = false;
            this.ixtisas.TextChanged += new System.EventHandler(this.Telefon_textLeave);
            this.ixtisas.Enter += new System.EventHandler(this.İxtisas_TextEnter);
            this.ixtisas.Leave += new System.EventHandler(this.İxtisas_TextLeave);
            // 
            // sinif
            // 
            this.sinif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sinif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sinif.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinif.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.sinif.Location = new System.Drawing.Point(52, 320);
            this.sinif.Multiline = true;
            this.sinif.Name = "sinif";
            this.sinif.Size = new System.Drawing.Size(132, 26);
            this.sinif.TabIndex = 12;
            this.sinif.Text = "Dərs keçdiyi sinif";
            this.sinif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sinif.TextChanged += new System.EventHandler(this.sinif_TextChanged);
            this.sinif.Enter += new System.EventHandler(this.sinif_textEnter);
            this.sinif.Leave += new System.EventHandler(this.sinif_textLeave);
            // 
            // SagirdT
            // 
            this.SagirdT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SagirdT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SagirdT.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SagirdT.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SagirdT.Location = new System.Drawing.Point(418, 270);
            this.SagirdT.Multiline = true;
            this.SagirdT.Name = "SagirdT";
            this.SagirdT.Size = new System.Drawing.Size(210, 26);
            this.SagirdT.TabIndex = 13;
            this.SagirdT.Text = "Valideynin əlaqe telefonu";
            this.SagirdT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SagirdT.TextChanged += new System.EventHandler(this.SagirdT_TextChanged);
            this.SagirdT.Enter += new System.EventHandler(this.SagirdT_textEnter);
            this.SagirdT.Leave += new System.EventHandler(this.SagirdT_textLeave);
            // 
            // SagirdS
            // 
            this.SagirdS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SagirdS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SagirdS.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SagirdS.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SagirdS.Location = new System.Drawing.Point(418, 320);
            this.SagirdS.Multiline = true;
            this.SagirdS.Name = "SagirdS";
            this.SagirdS.Size = new System.Drawing.Size(210, 26);
            this.SagirdS.TabIndex = 14;
            this.SagirdS.Text = "Oxuduğu sinif";
            this.SagirdS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SagirdS.Enter += new System.EventHandler(this.SagirdS_textEnter);
            this.SagirdS.Leave += new System.EventHandler(this.SagirdS_textLeave);
            // 
            // QeydiyyatdanKec
            // 
            this.QeydiyyatdanKec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.QeydiyyatdanKec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QeydiyyatdanKec.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QeydiyyatdanKec.ForeColor = System.Drawing.Color.White;
            this.QeydiyyatdanKec.Location = new System.Drawing.Point(226, 397);
            this.QeydiyyatdanKec.Name = "QeydiyyatdanKec";
            this.QeydiyyatdanKec.Size = new System.Drawing.Size(226, 42);
            this.QeydiyyatdanKec.TabIndex = 15;
            this.QeydiyyatdanKec.Text = "Qeydiyyatdan Keç";
            this.QeydiyyatdanKec.UseVisualStyleBackColor = false;
            this.QeydiyyatdanKec.UseWaitCursor = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 451);
            this.Controls.Add(this.QeydiyyatdanKec);
            this.Controls.Add(this.SagirdS);
            this.Controls.Add(this.SagirdT);
            this.Controls.Add(this.sinif);
            this.Controls.Add(this.ixtisas);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.NameAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameAd;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Fin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Telefon;
        private System.Windows.Forms.RadioButton teacher;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox ixtisas;
        private System.Windows.Forms.TextBox sinif;
        private System.Windows.Forms.TextBox SagirdT;
        private System.Windows.Forms.TextBox SagirdS;
        private System.Windows.Forms.Button QeydiyyatdanKec;
    }
}

