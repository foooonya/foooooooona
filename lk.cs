using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace armnorm
{
    public partial class lk : Form
    {
        public lk()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bronnnnn bro = new bronnnnn();
            this.Hide();
            bro.Show();
            bro.FormClosed += (s, args) => this.Show();

         }
        
    }
}
