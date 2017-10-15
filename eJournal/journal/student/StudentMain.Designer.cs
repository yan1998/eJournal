namespace journal.prepod
{
    partial class StudentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_birthday = new System.Windows.Forms.Label();
            this.label_Fio = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Dnevnik = new System.Windows.Forms.Button();
            this.button_journal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
         //   this.pictureBox1.BackgroundImage = global::journal.Properties.Resources.student;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_birthday.ForeColor = System.Drawing.Color.White;
            this.label_birthday.Location = new System.Drawing.Point(127, 55);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(112, 17);
            this.label_birthday.TabIndex = 4;
            this.label_birthday.Text = "Дата Рождения";
            // 
            // label_Fio
            // 
            this.label_Fio.AutoSize = true;
            this.label_Fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Fio.ForeColor = System.Drawing.Color.White;
            this.label_Fio.Location = new System.Drawing.Point(124, 25);
            this.label_Fio.Name = "label_Fio";
            this.label_Fio.Size = new System.Drawing.Size(99, 17);
            this.label_Fio.TabIndex = 3;
            this.label_Fio.Text = "Фамилия И.О";
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Phone.ForeColor = System.Drawing.Color.White;
            this.label_Phone.Location = new System.Drawing.Point(129, 98);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(68, 17);
            this.label_Phone.TabIndex = 4;
            this.label_Phone.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Информация о себе:";
            // 
            // richTextBox_Info
            // 
            this.richTextBox_Info.Location = new System.Drawing.Point(5, 142);
            this.richTextBox_Info.Name = "richTextBox_Info";
            this.richTextBox_Info.ReadOnly = true;
            this.richTextBox_Info.Size = new System.Drawing.Size(235, 76);
            this.richTextBox_Info.TabIndex = 5;
            this.richTextBox_Info.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(127, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "моб.тел:";
            // 
            // button_Dnevnik
            // 
            this.button_Dnevnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Dnevnik.Location = new System.Drawing.Point(87, 224);
            this.button_Dnevnik.Name = "button_Dnevnik";
            this.button_Dnevnik.Size = new System.Drawing.Size(87, 32);
            this.button_Dnevnik.TabIndex = 9;
            this.button_Dnevnik.Text = "Дневник";
            this.button_Dnevnik.UseVisualStyleBackColor = true;
            this.button_Dnevnik.Click += new System.EventHandler(this.button_Dnevnik_Click);
            // 
            // button_journal
            // 
            this.button_journal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_journal.Location = new System.Drawing.Point(51, 260);
            this.button_journal.Name = "button_journal";
            this.button_journal.Size = new System.Drawing.Size(159, 32);
            this.button_journal.TabIndex = 9;
            this.button_journal.Text = "Журнал всей группы";
            this.button_journal.UseVisualStyleBackColor = true;
            this.button_journal.Click += new System.EventHandler(this.button_journal_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "Информация о преподавателе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(252, 347);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_journal);
            this.Controls.Add(this.button_Dnevnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Info);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_birthday);
            this.Controls.Add(this.label_Fio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMain";
            this.Activated += new System.EventHandler(this.StudentMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.Label label_Fio;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Dnevnik;
        private System.Windows.Forms.Button button_journal;
        private System.Windows.Forms.Button button2;
    }
}