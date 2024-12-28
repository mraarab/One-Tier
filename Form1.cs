using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace One_Tier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void remplirDatagrdView()
        {
            dgvClients.Rows.Clear();
            var clients = RecupererClients();

            foreach (var client in clients)
            {
                dgvClients.Rows.Add(client.Id, client.Nom, client.Adresse, client.Solde);
            }
        }
        private List<Global.Client> RecupererClients()
        {
            XDocument xdoc = XDocument.Load(Global.xmlFilePath); // Charger le fichier XML
            var clients = from client in xdoc.Descendants("Client")
                          select new Global.Client
                          {
                              Id = (int)client.Element("Id"),
                              Nom = (string)client.Element("Nom"),
                              Adresse = (string)client.Element("Adresse"),
                              Solde = (decimal)client.Element("Solde")
                          };
            return clients.ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            var xdoc = XDocument.Load(Global.xmlFilePath);
            var clients = xdoc.Element("Clients");

            // Ajouter un nouveau client
            int newId = clients.Elements("Client").Count() + 1;
            clients.Add(new XElement("Client",
                new XElement("Id", newId),
                new XElement("Nom", "Nouveau Client"),
                new XElement("Adresse", "Nouvelle Adresse"),
                new XElement("Solde", 45.000)
            ));

            // Sauvegarder les modifications dans le fichier XML
            xdoc.Save(Global.xmlFilePath);
            remplirDatagrdView();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            var xdoc = XDocument.Load(Global.xmlFilePath);
            var clients = xdoc.Element("Clients");

            // Itérer à travers les lignes sélectionnées
            foreach (DataGridViewRow row in dgvClients.SelectedRows)
            {
                int idCell = (int)row.Cells[0].Value;
                var clientToRemove = clients.Elements("Client").FirstOrDefault(c => (int)c.Element("Id") == idCell);
                clientToRemove?.Remove();
            }

            // Sauvegarder les modifications dans le fichier XML
            xdoc.Save(Global.xmlFilePath);
            remplirDatagrdView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remplirDatagrdView();
        }
    }
}
