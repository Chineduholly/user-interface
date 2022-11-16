namespace god_abeg
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.CheckBoxPass = new System.Windows.Forms.CheckBox();
            this.clear = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button3cancel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(-38, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 116);
            this.panel2.TabIndex = 0;
            // 
            // button3cancel
            // 
            this.button3cancel.Location = new System.Drawing.Point(352, 0);
            this.button3cancel.Name = "button3cancel";
            this.button3cancel.Size = new System.Drawing.Size(28, 23);
            this.button3cancel.TabIndex = 9;
            this.button3cancel.Text = "X";
            this.button3cancel.UseVisualStyleBackColor = true;
            this.button3cancel.Click += new System.EventHandler(this.button3cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "please login";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(22, 217);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(58, 13);
            this.Name.TabIndex = 2;
            this.Name.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(25, 233);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(25, 294);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CheckBoxPass
            // 
            this.CheckBoxPass.AutoSize = true;
            this.CheckBoxPass.Location = new System.Drawing.Point(195, 384);
            this.CheckBoxPass.Name = "CheckBoxPass";
            this.CheckBoxPass.Size = new System.Drawing.Size(98, 17);
            this.CheckBoxPass.TabIndex = 7;
            this.CheckBoxPass.Text = "Showpassword";
            this.CheckBoxPass.UseVisualStyleBackColor = true;
            this.CheckBoxPass.CheckedChanged += new System.EventHandler(this.CheckBoxPass_CheckedChanged_1);
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Location = new System.Drawing.Point(83, 388);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(30, 13);
            this.clear.TabIndex = 8;
            this.clear.Text = "clear";
            this.clear.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(343, 476);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.CheckBoxPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox CheckBoxPass;
        private System.Windows.Forms.Label clear;
        private System.Windows.Forms.Button button3cancel;
    }
}

