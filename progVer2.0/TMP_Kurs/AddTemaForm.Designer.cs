namespace TMP_Kurs
{
    partial class AddTemaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtAddTem = new System.Windows.Forms.TextBox();
            this.TxtAddM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAT = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtAddTem
            // 
            this.TxtAddTem.Location = new System.Drawing.Point(12, 126);
            this.TxtAddTem.Multiline = true;
            this.TxtAddTem.Name = "TxtAddTem";
            this.TxtAddTem.Size = new System.Drawing.Size(667, 49);
            this.TxtAddTem.TabIndex = 0;
            // 
            // TxtAddM
            // 
            this.TxtAddM.Location = new System.Drawing.Point(15, 223);
            this.TxtAddM.Multiline = true;
            this.TxtAddM.Name = "TxtAddM";
            this.TxtAddM.Size = new System.Drawing.Size(667, 160);
            this.TxtAddM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите тему";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите сообщение";
            // 
            // BtnAT
            // 
            this.BtnAT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAT.Location = new System.Drawing.Point(522, 74);
            this.BtnAT.Name = "BtnAT";
            this.BtnAT.Size = new System.Drawing.Size(157, 46);
            this.BtnAT.TabIndex = 4;
            this.BtnAT.Text = "Добавить";
            this.BtnAT.UseVisualStyleBackColor = true;
            this.BtnAT.Click += new System.EventHandler(this.BtnAT_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(643, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(40, 42);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddTemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 395);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BtnAT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAddM);
            this.Controls.Add(this.TxtAddTem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTemaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTemaForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddTemaForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddTemaForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAddTem;
        private System.Windows.Forms.TextBox TxtAddM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAT;
        private System.Windows.Forms.Label CloseButton;
    }
}