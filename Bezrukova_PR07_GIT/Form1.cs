using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bezrukova_PR07_GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (username == "admin" && password == "password")
            {
                // Если авторизация успешна, открываем форму администратора
                Adminform adminForm = new Adminform();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные учетные данные. Попробуйте еще раз.");
            }
        }
    }
}
