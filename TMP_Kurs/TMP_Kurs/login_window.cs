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
    public partial class login_window : Form
    {
        public login_window()
        {
            InitializeComponent();
        }

        private void LoginLable_Click(object sender, EventArgs e)
        {
            int countUser = User.Us.Count;

        }
    }
}
