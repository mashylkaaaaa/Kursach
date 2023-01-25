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
    public partial class SHifr : Form
    {
        Vigenere V = new Vigenere();
        private int lang;

        private OpenFileDialog OFD;
        private SaveFileDialog SFD;

        public SHifr()
        {
            InitializeComponent();

        }

        private void SHifr_Load(object sender, EventArgs e)
        {
            OFD = new OpenFileDialog();
            SFD = new SaveFileDialog();      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = V.Vigenerecipher(richTextBox1.Text, textBox1.Text, lang);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = V.VigenereDEcipher(richTextBox1.Text, textBox1.Text, lang);
        }

        private void radioButton_kirillica_CheckedChanged(object sender, EventArgs e)
        {
            lang = 0;
        }

        private void radioButton_kirillica1_CheckedChanged(object sender, EventArgs e)
        {
            lang = 1;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = SFD.FileName;
            System.IO.File.WriteAllText(filename, richTextBox2.Text);
            MessageBox.Show("Файл сохранен.");
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = OFD.FileName;
            string fileText = System.IO.File.ReadAllText(filename); 
            richTextBox1.Text = fileText;
            MessageBox.Show("Файл открыт." + " " +
                " Не забудьте ввести ключ, который у вас был или новый.");
        }
    }
}
