namespace journal.prepod
{
    partial class ViewStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudent));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_Info = new System.Windows.Forms.RichTextBox();
            this.label_birthday = new System.Windows.Forms.Label();
            this.label_Fio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Выберите преподавателя";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Информация о себе:";
            this.label1.Visible = false;
            // 
            // richTextBox_Info
            // 
            this.richTextBox_Info.Location = new System.Drawing.Point(42, 185);
            this.richTextBox_Info.Name = "richTextBox_Info";
            this.richTextBox_Info.ReadOnly = true;
            this.richTextBox_Info.Size = new System.Drawing.Size(235, 76);
            this.richTextBox_Info.TabIndex = 9;
            this.richTextBox_Info.Text = "";
            this.richTextBox_Info.Visible = false;
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_birthday.ForeColor = System.Drawing.Color.White;
            this.label_birthday.Location = new System.Drawing.Point(168, 109);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(112, 17);
            this.label_birthday.TabIndex = 8;
            this.label_birthday.Text = "Дата Рождения";
            this.label_birthday.Visible = false;
            // 
            // label_Fio
            // 
            this.label_Fio.AutoSize = true;
            this.label_Fio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Fio.ForeColor = System.Drawing.Color.White;
            this.label_Fio.Location = new System.Drawing.Point(168, 72);
            this.label_Fio.Name = "label_Fio";
            this.label_Fio.Size = new System.Drawing.Size(99, 17);
            this.label_Fio.TabIndex = 7;
            this.label_Fio.Text = "Фамилия И.О";
            this.label_Fio.Visible = false;
            // 
            // pictureBox1
            // 
         //   this.pictureBox1.BackgroundImage = global::journal.Properties.Resources.prepod;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(42, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 104);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Предметы:";
            this.label2.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(42, 289);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(235, 60);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(300, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox_Info);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_birthday);
            this.Controls.Add(this.label_Fio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о преподавателе";
            this.Load += new System.EventHandler(this.ViewPrepod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_Info;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.Label label_Fio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}