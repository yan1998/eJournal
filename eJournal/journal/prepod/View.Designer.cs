namespace journal.prepod
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.label_birthday = new System.Windows.Forms.Label();
            this.label_Fio = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Phone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Информация о себе:";
            this.label1.Visible = false;
            // 
            // richTextBox_Info
            // 
            this.richTextBox_Info.Location = new System.Drawing.Point(27, 179);
            this.richTextBox_Info.Name = "richTextBox_Info";
            this.richTextBox_Info.ReadOnly = true;
            this.richTextBox_Info.Size = new System.Drawing.Size(235, 76);
            this.richTextBox_Info.TabIndex = 17;
            this.richTextBox_Info.Text = "";
            this.richTextBox_Info.Visible = false;
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_birthday.ForeColor = System.Drawing.Color.White;
            this.label_birthday.Location = new System.Drawing.Point(153, 93);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(112, 17);
            this.label_birthday.TabIndex = 15;
            this.label_birthday.Text = "Дата Рождения";
            this.label_birthday.Visible = false;
            // 
            // label_Fio
            // 
            this.label_Fio.AutoSize = true;
            this.label_Fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Fio.ForeColor = System.Drawing.Color.White;
            this.label_Fio.Location = new System.Drawing.Point(153, 59);
            this.label_Fio.Name = "label_Fio";
            this.label_Fio.Size = new System.Drawing.Size(99, 17);
            this.label_Fio.TabIndex = 13;
            this.label_Fio.Text = "Фамилия И.О";
            this.label_Fio.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Выберите студента";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
         //   this.pictureBox1.BackgroundImage = global::journal.Properties.Resources.student;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(27, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 95);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Phone.ForeColor = System.Drawing.Color.White;
            this.label_Phone.Location = new System.Drawing.Point(147, 125);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(121, 17);
            this.label_Phone.TabIndex = 15;
            this.label_Phone.Text = "Номер телефона";
            this.label_Phone.Visible = false;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(286, 279);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Info);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.label_birthday);
            this.Controls.Add(this.label_Fio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о студенте";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_Info;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.Label label_Fio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_Phone;
    }
}