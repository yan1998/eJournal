namespace journal.administrator
{
    partial class AddStudent
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
            this.button_Add = new System.Windows.Forms.Button();
            this.richTextBox_Information = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker_Birthday = new System.Windows.Forms.DateTimePicker();
            this.textBox_Patronumic = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_Grups = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(18, 327);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // richTextBox_Information
            // 
            this.richTextBox_Information.Location = new System.Drawing.Point(14, 239);
            this.richTextBox_Information.Name = "richTextBox_Information";
            this.richTextBox_Information.Size = new System.Drawing.Size(258, 81);
            this.richTextBox_Information.TabIndex = 7;
            this.richTextBox_Information.Text = "";
            // 
            // dateTimePicker_Birthday
            // 
            this.dateTimePicker_Birthday.Location = new System.Drawing.Point(133, 195);
            this.dateTimePicker_Birthday.Name = "dateTimePicker_Birthday";
            this.dateTimePicker_Birthday.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker_Birthday.TabIndex = 6;
            this.dateTimePicker_Birthday.Value = new System.DateTime(2017, 5, 26, 19, 41, 10, 0);
            // 
            // textBox_Patronumic
            // 
            this.textBox_Patronumic.Location = new System.Drawing.Point(93, 107);
            this.textBox_Patronumic.Name = "textBox_Patronumic";
            this.textBox_Patronumic.Size = new System.Drawing.Size(180, 20);
            this.textBox_Patronumic.TabIndex = 3;
            this.textBox_Patronumic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(93, 47);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(180, 20);
            this.textBox_Surname.TabIndex = 1;
            this.textBox_Surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(93, 17);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(180, 20);
            this.textBox_Login.TabIndex = 0;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(93, 77);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(180, 20);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Доп.Информация:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "День Рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя:";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(198, 326);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Моб.Тел:";
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(93, 135);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(180, 20);
            this.textBox_PhoneNumber.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Группа: ";
            // 
            // comboBox_Grups
            // 
            this.comboBox_Grups.FormattingEnabled = true;
            this.comboBox_Grups.Location = new System.Drawing.Point(93, 166);
            this.comboBox_Grups.Name = "comboBox_Grups";
            this.comboBox_Grups.Size = new System.Drawing.Size(179, 21);
            this.comboBox_Grups.TabIndex = 5;
            this.comboBox_Grups.Text = "Выберите группу";
            this.comboBox_Grups.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Grups_KeyPress);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(288, 357);
            this.Controls.Add(this.comboBox_Grups);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.richTextBox_Information);
            this.Controls.Add(this.dateTimePicker_Birthday);
            this.Controls.Add(this.textBox_PhoneNumber);
            this.Controls.Add(this.textBox_Patronumic);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление студента";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.RichTextBox richTextBox_Information;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Birthday;
        private System.Windows.Forms.TextBox textBox_Patronumic;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Grups;
    }
}