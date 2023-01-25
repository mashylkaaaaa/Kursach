using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Authorithation_Form : Form
    {
        public Authorithation_Form()
        {
            InitializeComponent();
        }

        private void Authorithation_Form_Load(object sender, EventArgs e)
        {

        }

        private void VhodButton_Click(object sender, EventArgs e)
        {
            Database database = new Database("DataSource=DataBase.db");
            if (Log_in.Text == "")
                MessageBox.Show("Заполните поле логина");
            else
            {
                if (pasword.Text == "")
                    MessageBox.Show("Заполните поле пароля");
                else
                {
                    if (pasword.Text.Length < 6)
                        MessageBox.Show("Пароль должен иметь не менее 5-х символов и не более 20");
                    else
                    {
                        if (Log_in.Text.Length < 3)
                            MessageBox.Show("Логин должен иметь не менее 3-х символов и не более 12");
                        else
                        {
                            string Hachpassword = database.Hash(pasword.Text);
                            if (database.CheckUser(Log_in.Text, Hachpassword))
                            {
                                this.Hide();
                                var SH = new SHifr();
                                SH.Closed += (s, args) => this.Close();
                                SH.Show();
                            }
                            else
                            {
                                MessageBox.Show("Неверно введенные логин или пароль!");
                            }
                        }
                    }
                }
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rg = new Reg();
            rg.Closed += (s, args) => this.Close();
            rg.Show();
        }

        private void Log_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pasword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
