namespace LiaisonDeDonnee
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.ButtonTableauString = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ButtonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.GreenYellow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 212);
            this.listBox1.TabIndex = 0;
            // 
            // textBoxSource
            // 
            this.textBoxSource.AutoCompleteCustomSource.AddRange(new string[] {
            "Monsieur",
            "Madame ",
            "Mademoiselle",
            "if",
            "then",
            "else",
            "while",
            "do",
            "loop"});
            this.textBoxSource.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSource.BackColor = System.Drawing.Color.GreenYellow;
            this.textBoxSource.Location = new System.Drawing.Point(418, 12);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(100, 20);
            this.textBoxSource.TabIndex = 1;
            // 
            // ButtonTableauString
            // 
            this.ButtonTableauString.Location = new System.Drawing.Point(12, 273);
            this.ButtonTableauString.Name = "ButtonTableauString";
            this.ButtonTableauString.Size = new System.Drawing.Size(210, 25);
            this.ButtonTableauString.TabIndex = 2;
            this.ButtonTableauString.Values.Text = "Lier le DataSource au string[5]";
            this.ButtonTableauString.Click += new System.EventHandler(this.ButtonTableauString_Click);
            // 
            // ButtonTextBox
            // 
            this.ButtonTextBox.Location = new System.Drawing.Point(391, 273);
            this.ButtonTextBox.Name = "ButtonTextBox";
            this.ButtonTextBox.Size = new System.Drawing.Size(193, 25);
            this.ButtonTextBox.TabIndex = 3;
            this.ButtonTextBox.Values.Text = "Lier le DataSource au TextBox";
            this.ButtonTextBox.Click += new System.EventHandler(this.ButtonTextBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LiaisonDeDonnee.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(595, 323);
            this.Controls.Add(this.ButtonTextBox);
            this.Controls.Add(this.ButtonTableauString);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxSource;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonTableauString;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonTextBox;
    }
}

