namespace journal.administrator
{
    partial class DeleteGrup
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Grups = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(145, 42);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(108, 34);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(12, 42);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(126, 34);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название группы:";
            // 
            // comboBox_Grups
            // 
            this.comboBox_Grups.FormattingEnabled = true;
            this.comboBox_Grups.Location = new System.Drawing.Point(145, 11);
            this.comboBox_Grups.Name = "comboBox_Grups";
            this.comboBox_Grups.Size = new System.Drawing.Size(108, 21);
            this.comboBox_Grups.TabIndex = 7;
            this.comboBox_Grups.Text = "Выберите группу";
            this.comboBox_Grups.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_Grups_KeyPress);
            // 
            // DeleteGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(265, 87);
            this.Controls.Add(this.comboBox_Grups);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "DeleteGrup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить группу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Grups;
    }
}