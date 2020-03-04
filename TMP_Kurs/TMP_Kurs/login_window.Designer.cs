namespace TMP_Kurs
{
    partial class login_window
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassWrite = new System.Windows.Forms.TextBox();
            this.TxtLogWrite = new System.Windows.Forms.TextBox();
            this.LabLog = new System.Windows.Forms.Label();
            this.LoginLable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TMP_Kurs.Properties.Resources.Login;
            this.pictureBox3.Location = new System.Drawing.Point(137, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 250);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль";
            // 
            // TxtPassWrite
            // 
            this.TxtPassWrite.Location = new System.Drawing.Point(83, 405);
            this.TxtPassWrite.Multiline = true;
            this.TxtPassWrite.Name = "TxtPassWrite";
            this.TxtPassWrite.Size = new System.Drawing.Size(340, 37);
            this.TxtPassWrite.TabIndex = 11;
            // 
            // TxtLogWrite
            // 
            this.TxtLogWrite.Location = new System.Drawing.Point(83, 329);
            this.TxtLogWrite.Multiline = true;
            this.TxtLogWrite.Name = "TxtLogWrite";
            this.TxtLogWrite.Size = new System.Drawing.Size(340, 37);
            this.TxtLogWrite.TabIndex = 10;
            // 
            // LabLog
            // 
            this.LabLog.AutoSize = true;
            this.LabLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabLog.Location = new System.Drawing.Point(79, 302);
            this.LabLog.Name = "LabLog";
            this.LabLog.Size = new System.Drawing.Size(69, 24);
            this.LabLog.TabIndex = 9;
            this.LabLog.Text = "Логин";
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLable.ForeColor = System.Drawing.Color.ForestGreen;
            this.LoginLable.Location = new System.Drawing.Point(165, 477);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(164, 55);
            this.LoginLable.TabIndex = 13;
            this.LoginLable.Text = "Войти";
            this.LoginLable.Click += new System.EventHandler(this.LoginLable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(133, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "У вас еще нет аккаунта?";
            // 
            // login_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(516, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassWrite);
            this.Controls.Add(this.TxtLogWrite);
            this.Controls.Add(this.LabLog);
            this.Controls.Add(this.pictureBox3);
            this.Name = "login_window";
            this.Text = "login_window";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassWrite;
        private System.Windows.Forms.TextBox TxtLogWrite;
        private System.Windows.Forms.Label LabLog;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label label3;
    }
}