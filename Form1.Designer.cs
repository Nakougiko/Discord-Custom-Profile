namespace Discord_Custom_Profile
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxClientId = new System.Windows.Forms.TextBox();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStateClientConnection = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxClientId
            // 
            this.textBoxClientId.Location = new System.Drawing.Point(278, 87);
            this.textBoxClientId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxClientId.Name = "textBoxClientId";
            this.textBoxClientId.Size = new System.Drawing.Size(163, 22);
            this.textBoxClientId.TabIndex = 0;
            this.textBoxClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(449, 85);
            this.buttonConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(88, 25);
            this.buttonConnection.TabIndex = 1;
            this.buttonConnection.Text = "Connection";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Application ID : ";
            // 
            // labelStateClientConnection
            // 
            this.labelStateClientConnection.AutoSize = true;
            this.labelStateClientConnection.ForeColor = System.Drawing.Color.Red;
            this.labelStateClientConnection.Location = new System.Drawing.Point(305, 112);
            this.labelStateClientConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStateClientConnection.Name = "labelStateClientConnection";
            this.labelStateClientConnection.Size = new System.Drawing.Size(107, 14);
            this.labelStateClientConnection.TabIndex = 3;
            this.labelStateClientConnection.Text = "Discord Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1007, 445);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(793, 461);
            this.Controls.Add(this.labelStateClientConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnection);
            this.Controls.Add(this.textBoxClientId);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("ABC Ginto Normal", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Discord - Application Connection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClientId;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStateClientConnection;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

