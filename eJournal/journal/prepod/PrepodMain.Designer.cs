namespace journal.prepod
{
    partial class PrepodMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrepodMain));
            this.label_Fio = new System.Windows.Forms.Label();
            this.label_birthday = new System.Windows.Forms.Label();
            this.richTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Fio
            // 
            this.label_Fio.AutoSize = true;
            this.label_Fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Fio.ForeColor = System.Drawing.Color.White;
            this.label_Fio.Location = new System.Drawing.Point(131, 22);
            this.label_Fio.Name = "label_Fio";
            this.label_Fio.Size = new System.Drawing.Size(99, 17);
            this.label_Fio.TabIndex = 1;
            this.label_Fio.Text = "Фамилия И.О";
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_birthday.ForeColor = System.Drawing.Color.White;
            this.label_birthday.Location = new System.Drawing.Point(131, 59);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(112, 17);
            this.label_birthday.TabIndex = 2;
            this.label_birthday.Text = "Дата Рождения";
            // 
            // richTextBox_Info
            // 
            this.richTextBox_Info.Location = new System.Drawing.Point(5, 135);
            this.richTextBox_Info.Name = "richTextBox_Info";
            this.richTextBox_Info.ReadOnly = true;
            this.richTextBox_Info.Size = new System.Drawing.Size(235, 76);
            this.richTextBox_Info.TabIndex = 3;
            this.richTextBox_Info.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Информация о себе:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(54, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выбрать предмет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Info
            // 
            this.button_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Info.Location = new System.Drawing.Point(17, 257);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(222, 31);
            this.button_Info.TabIndex = 5;
            this.button_Info.Text = "Информация о студенте";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // pictureBox1
            // 
           // this.pictureBox1.BackgroundImage = global::journal.Properties.Resources.prepod;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PrepodMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(252, 299);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Info);
            this.Controls.Add(this.label_birthday);
            this.Controls.Add(this.label_Fio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PrepodMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrepodMain";
            this.Activated += new System.EventHandler(this.PrepodMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrepodMain_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Fio;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.RichTextBox richTextBox_Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Info;
    }
}