namespace journal.administrator
{
    partial class AdminMain
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
            this.button_AddPrepod = new System.Windows.Forms.Button();
            this.button_AddStudent = new System.Windows.Forms.Button();
            this.button_AddGrup = new System.Windows.Forms.Button();
            this.button_DeleteGrup = new System.Windows.Forms.Button();
            this.button_DeletePrepod = new System.Windows.Forms.Button();
            this.button_DeleteStudent = new System.Windows.Forms.Button();
            this.button_AddPredmet = new System.Windows.Forms.Button();
            this.button_DeletePredmet = new System.Windows.Forms.Button();
            this.button_ShowTables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_AddPrepod
            // 
            this.button_AddPrepod.Location = new System.Drawing.Point(12, 12);
            this.button_AddPrepod.Name = "button_AddPrepod";
            this.button_AddPrepod.Size = new System.Drawing.Size(128, 35);
            this.button_AddPrepod.TabIndex = 0;
            this.button_AddPrepod.Text = "Добавить преподавателя";
            this.button_AddPrepod.UseVisualStyleBackColor = true;
            this.button_AddPrepod.Click += new System.EventHandler(this.button_AddPrepod_Click);
            // 
            // button_AddStudent
            // 
            this.button_AddStudent.Location = new System.Drawing.Point(12, 53);
            this.button_AddStudent.Name = "button_AddStudent";
            this.button_AddStudent.Size = new System.Drawing.Size(128, 36);
            this.button_AddStudent.TabIndex = 2;
            this.button_AddStudent.Text = "Добавить студента";
            this.button_AddStudent.UseVisualStyleBackColor = true;
            this.button_AddStudent.Click += new System.EventHandler(this.button_AddStudent_Click);
            // 
            // button_AddGrup
            // 
            this.button_AddGrup.Location = new System.Drawing.Point(12, 95);
            this.button_AddGrup.Name = "button_AddGrup";
            this.button_AddGrup.Size = new System.Drawing.Size(128, 35);
            this.button_AddGrup.TabIndex = 4;
            this.button_AddGrup.Text = "Добавить группу";
            this.button_AddGrup.UseVisualStyleBackColor = true;
            this.button_AddGrup.Click += new System.EventHandler(this.button_AddGrup_Click);
            // 
            // button_DeleteGrup
            // 
            this.button_DeleteGrup.Location = new System.Drawing.Point(144, 95);
            this.button_DeleteGrup.Name = "button_DeleteGrup";
            this.button_DeleteGrup.Size = new System.Drawing.Size(128, 35);
            this.button_DeleteGrup.TabIndex = 5;
            this.button_DeleteGrup.Text = "Удалить группу";
            this.button_DeleteGrup.UseVisualStyleBackColor = true;
            this.button_DeleteGrup.Click += new System.EventHandler(this.button_DeleteGrup_Click);
            // 
            // button_DeletePrepod
            // 
            this.button_DeletePrepod.Location = new System.Drawing.Point(146, 12);
            this.button_DeletePrepod.Name = "button_DeletePrepod";
            this.button_DeletePrepod.Size = new System.Drawing.Size(128, 35);
            this.button_DeletePrepod.TabIndex = 1;
            this.button_DeletePrepod.Text = "Удалить Преподавателя";
            this.button_DeletePrepod.UseVisualStyleBackColor = true;
            this.button_DeletePrepod.Click += new System.EventHandler(this.button_DeletePrepod_Click);
            // 
            // button_DeleteStudent
            // 
            this.button_DeleteStudent.Location = new System.Drawing.Point(147, 53);
            this.button_DeleteStudent.Name = "button_DeleteStudent";
            this.button_DeleteStudent.Size = new System.Drawing.Size(125, 36);
            this.button_DeleteStudent.TabIndex = 3;
            this.button_DeleteStudent.Text = "Удалить студента";
            this.button_DeleteStudent.UseVisualStyleBackColor = true;
            this.button_DeleteStudent.Click += new System.EventHandler(this.button_DeleteStudent_Click);
            // 
            // button_AddPredmet
            // 
            this.button_AddPredmet.Location = new System.Drawing.Point(12, 136);
            this.button_AddPredmet.Name = "button_AddPredmet";
            this.button_AddPredmet.Size = new System.Drawing.Size(128, 35);
            this.button_AddPredmet.TabIndex = 6;
            this.button_AddPredmet.Text = "Добавить предмет";
            this.button_AddPredmet.UseVisualStyleBackColor = true;
            this.button_AddPredmet.Click += new System.EventHandler(this.button_AddPredmet_Click);
            // 
            // button_DeletePredmet
            // 
            this.button_DeletePredmet.Location = new System.Drawing.Point(147, 136);
            this.button_DeletePredmet.Name = "button_DeletePredmet";
            this.button_DeletePredmet.Size = new System.Drawing.Size(128, 35);
            this.button_DeletePredmet.TabIndex = 7;
            this.button_DeletePredmet.Text = "Удалить предмет";
            this.button_DeletePredmet.UseVisualStyleBackColor = true;
            this.button_DeletePredmet.Click += new System.EventHandler(this.button_DeletePredmet_Click);
            // 
            // button_ShowTables
            // 
            this.button_ShowTables.Location = new System.Drawing.Point(12, 177);
            this.button_ShowTables.Name = "button_ShowTables";
            this.button_ShowTables.Size = new System.Drawing.Size(260, 35);
            this.button_ShowTables.TabIndex = 6;
            this.button_ShowTables.Text = "Просмотр таблиц БД";
            this.button_ShowTables.UseVisualStyleBackColor = true;
            this.button_ShowTables.Click += new System.EventHandler(this.button_ShowTables_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.button_DeleteStudent);
            this.Controls.Add(this.button_DeletePrepod);
            this.Controls.Add(this.button_DeleteGrup);
            this.Controls.Add(this.button_DeletePredmet);
            this.Controls.Add(this.button_ShowTables);
            this.Controls.Add(this.button_AddPredmet);
            this.Controls.Add(this.button_AddGrup);
            this.Controls.Add(this.button_AddStudent);
            this.Controls.Add(this.button_AddPrepod);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Activated += new System.EventHandler(this.AdminMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddPrepod;
        private System.Windows.Forms.Button button_AddStudent;
        private System.Windows.Forms.Button button_AddGrup;
        private System.Windows.Forms.Button button_DeleteGrup;
        private System.Windows.Forms.Button button_DeletePrepod;
        private System.Windows.Forms.Button button_DeleteStudent;
        private System.Windows.Forms.Button button_AddPredmet;
        private System.Windows.Forms.Button button_DeletePredmet;
        private System.Windows.Forms.Button button_ShowTables;
    }
}