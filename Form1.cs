using DiscordRPC;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Custom_Profile
{
    public partial class Form1 : Form
    {
        private DiscordRpcClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnection_Click(object sender, EventArgs e)
        {
            if (buttonConnection.Text == "Connection") // Si aucune connexion alors en établir une
            {
                if (string.IsNullOrEmpty(textBoxClientId.Text)) // Si aucune ID spécifiée -> erreur
                {
                    MessageBox.Show("Erreur : Veuillez spécifier une ID d'application");
                    return;
                }

                string clientID = textBoxClientId.Text;
                client = new DiscordRpcClient(clientID);

                // Connexion réussie
                client.OnReady += (readySender, args) =>
                {
                    labelStateClientConnection.Invoke((MethodInvoker)(() => labelStateClientConnection.ForeColor = Color.Green));
                    buttonConnection.Invoke((MethodInvoker)(() => buttonConnection.Text = "Disconnect"));

                    // Créer un thread séparé pour masquer la fenêtre
                    Thread thread = new Thread(() => HideForm());
                    thread.Start();

                    // Ouvrir Form2 dans un autre thread
                    Task.Run(() =>
                    {
                        OpenForm2(client);
                    });
                };

                // Erreur de connexion
                client.OnError += (errorSender, args) =>
                {
                    labelStateClientConnection.Invoke((MethodInvoker)(() => labelStateClientConnection.ForeColor = Color.Red));
                    MessageBox.Show("Erreur de connexion : Veuillez utiliser une ID d'application correcte");
                };

                try
                {
                    client.Initialize(); // Connexion au RPC
                }
                catch (Exception ex)
                {
                    labelStateClientConnection.Invoke((MethodInvoker)(() => labelStateClientConnection.ForeColor = Color.Red));
                    MessageBox.Show("Erreur de connexion : Veuillez utiliser une ID d'application correcte.\nDétails de l'erreur : " + ex.Message);
                }
            }
            else
            {
                DisconnectClient();
            }
        }

        private void DisconnectClient()
        {
            if (client != null && !client.IsDisposed)
            {
                client.Dispose(); // Déconnexion du client
            }

            buttonConnection.Text = "Connection";
            labelStateClientConnection.ForeColor = Color.Red;
        }

        private void HideForm()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => this.Hide()));
            }
            else
            {
                this.Hide();
            }
        }

        private void OpenForm2(DiscordRpcClient client)
        {
            Form2 form2 = new Form2(client, this);
            //form2.FormClosed += Form2_FormClosed;
            form2.ShowDialog();
        }
    }
}