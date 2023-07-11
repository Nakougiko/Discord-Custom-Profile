namespace Discord_Custom_Profile
{
    partial class formUrlInput
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL1 = new System.Windows.Forms.TextBox();
            this.textBoxURL2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(338, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Github URL :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Youtube URL :";
            // 
            // textBoxURL1
            // 
            this.textBoxURL1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxURL1.Enabled = false;
            this.textBoxURL1.ForeColor = System.Drawing.Color.White;
            this.textBoxURL1.Location = new System.Drawing.Point(23, 44);
            this.textBoxURL1.Name = "textBoxURL1";
            this.textBoxURL1.Size = new System.Drawing.Size(390, 15);
            this.textBoxURL1.TabIndex = 3;
            this.textBoxURL1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxURL1_KeyPress);
            // 
            // textBoxURL2
            // 
            this.textBoxURL2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxURL2.Enabled = false;
            this.textBoxURL2.ForeColor = System.Drawing.Color.White;
            this.textBoxURL2.Location = new System.Drawing.Point(23, 134);
            this.textBoxURL2.Name = "textBoxURL2";
            this.textBoxURL2.Size = new System.Drawing.Size(390, 15);
            this.textBoxURL2.TabIndex = 4;
            this.textBoxURL2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxURL1_KeyPress);
            // 
            // formUrlInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Discord_Custom_Profile.Properties.Resources.guiurl;
            this.ClientSize = new System.Drawing.Size(439, 247);
            this.Controls.Add(this.textBoxURL2);
            this.Controls.Add(this.textBoxURL1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("ABC Ginto Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formUrlInput";
            this.Text = "URL Input";
            this.Load += new System.EventHandler(this.FormUrlInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxURL1;
        private System.Windows.Forms.TextBox textBoxURL2;
    }
}