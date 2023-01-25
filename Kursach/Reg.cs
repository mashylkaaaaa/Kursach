using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {
           
        }

        private void label_1_Click(object sender, EventArgs e)
        {

        }

        private void label_2_Click(object sender, EventArgs e)
        {

        }

        private void NewLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            Database db = new Database("dataSource=dataBase.db");

            if (NewLogin.Text == "")
                MessageBox.Show("Заполните поле логина");
            else
            {
                if (NewPassword.Text == "")
                    MessageBox.Show("Заполните поле пароля");
                else
                {
                    if (NewPassword.Text.Length < 5 || NewPassword.Text.Length > 20)
                        MessageBox.Show("Пароль должен иметь не менее 5-х символов и не более 20");
                    else
                    {
                        if (NewLogin.Text.Length < 3 || NewLogin.Text.Length > 12)
                            MessageBox.Show("Логин должен иметь не менее 3-х символов и не более 12");
                        else
                        {
                            if (db.CheckCorrect(NewLogin.Text) == false)
                            {

                                string Hachpassword = db.Hash(NewPassword.Text);
                                db.CreateUser(NewLogin.Text, Hachpassword);
                                this.DialogResult = DialogResult.OK;
                                SHifr SHFR = new SHifr();
                                SHFR.FormClosed += (s, args) => this.Close();
                                this.Hide();
                                SHFR.Show();
                            }
                            else
                            {
                                MessageBox.Show("Имя уже занято");
                            }
                        }
                    }
                }
            }
        }
    }
}
