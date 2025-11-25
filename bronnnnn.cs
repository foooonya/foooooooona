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
    public partial class bronnnnn : Form
    {
        public bronnnnn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bronnnnn f = new bronnnnn();
            f.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

    {
        DataBase dataBase = new DataBase();

        private void button6_Click(object sender, EventArgs e)
        {

            var izdatelstvo = textBox1.Text;
            var avtor = textBox2.Text;
            var nazvanie = textBox3.Text;
          
            string queryString = $"insert into bro14 (izdatelstvo, avtor, nazvanie) values('{izdatelstvo}', '{avtor}', '{nazvanie}')";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Успешно!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                oplata opl = new oplata();
                this.Hide();
                opl.Show();
                opl.FormClosed += (s, args) => this.Show();
            }
            else
            {
                MessageBox.Show("Ошибка!", "Что то не так!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataBase.closeConnection();
        }
    
    
    }
}
