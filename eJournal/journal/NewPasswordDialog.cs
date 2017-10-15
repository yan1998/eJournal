using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace journal
{
    public partial class NewPasswordDialog : Form
    {
        MainForm form;//форма, с которой был осуществлен вызов

        public NewPasswordDialog(MainForm form)
        {
            InitializeComponent();
            this.form = form;//получение формы
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_newPas.Text == "" || textBox_NewPas2.Text == "")
            {
                MessageBox.Show("Введите новый пароль!");
                return;
            }
            else if (textBox_newPas.Text != textBox_NewPas2.Text)
            {
                MessageBox.Show("Пароли не сопадают!");
                return;
            }
            else
            {
                form.Controls["label_NewPas"].Text = textBox_newPas.Text;//чтение нового пороля
                MessageBox.Show("Пароль был успешно изменен!");
                this.Close();
            }
        }
    }
}
