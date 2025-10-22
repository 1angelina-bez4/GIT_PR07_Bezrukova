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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = "Безрукова Ангелина Олеговна";
            label4.Text = Convert.ToString(DateTime.Now);

        }
    }
}
