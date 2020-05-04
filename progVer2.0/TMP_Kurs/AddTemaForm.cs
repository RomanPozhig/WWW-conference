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
    public partial class AddTemaForm : Form
    {
        public AddTemaForm()
        {
            InitializeComponent();
            //if (Topics.fl)
            //{
            //    //Topics.fl = false;
            //    TxtAddTem.ReadOnly = true;
                
            //    if (Topics.id1 == 1)
            //    {
            //        TxtAddTem.Text = Topics.Tema1;
            //    }
            //    if (Topics.id2 == 1)
            //    {
            //        TxtAddM.Text = Topics.Tema2;
            //    }
            //    if (Topics.id3 == 1)
            //    {
            //        TxtAddM.Text = Topics.Tema3;
            //    }
            //    if (Topics.id4 == 1)
            //    {
            //        TxtAddM.Text = Topics.Tema4;
            //    }
            //    if (Topics.id5 == 1)
            //    {
            //        TxtAddM.Text = Topics.Tema5;
            //    }

            //}
        }

        private void BtnAT_Click(object sender, EventArgs e)
        {
            if (Topics.id1 == 1)
            {
                Topics.Tema1 = TxtAddTem.Text;
                Topics.Mess1 = TxtAddM.Text;
                Topics.Data1 = Convert.ToString(DateTime.Now);
                Topics.Login1 = Topics.Login;
                this.Hide();
                MainForm mainF = new MainForm();
                mainF.Show();
            }
            if (Topics.id2 == 1)
            {
                Topics.Tema2 = TxtAddTem.Text;
                Topics.Mess2 = TxtAddM.Text;
                Topics.Data2 = Convert.ToString(DateTime.Now);
                Topics.Login2 = Topics.Login;
                this.Hide();
                MainForm mainF = new MainForm();
                mainF.Show();
            }
            if (Topics.id3 == 1)
            {
                Topics.Tema3 = TxtAddTem.Text;
                Topics.Mess3 = TxtAddM.Text;
                Topics.Data3 = Convert.ToString(DateTime.Now);
                Topics.Login3 = Topics.Login;
                this.Hide();
                MainForm mainF = new MainForm();
                mainF.Show();
            }
            if (Topics.id4 == 1)
            {
                Topics.Tema4 = TxtAddTem.Text;
                Topics.Mess4 = TxtAddM.Text;
                Topics.Data4 = Convert.ToString(DateTime.Now);
                Topics.Login4 = Topics.Login;
                this.Hide();
                MainForm mainF = new MainForm();
                mainF.Show();
            }
            if (Topics.id5 == 1)
            {
                Topics.Tema5 = TxtAddTem.Text;
                Topics.Mess5 = TxtAddM.Text;
                Topics.Data5 = Convert.ToString(DateTime.Now);
                Topics.Login5 = Topics.Login;
                this.Hide();
                MainForm mainF = new MainForm();
                mainF.Show();
            }
            

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
           // if (Topics.fl == false)
           // {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            //}
            //else {
            //    this.Hide();
            //    SubtopicForm subtopicForm = new SubtopicForm();
            //    subtopicForm.Show();
            //}
        }
        Point lastPoint;
        private void AddTemaForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddTemaForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
