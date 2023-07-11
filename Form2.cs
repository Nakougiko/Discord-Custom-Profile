using DiscordRPC;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Discord_Custom_Profile
{
    public partial class Form2 : Form
    {
        private readonly Color buttonColor = Color.FromArgb(78, 80, 88);
        private readonly Color logoColor = Color.FromArgb(17, 18, 20);

        private string urlButton1 = "https://github.com/Nakougiko";
        private string urlButton2 = "https://youtube.com/@Nakougiko";

        private DiscordRpcClient client;
        private RichPresence presence;
        private DiscordRPC.Button[] buttonsPresence;

        private Form form1;

        public Form2(DiscordRpcClient client, Form form1)
        {
            InitializeComponent();
            this.client = client;
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InitializeColors();
            UpdatePresence();
        }

        private void InitializeColors()
        {
            textBoxButton1.BackColor = buttonColor;
            textBoxButton2.BackColor = buttonColor;
            buttonReload.BackColor = logoColor;
            textBoxDetails.BackColor = logoColor;
            textBoxState.BackColor = logoColor;
        }

        private void UpdatePresence()
        {
            UpdateButtonsPresence();
            presence = new RichPresence()
            {
                Details = textBoxDetails.Text,
                State = textBoxState.Text,
                Assets = new Assets()
                {
                    LargeImageKey = "large_image",
                    LargeImageText = "Texte hover",
                    SmallImageKey = "small_image",
                    SmallImageText = "Small Text hover"
                },
                Buttons = buttonsPresence
            };
            client.SetPresence(presence);
        }

        private void UpdateButtonsPresence()
        {
            if (checkBoxButton1.Checked)
            {
                buttonsPresence = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() { Label = textBoxButton1.Text, Url = urlButton1 }
                };

                if (checkBoxButton2.Checked)
                {
                    buttonsPresence = new DiscordRPC.Button[]
                    {
                        new DiscordRPC.Button() { Label = textBoxButton1.Text, Url = urlButton1 },
                        new DiscordRPC.Button() { Label = textBoxButton2.Text, Url = urlButton2 }
                    };
                }
            }
            else
            {
                buttonsPresence = new DiscordRPC.Button[] { };
            }
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            UpdatePresence();
        }

        private void checkBoxButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresence();
            checkBoxButton2.Enabled = checkBoxButton1.Checked;
            textBoxButton1.Enabled = checkBoxButton1.Checked;
            textBoxButton2.Enabled = checkBoxButton1.Checked && checkBoxButton2.Checked;
            checkBoxButton2.Checked = checkBoxButton1.Checked && checkBoxButton2.Checked;
        }

        private void checkBoxButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePresence();
            textBoxButton2.Enabled = checkBoxButton2.Checked;
        }

        private void textBoxDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UpdatePresence();
            }
        }

        private void modifierLURLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePresence();
            formUrlInput urlInput = new formUrlInput(client);
            urlInput.url1 = urlButton1;
            urlInput.url2 = urlButton2;
            urlInput.text1 = textBoxButton1.Text + " URL :";
            urlInput.text2 = textBoxButton2.Text + " URL :";
            urlInput.state1 = checkBoxButton1.Checked;
            urlInput.state2 = checkBoxButton2.Checked;

            if (urlInput.ShowDialog() == DialogResult.OK)
            {
                urlButton1 = urlInput.url1;
                urlButton2 = urlInput.url2;
                UpdatePresence();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.BeginInvoke(new Action(() =>
            {
                form1.Show();
            }));
        }
    }
}