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
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);
            OleDbDataReader dr = Global.ExecuterOleDBSelect(@"select * from clients order by id asc", cn);
            while (dr.Read())
            {
                dgvClients.Rows.Add(dr.GetValue(0), dr.GetValue(1).ToString(), dr.GetValue(2).ToString(), dr.GetDecimal(3));
            }
            Global.seDeconnecter(cn);
            dr.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNouveauClient_Click(object sender, EventArgs e)
        {
            OleDbConnection objCN = new OleDbConnection();
            objCN.ConnectionString = Global.cs;
            if (objCN.State == System.Data.ConnectionState.Closed)
                objCN.Open();
            string requetAdd = "insert into clients(nom,adresse,solde) values ('Test TDI','Nouveau Adress',45.000)";
            Global.ExecuterOleDBAction(@requetAdd, objCN);
            Global.seDeconnecter(objCN);
            remplirDatagrdView();
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            OleDbConnection cn = new OleDbConnection();
            cn = Global.seConnecter(Global.cs);

            // Iterate through selected rows
            foreach (DataGridViewRow row in dgvClients.SelectedRows)
            {
                // Accessing cell values
                string idCell = row.Cells[0].Value.ToString();
                string requetDelete = "delete from clients where id =" + idCell;
                Global.ExecuterOleDBAction(@requetDelete, cn);


            }
            Global.seDeconnecter(cn);
            remplirDatagrdView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            remplirDatagrdView();
        }
    }
}
