namespace journal
{
    partial class NewPasswordDialog
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
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_newPas = new System.Windows.Forms.TextBox();
            this.textBox_NewPas2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.White;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(110, 103);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(150, 35);
            this.button_Save.TabIndex = 2;
            this.button_Save.Text = "Сохранить пароль";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите новый пароль: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Подтвердите новый пароль: ";
            // 
            // textBox_newPas
            // 
            this.textBox_newPas.Location = new System.Drawing.Point(203, 27);
            this.textBox_newPas.Name = "textBox_newPas";
            this.textBox_newPas.Size = new System.Drawing.Size(131, 20);
            this.textBox_newPas.TabIndex = 0;
            this.textBox_newPas.UseSystemPasswordChar = true;
            // 
            // textBox_NewPas2
            // 
            this.textBox_NewPas2.Location = new System.Drawing.Point(203, 63);
            this.textBox_NewPas2.Name = "textBox_NewPas2";
            this.textBox_NewPas2.Size = new System.Drawing.Size(131, 20);
            this.textBox_NewPas2.TabIndex = 1;
            this.textBox_NewPas2.UseSystemPasswordChar = true;
            // 
            // NewPasswordDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(346, 150);
            this.Controls.Add(this.textBox_NewPas2);
            this.Controls.Add(this.textBox_newPas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewPasswordDialog";
            this.Text = "Смена пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_newPas;
        private System.Windows.Forms.TextBox textBox_NewPas2;
    }
}