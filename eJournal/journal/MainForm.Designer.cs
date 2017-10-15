namespace journal
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.comboBox_Choice = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_NewPas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(95, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЭлЖур";
            // 
            // button_Enter
            // 
            this.button_Enter.BackColor = System.Drawing.Color.White;
            this.button_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Enter.Location = new System.Drawing.Point(106, 190);
            this.button_Enter.Name = "button_Enter";
            this.button_Enter.Size = new System.Drawing.Size(85, 35);
            this.button_Enter.TabIndex = 4;
            this.button_Enter.Text = "Войти";
            this.button_Enter.UseVisualStyleBackColor = false;
            this.button_Enter.Click += new System.EventHandler(this.button_Enter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Логин:";
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(83, 74);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(183, 20);
            this.textBox_Login.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(83, 105);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(183, 20);
            this.textBox_Password.TabIndex = 2;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // comboBox_Choice
            // 
            this.comboBox_Choice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Choice.FormattingEnabled = true;
            this.comboBox_Choice.Items.AddRange(new object[] {
            "Студент",
            "Преподаватель",
            "Администратор"});
            this.comboBox_Choice.Location = new System.Drawing.Point(83, 139);
            this.comboBox_Choice.Name = "comboBox_Choice";
            this.comboBox_Choice.Size = new System.Drawing.Size(183, 21);
            this.comboBox_Choice.TabIndex = 3;
            this.comboBox_Choice.Text = "Выберите тип профиля";
            this.comboBox_Choice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Choice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "электронный журнал для колледжа";
            // 
            // label_NewPas
            // 
            this.label_NewPas.AutoSize = true;
            this.label_NewPas.Location = new System.Drawing.Point(29, 11);
            this.label_NewPas.Name = "label_NewPas";
            this.label_NewPas.Size = new System.Drawing.Size(0, 13);
            this.label_NewPas.TabIndex = 8;
            this.label_NewPas.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(294, 237);
            this.Controls.Add(this.label_NewPas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Choice);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Enter);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный журнал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.ComboBox comboBox_Choice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_NewPas;
    }
}

