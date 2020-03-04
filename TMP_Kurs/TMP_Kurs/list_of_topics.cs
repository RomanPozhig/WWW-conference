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
    public partial class list_of_topics : Form
    {
        public list_of_topics()
        {
            InitializeComponent();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            window_of_authorization wa = new window_of_authorization();
            wa.Show();

        }
    }
}
