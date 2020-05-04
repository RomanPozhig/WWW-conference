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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LT1.Text = Topics.Tema1;
            TxtM1.Text = Topics.Mess1;
            LTime1.Text = Topics.Data1;
            LLogin1.Text = Topics.Login1;

            LT2.Text = Topics.Tema2;
            TxtM2.Text = Topics.Mess2;
            LTime2.Text = Topics.Data2;
            LLogin2.Text = Topics.Login2;

            LT3.Text = Topics.Tema3;
            TxtM3.Text = Topics.Mess3;
            LTime3.Text = Topics.Data3;
            LLogin3.Text = Topics.Login3;

            LT4.Text = Topics.Tema4;
            TxtM4.Text = Topics.Mess4;
            LTime4.Text = Topics.Data4;
            LLogin4.Text = Topics.Login4;

            LT5.Text = Topics.Tema5;
            TxtM5.Text = Topics.Mess5;
            LTime5.Text = Topics.Data5;
            LLogin5.Text = Topics.Login5;



        }
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BtnAddTema1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics.id1 = 1;
            Topics.id2 = 0;
            Topics.id3 = 0;
            Topics.id4 = 0;
            Topics.id5 = 0;
            AddTemaForm addTemaForm = new AddTemaForm();
            addTemaForm.Show();
            
        }

        private void BtnAddTema2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics.id1 = 0;
            Topics.id2 = 1;
            Topics.id3 = 0;
            Topics.id4 = 0;
            Topics.id5 = 0;
            AddTemaForm addTemaForm = new AddTemaForm();
            addTemaForm.Show();
        }

        private void LLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void BtnAddTema3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics.id1 = 0;
            Topics.id2 = 0;
            Topics.id3 = 1;
            Topics.id4 = 0;
            Topics.id5 = 0;
            AddTemaForm addTemaForm = new AddTemaForm();
            addTemaForm.Show();
        }

        private void BtnAddTema4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics.id1 = 0;
            Topics.id2 = 0;
            Topics.id3 = 0;
            Topics.id4 = 1;
            Topics.id5 = 0;
            AddTemaForm addTemaForm = new AddTemaForm();
            addTemaForm.Show();
        }

        private void BtnAddTema5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Topics.id1 = 0;
            Topics.id2 = 0;
            Topics.id3 = 0;
            Topics.id4 = 0;
            Topics.id5 = 1;
            AddTemaForm addTemaForm = new AddTemaForm();
            addTemaForm.Show();
        }
        Point lastPoint;
        private void LHead_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LHead_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BtnDisT1_Click(object sender, EventArgs e)
        {

            if (LT1.Text != "Тема" && LT1.Text != "")
            {
                this.Hide();
                Topics.fl = true;
                SubTopic.idS1 = 1;
                SubTopic.idS2 = 0;
                SubTopic.idS3 = 0;
                SubTopic.idS4 = 0;
                SubTopic.idS5 = 0;
                SubtopicForm subtopicForm = new SubtopicForm();
                subtopicForm.Show();
               
            }
            else MessageBox.Show("Тема не создана!");


        }

        private void BtnDisT2_Click(object sender, EventArgs e)
        {
            if (LT2.Text != "Тема" && LT2.Text != "")
            {
                this.Hide();
                Topics.fl = true;
                SubTopic.idS1 = 0;
                SubTopic.idS2 = 1;
                SubTopic.idS3 = 0;
                SubTopic.idS4 = 0;
                SubTopic.idS5 = 0;
                SubtopicForm subtopicForm = new SubtopicForm();
                subtopicForm.Show();

            }
            else MessageBox.Show("Тема не создана!");
        }

        private void BtnDisT3_Click(object sender, EventArgs e)
        {
            if (LT3.Text != "Тема" && LT3.Text != "")
            {
                this.Hide();
                Topics.fl = true;
                SubTopic.idS1 = 0;
                SubTopic.idS2 = 0;
                SubTopic.idS3 = 1;
                SubTopic.idS4 = 0;
                SubTopic.idS5 = 0;
                SubtopicForm subtopicForm = new SubtopicForm();
                subtopicForm.Show();

            }
            else MessageBox.Show("Тема не создана!");
        }

        private void BtnDisT4_Click(object sender, EventArgs e)
        {
            if (LT4.Text != "Тема" && LT4.Text != "")
            {
                this.Hide();
                Topics.fl = true;
                SubTopic.idS1 = 0;
                SubTopic.idS2 = 0;
                SubTopic.idS3 = 0;
                SubTopic.idS4 = 1;
                SubTopic.idS5 = 0;
                SubtopicForm subtopicForm = new SubtopicForm();
                subtopicForm.Show();

            }
            else MessageBox.Show("Тема не создана!");
        }

        private void BtnAddTema4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Topics.id1 = 0;
            Topics.id2 = 0;
            Topics.id3 = 0;
            Topics.id4 = 1;
            Topics.id5 = 0;
            AddTemaForm addTemaForm = new AddTemaForm();
            addTemaForm.Show();
        }

        private void BtnAddTema5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Topics.id1 = 0;
            Topics.id2 = 0;
            Topics.id3 = 0;
            Topics.id4 = 0;
            Topics.id5 = 1;
            AddTemaForm addTemaForm = new AddTemaForm();
            addTemaForm.Show();
        }

        private void BtnDisT5_Click(object sender, EventArgs e)
        {
            if (LT5.Text != "Тема" && LT5.Text != "")
            {
                this.Hide();
                Topics.fl = true;
                SubTopic.idS1 = 0;
                SubTopic.idS2 = 0;
                SubTopic.idS3 = 0;
                SubTopic.idS4 = 0;
                SubTopic.idS5 = 1;
                SubtopicForm subtopicForm = new SubtopicForm();
                subtopicForm.Show();

            }
            else MessageBox.Show("Тема не создана!");
        }
    }
}
