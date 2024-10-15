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
            // UthyrningForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHyra);
            Controls.Add(txtFordonID);
            Controls.Add(txtAnvändarnamn);
            Name = "UthyrningForm";
            Text = "UthyrningForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAnvändarnamn;
        private TextBox txtFordonID;
        private Button btnHyra;
    }
}