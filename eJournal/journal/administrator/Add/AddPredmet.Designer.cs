using System;

namespace journal.administrator
{
    partial class AddPredmet
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Prepods = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название предмета:";
            // 
            // button_Add
            // 
            this.button_Add.ForeColor = System.Drawing.Color.Black;
            this.button_Add.Location = new System.Drawing.Point(15, 71);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(141, 34);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(200, 71);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(131, 34);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(162, 16);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(169, 20);
            this.textBox_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выберите преподавателя:";
            // 
            // comboBox_Prepods
            // 
            this.comboBox_Prepods.FormattingEnabled = true;
            this.comboBox_Prepods.Location = new System.Drawing.Point(200, 44);
            this.comboBox_Prepods.Name = "comboBox_Prepods";
            this.comboBox_Prepods.Size = new System.Drawing.Size(131, 21);
            this.comboBox_Prepods.TabIndex = 4;
            this.comboBox_Prepods.Text = "Выберите";
            this.comboBox_Prepods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Predmets_KeyPress);
            // 
            // AddPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(343, 117);
            this.Controls.Add(this.comboBox_Prepods);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddPredmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление группы";
            this.Load += new System.EventHandler(this.AddPredmet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Prepods;
    }
}