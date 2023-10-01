namespace Auto_Completion
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
            this.textBoxAuto = new System.Windows.Forms.TextBox();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonCompletionPerso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAuto
            // 
            this.textBoxAuto.AutoCompleteCustomSource.AddRange(new string[] {
            "http://www.",
            "http://102.45.38.",
            "ftp://102.45.38.",
            "file:///",
            "Monsieur",
            "Madame",
            "Mademoiselle"});
            this.textBoxAuto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxAuto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxAuto.Location = new System.Drawing.Point(26, 257);
            this.textBoxAuto.Name = "textBoxAuto";
            this.textBoxAuto.Size = new System.Drawing.Size(239, 20);
            this.textBoxAuto.TabIndex = 0;
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "None",
            "Suggest",
            "Append",
            "SuggestAppend"});
            this.comboBoxMode.Location = new System.Drawing.Point(518, 192);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(162, 21);
            this.comboBoxMode.TabIndex = 1;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Items.AddRange(new object[] {
            "FileSystem",
            "HistoryList",
            "RecentlyUsedList",
            "AllUrl",
            "AllSystemSource",
            "FileSystemDirectories",
            "CustomSource",
            "None"});
            this.comboBoxSource.Location = new System.Drawing.Point(518, 278);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(162, 21);
            this.comboBoxSource.TabIndex = 2;
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(518, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 107);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "http://www.\r\nhttp://102.45.38.\r\nftp://102.45.38.\r\nfile:///\r\nMonsieur\r\nMadame\r\nMad" +
                "emoiselle\r\n";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(35, 44);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 35);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Completion automatique de texte\r\n               dans le TextBox";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(35, 125);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 97);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Entrez dans le textBox ci-dessous\r\n   comme premier caractère \'m\' ou \'M\'\r\n   comm" +
                "e premier caractère \'f\' ou \'F\'\r\n   comme premier caractère \'h\' ou  \'H\'  ";
            // 
            // buttonCompletionPerso
            // 
            this.buttonCompletionPerso.Location = new System.Drawing.Point(518, 331);
            this.buttonCompletionPerso.Name = "buttonCompletionPerso";
            this.buttonCompletionPerso.Size = new System.Drawing.Size(162, 36);
            this.buttonCompletionPerso.TabIndex = 3;
            this.buttonCompletionPerso.Text = "Revenir à la complétion Personnalisée";
            this.buttonCompletionPerso.UseVisualStyleBackColor = true;
            this.buttonCompletionPerso.Click += new System.EventHandler(this.buttonCompletionPerso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 385);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonCompletionPerso);
            this.Controls.Add(this.comboBoxSource);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.textBoxAuto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAuto;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonCompletionPerso;
    }
}

