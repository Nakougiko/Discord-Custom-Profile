namespace Discord_Custom_Profile
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.checkBoxButton1 = new System.Windows.Forms.CheckBox();
            this.checkBoxButton2 = new System.Windows.Forms.CheckBox();
            this.textBoxButton1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierLURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxButton2 = new System.Windows.Forms.TextBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxButton1
            // 
            this.checkBoxButton1.AutoSize = true;
            this.checkBoxButton1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxButton1.Checked = true;
            this.checkBoxButton1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxButton1.Location = new System.Drawing.Point(37, 357);
            this.checkBoxButton1.Name = "checkBoxButton1";
            this.checkBoxButton1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxButton1.TabIndex = 0;
            this.checkBoxButton1.UseVisualStyleBackColor = false;
            this.checkBoxButton1.CheckedChanged += new System.EventHandler(this.checkBoxButton1_CheckedChanged);
            // 
            // checkBoxButton2
            // 
            this.checkBoxButton2.AutoSize = true;
            this.checkBoxButton2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxButton2.Checked = true;
            this.checkBoxButton2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxButton2.Location = new System.Drawing.Point(37, 398);
            this.checkBoxButton2.Name = "checkBoxButton2";
            this.checkBoxButton2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxButton2.TabIndex = 1;
            this.checkBoxButton2.UseVisualStyleBackColor = false;
            this.checkBoxButton2.CheckedChanged += new System.EventHandler(this.checkBoxButton2_CheckedChanged);
            // 
            // textBoxButton1
            // 
            this.textBoxButton1.BackColor = System.Drawing.Color.Silver;
            this.textBoxButton1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxButton1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxButton1.ForeColor = System.Drawing.Color.White;
            this.textBoxButton1.Location = new System.Drawing.Point(37, 356);
            this.textBoxButton1.Name = "textBoxButton1";
            this.textBoxButton1.Size = new System.Drawing.Size(262, 15);
            this.textBoxButton1.TabIndex = 2;
            this.textBoxButton1.Text = "Github";
            this.textBoxButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxButton1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDetails_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierLURLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // modifierLURLToolStripMenuItem
            // 
            this.modifierLURLToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.modifierLURLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modifierLURLToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.modifierLURLToolStripMenuItem.Name = "modifierLURLToolStripMenuItem";
            this.modifierLURLToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.modifierLURLToolStripMenuItem.Text = "Modifier l\'URL";
            this.modifierLURLToolStripMenuItem.Click += new System.EventHandler(this.modifierLURLToolStripMenuItem_Click);
            // 
            // textBoxButton2
            // 
            this.textBoxButton2.BackColor = System.Drawing.Color.Silver;
            this.textBoxButton2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxButton2.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxButton2.ForeColor = System.Drawing.Color.White;
            this.textBoxButton2.Location = new System.Drawing.Point(37, 397);
            this.textBoxButton2.Name = "textBoxButton2";
            this.textBoxButton2.Size = new System.Drawing.Size(262, 15);
            this.textBoxButton2.TabIndex = 3;
            this.textBoxButton2.Text = "Youtube";
            this.textBoxButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxButton2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDetails_KeyPress);
            // 
            // buttonReload
            // 
            this.buttonReload.BackColor = System.Drawing.Color.Transparent;
            this.buttonReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReload.FlatAppearance.BorderSize = 0;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Image = global::Discord_Custom_Profile.Properties.Resources.lilrefresh;
            this.buttonReload.Location = new System.Drawing.Point(295, 74);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(30, 31);
            this.buttonReload.TabIndex = 4;
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("ABC Ginto Normal Variable", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Application Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDetails.ForeColor = System.Drawing.Color.White;
            this.textBoxDetails.Location = new System.Drawing.Point(104, 300);
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.Size = new System.Drawing.Size(171, 15);
            this.textBoxDetails.TabIndex = 6;
            this.textBoxDetails.Text = "Thanks to use";
            this.textBoxDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDetails_KeyPress);
            // 
            // textBoxState
            // 
            this.textBoxState.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxState.ForeColor = System.Drawing.Color.White;
            this.textBoxState.Location = new System.Drawing.Point(104, 316);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(171, 15);
            this.textBoxState.TabIndex = 7;
            this.textBoxState.Text = "my custom profile program <3";
            this.textBoxState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDetails_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(347, 430);
            this.Controls.Add(this.textBoxState);
            this.Controls.Add(this.textBoxDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.checkBoxButton2);
            this.Controls.Add(this.checkBoxButton1);
            this.Controls.Add(this.textBoxButton1);
            this.Controls.Add(this.textBoxButton2);
            this.Font = new System.Drawing.Font("ABC Ginto Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Discord - Custom Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxButton1;
        private System.Windows.Forms.CheckBox checkBoxButton2;
        private System.Windows.Forms.TextBox textBoxButton1;
        private System.Windows.Forms.TextBox textBoxButton2;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifierLURLToolStripMenuItem;
    }
}