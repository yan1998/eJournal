namespace journal.prepod
{
    partial class EnterMarks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterMarks));
            this.comboBox_Predmet = new System.Windows.Forms.ComboBox();
            this.comboBox_Group = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Predmet
            // 
            this.comboBox_Predmet.FormattingEnabled = true;
            this.comboBox_Predmet.Location = new System.Drawing.Point(12, 35);
            this.comboBox_Predmet.Name = "comboBox_Predmet";
            this.comboBox_Predmet.Size = new System.Drawing.Size(251, 21);
            this.comboBox_Predmet.TabIndex = 0;
            this.comboBox_Predmet.Text = "Выберите предмет";
            // 
            // comboBox_Group
            // 
            this.comboBox_Group.FormattingEnabled = true;
            this.comboBox_Group.Location = new System.Drawing.Point(12, 8);
            this.comboBox_Group.Name = "comboBox_Group";
            this.comboBox_Group.Size = new System.Drawing.Size(251, 21);
            this.comboBox_Group.TabIndex = 0;
            this.comboBox_Group.Text = "Выберите группу";
            this.comboBox_Group.SelectedIndexChanged += new System.EventHandler(this.comboBox_Group_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(12, 62);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(120, 32);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // EnterMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(269, 334);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_Group);
            this.Controls.Add(this.comboBox_Predmet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EnterMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Журнал оценок";
            this.Load += new System.EventHandler(this.EnterMarks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Predmet;
        private System.Windows.Forms.ComboBox comboBox_Group;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Cancel;
    }
}