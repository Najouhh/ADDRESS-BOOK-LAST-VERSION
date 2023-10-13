using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADDRESS_BOOK_LAST_VERSION
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string correctEmail = "najah";
            const string correctPassword = "123";
            if (textBox1.Text == correctEmail && textBox2.Text == correctPassword)
            {
                MessageBox.Show("Du är inloggad");
                //Uppgift 3
                user user = new user();
                user.ShowDialog();
               
            }

        }
    }
}
