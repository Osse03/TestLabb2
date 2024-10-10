using InMemoryDatabase;
using Entiteter;

namespace TestLabb2
{
    partial class Form1
    {
       
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            textNamn = new TextBox();
            textLösenord = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Avatar_icon_green_svg;
            pictureBox2.Location = new Point(74, 228);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_10_11_000153;
            pictureBox1.Location = new Point(123, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Screenshot_2024_10_11_001239;
            pictureBox3.Location = new Point(74, 288);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(123, 156);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 5;
            label1.Text = "LOG IN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(74, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(74, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 1);
            panel2.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(123, 339);
            button1.Name = "button1";
            button1.Size = new Size(129, 45);
            button1.TabIndex = 8;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(140, 387);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 9;
            label2.Text = "Skapa Konto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(169, 475);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 10;
            label3.Text = "Exit";
            label3.Click += label3_Click;
            // 
            // textNamn
            // 
            textNamn.BorderStyle = BorderStyle.None;
            textNamn.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNamn.ForeColor = SystemColors.WindowText;
            textNamn.Location = new Point(105, 234);
            textNamn.Multiline = true;
            textNamn.Name = "textNamn";
            textNamn.Size = new Size(188, 25);
            textNamn.TabIndex = 11;
            // 
            // textLösenord
            // 
            textLösenord.BorderStyle = BorderStyle.None;
            textLösenord.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLösenord.ForeColor = SystemColors.WindowText;
            textLösenord.Location = new Point(105, 292);
            textLösenord.Multiline = true;
            textLösenord.Name = "textLösenord";
            textLösenord.Size = new Size(188, 25);
            textLösenord.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(149, 423);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 13;
            label4.Text = "Rensa Fält";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(382, 504);
            Controls.Add(label4);
            Controls.Add(textLösenord);
            Controls.Add(textNamn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox textNamn;
        private TextBox textLösenord;
        private Label label4;
    }
}
