using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace One_Tier
{
    internal class Global
    {

        static public string xmlFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MaBase.xml");
        // Méthode pour charger le document XML
        static public XDocument ChargerXML()
        {
            return XDocument.Load(xmlFilePath);
        }

        // Méthode pour récupérer tous les clients
        static public List<Client> RecupererClients()
        {
            XDocument xdoc = ChargerXML();
            var clients = from client in xdoc.Descendants("Client")
                          select new Client
                          {
                              Id = (int)client.Element("Id"),
                              Nom = (string)client.Element("Nom"),
                              Adresse = (string)client.Element("Adresse"),
                              Solde = (decimal)client.Element("Solde")
                          };
            return clients.ToList();
        }

        // Classe représentant un Client
        public class Client
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Adresse { get; set; }
            public decimal Solde { get; set; }
        }

    }
}
