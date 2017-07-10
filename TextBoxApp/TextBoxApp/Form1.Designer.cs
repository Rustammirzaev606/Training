namespace TextBoxApp
{
    partial class Dude_form_1
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
            this.btnAction = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.act1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.newTxtBox = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(225, 126);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Action";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(33, 12);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(321, 20);
            this.txtBox1.TabIndex = 1;
            this.txtBox1.Text = "Dude..";
            this.txtBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // act1
            // 
            this.act1.AutoSize = true;
            this.act1.Location = new System.Drawing.Point(241, 169);
            this.act1.Name = "act1";
            this.act1.Size = new System.Drawing.Size(33, 13);
            this.act1.TabIndex = 2;
            this.act1.Text = "Label";
            // 
            // btnRun
            // 
            this.btnRun.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnRun.Location = new System.Drawing.Point(104, 55);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "asd";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Action";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Label";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(244, 226);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 23);
            this.newBtn.TabIndex = 7;
            this.newBtn.Text = "Do";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // newTxtBox
            // 
            this.newTxtBox.Location = new System.Drawing.Point(138, 226);
            this.newTxtBox.Name = "newTxtBox";
            this.newTxtBox.Size = new System.Drawing.Size(100, 20);
            this.newTxtBox.TabIndex = 8;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(325, 231);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(57, 13);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Label Four";
            // 
            // Dude_form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 261);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.newTxtBox);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.act1);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.btnAction);
            this.Name = "Dude_form_1";
            this.Text = "Dude form 420";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Label act1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.TextBox newTxtBox;
        private System.Windows.Forms.Label lbl4;
    }
}

