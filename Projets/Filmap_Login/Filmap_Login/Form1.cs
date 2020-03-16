using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Filmap_Login
{
    public partial class Form1 : Form
    {
        Scripts scripts = new Scripts();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            scripts.MaConnexion.Open();
            Console.WriteLine(scripts.MaConnexion.State);

        }
    }
}
