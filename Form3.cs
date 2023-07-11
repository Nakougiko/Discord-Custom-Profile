using DiscordRPC;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Discord_Custom_Profile
{
    public partial class formUrlInput : Form
    {
        public DiscordRpcClient client;
        public string text1;
        public string text2;
        public string url1;
        public string url2;
        public bool state1 = false;
        public bool state2 = false;

        Color fond = Color.FromArgb(30, 31, 34);

        public formUrlInput(DiscordRpcClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void FormUrlInput_Load(object sender, EventArgs e)
        {
            textBoxURL1.Text = url1;
            textBoxURL2.Text = url2;
            label1.Text = text1;
            label2.Text = text2;
            textBoxURL1.BackColor = fond;
            textBoxURL2.BackColor = fond;
            if (state1 ) textBoxURL1.Enabled = true;
            if (state2 ) textBoxURL2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            url1 = textBoxURL1.Text;
            url2 = textBoxURL2.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxURL1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                url1 = textBoxURL1.Text;
                url2 = textBoxURL2.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}