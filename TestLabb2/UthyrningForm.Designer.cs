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
            txtAnvändarnamn.Location = new Point(253, 52);
            txtAnvändarnamn.Name = "txtAnvändarnamn";
            txtAnvändarnamn.Size = new Size(162, 27);
            txtAnvändarnamn.TabIndex = 0;
            // 
            // txtFordonID
            // 
            txtFordonID.Location = new Point(253, 156);
            txtFordonID.Name = "txtFordonID";
            txtFordonID.Size = new Size(162, 27);
            txtFordonID.TabIndex = 1;
            txtFordonID.TextChanged += textBox2_TextChanged;
            // 
            // btnHyra
            // 
            btnHyra.Location = new Point(253, 244);
            btnHyra.Name = "btnHyra";
            btnHyra.Size = new Size(168, 29);
            btnHyra.TabIndex = 2;
            btnHyra.Text = "Hyra Fordon";
            btnHyra.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_10_11_000153;
            pictureBox1.Location = new Point(559, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // UthyrningForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 460);
            Controls.Add(pictureBox1);
            Controls.Add(btnHyra);
            Controls.Add(txtFordonID);
            Controls.Add(txtAnvändarnamn);
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