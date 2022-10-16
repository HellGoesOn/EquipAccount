using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipAccount
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s= $"[{textBox2.Text}={textBox3.Text}]";
                File.WriteAllLines("users.txt", new string[] {s});
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }

    }
}
