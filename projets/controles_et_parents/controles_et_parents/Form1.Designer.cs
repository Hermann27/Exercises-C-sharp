namespace controles_et_parents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonParent = new System.Windows.Forms.Button();
            this.txtctrls = new System.Windows.Forms.TextBox();
            this.buttonControlsForm = new System.Windows.Forms.Button();
            this.buttonControlsPanel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(24, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 222);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modification du parent d\'un controle";
            // 
            // buttonParent
            // 
            this.buttonParent.Location = new System.Drawing.Point(90, 399);
            this.buttonParent.Name = "buttonParent";
            this.buttonParent.Size = new System.Drawing.Size(120, 23);
            this.buttonParent.TabIndex = 2;
            this.buttonParent.Text = "Changer le parent";
            this.buttonParent.UseVisualStyleBackColor = true;
            this.buttonParent.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtctrls
            // 
            this.txtctrls.Location = new System.Drawing.Point(316, 138);
            this.txtctrls.Multiline = true;
            this.txtctrls.Name = "txtctrls";
            this.txtctrls.Size = new System.Drawing.Size(434, 248);
            this.txtctrls.TabIndex = 3;
            // 
            // buttonControlsForm
            // 
            this.buttonControlsForm.Location = new System.Drawing.Point(391, 401);
            this.buttonControlsForm.Name = "buttonControlsForm";
            this.buttonControlsForm.Size = new System.Drawing.Size(145, 23);
            this.buttonControlsForm.TabIndex = 4;
            this.buttonControlsForm.Text = "Les controles de la fiche";
            this.buttonControlsForm.UseVisualStyleBackColor = true;
            this.buttonControlsForm.Click += new System.EventHandler(this.btnctrlsFm_Click);
            // 
            // buttonControlsPanel
            // 
            this.buttonControlsPanel.Location = new System.Drawing.Point(542, 401);
            this.buttonControlsPanel.Name = "buttonControlsPanel";
            this.buttonControlsPanel.Size = new System.Drawing.Size(150, 23);
            this.buttonControlsPanel.TabIndex = 5;
            this.buttonControlsPanel.Text = "Les controles du panel";
            this.buttonControlsPanel.UseVisualStyleBackColor = true;
            this.buttonControlsPanel.Click += new System.EventHandler(this.btnctrlsPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 486);
            this.Controls.Add(this.buttonControlsForm);
            this.Controls.Add(this.buttonControlsPanel);
            this.Controls.Add(this.txtctrls);
            this.Controls.Add(this.buttonParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonParent;
        private System.Windows.Forms.TextBox txtctrls;
        private System.Windows.Forms.Button buttonControlsForm;
        private System.Windows.Forms.Button buttonControlsPanel;
    }
}

