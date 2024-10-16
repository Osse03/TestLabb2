namespace TestLabb2
{
    partial class UthyrningForm
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
            txtAnvändarnamn = new TextBox();
            txtFordonID = new TextBox();
            btnHyra = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAnvändarnamn
            // 
            txtAnvändarnamn.Location = new Point(221, 39);
            txtAnvändarnamn.Margin = new Padding(3, 2, 3, 2);
            txtAnvändarnamn.Name = "txtAnvändarnamn";
            txtAnvändarnamn.Size = new Size(142, 23);
            txtAnvändarnamn.TabIndex = 0;
            // 
            // txtFordonID
            // 
            txtFordonID.Location = new Point(221, 117);
            txtFordonID.Margin = new Padding(3, 2, 3, 2);
            txtFordonID.Name = "txtFordonID";
            txtFordonID.Size = new Size(142, 23);
            txtFordonID.TabIndex = 1;
            txtFordonID.TextChanged += textBox2_TextChanged;
            // 
            // btnHyra
            // 
            btnHyra.Location = new Point(221, 183);
            btnHyra.Margin = new Padding(3, 2, 3, 2);
            btnHyra.Name = "btnHyra";
            btnHyra.Size = new Size(147, 22);
            btnHyra.TabIndex = 2;
            btnHyra.Text = "Hyra Fordon";
            btnHyra.UseVisualStyleBackColor = true;
            btnHyra.Click += btnHyra_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_10_11_000153;
            pictureBox1.Location = new Point(489, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(222, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UthyrningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 345);
            Controls.Add(pictureBox1);
            Controls.Add(btnHyra);
            Controls.Add(txtFordonID);
            Controls.Add(txtAnvändarnamn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UthyrningForm";
            Text = "UthyrningForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnvändarnamn;
        private TextBox txtFordonID;
        private Button btnHyra;
        private PictureBox pictureBox1;
    }
}