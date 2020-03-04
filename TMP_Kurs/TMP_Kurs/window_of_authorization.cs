using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMP_Kurs
{
    
    public partial class window_of_authorization : Form
    {
        
        public int t;
        public window_of_authorization()
        {
            InitializeComponent();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            Us.Add(new User(TxtName.Text, TxtSurname.Text, TxtLogin.Text, TxtPass.Text));
        }
    }
}
