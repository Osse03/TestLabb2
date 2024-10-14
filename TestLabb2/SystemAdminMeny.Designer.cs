namespace TestLabb2
{
    partial class SystemAdminMeny
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            EfterLogIN = new Button();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_10_11_000153;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Guttman-CourMir", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 177);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(86, 141);
            label2.Name = "label2";
            label2.Size = new Size(234, 35);
            label2.TabIndex = 2;
            label2.Text = "Welcome Admin";
            // 
            // EfterLogIN
            // 
            EfterLogIN.BackColor = Color.SeaGreen;
            EfterLogIN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EfterLogIN.ForeColor = Color.White;
            EfterLogIN.Location = new Point(106, 236);
            EfterLogIN.Name = "EfterLogIN";
            EfterLogIN.Size = new Size(180, 58);
            EfterLogIN.TabIndex = 9;
            EfterLogIN.Text = "Lägg Till Fordon";
            EfterLogIN.UseVisualStyleBackColor = false;
            EfterLogIN.Click += EfterLogIN_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(106, 312);
            button1.Name = "button1";
            button1.Size = new Size(180, 57);
            button1.TabIndex = 10;
            button1.Text = "Uppdatera";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(106, 385);
            button2.Name = "button2";
            button2.Size = new Size(180, 56);
            button2.TabIndex = 11;
            button2.Text = "Ta bort";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(174, 521);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 12;
            label3.Text = "Exit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Hadassah Friedlaender", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 177);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(128, 42);
            label1.Name = "label1";
            label1.Size = new Size(229, 23);
            label1.TabIndex = 13;
            label1.Text = "Let's GET WORD DONE";
            // 
            // SystemAdminMeny
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 550);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(EfterLogIN);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SystemAdminMeny";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SystemAdminMeny";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Button EfterLogIN;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label1;
    }
}