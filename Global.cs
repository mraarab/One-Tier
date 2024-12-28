using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Tier
{
    internal class Global
    {

        static public String cs = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|MaBase.accdb";

        static public OleDbConnection seConnecter(String strCN)
        {
            //on va créer un objet de connexion objCN
            OleDbConnection objCN = new OleDbConnection();
            try
            {
                // Définir la chaîne de connexion
                objCN.ConnectionString = strCN;
                // si la connexion est fermée, on l'ouvre avec la méthode open
                if (objCN.State == System.Data.ConnectionState.Closed)
                    objCN.Open();

            }
            catch (Exception)
            {

                throw;
            }
            return objCN;
        }

        static public void seDeconnecter(OleDbConnection objCN)
        {
            try
            {
                if (objCN.State == System.Data.ConnectionState.Open)
                    objCN.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        static public Object ExecuterOleDBScalaire(String strSQL, OleDbConnection objCN)
        {
            Object obj = new object();
            OleDbCommand objCom = new OleDbCommand(strSQL, objCN);
            try
            {
                obj = objCom.ExecuteScalar();
            }
            catch (Exception)
            {

                throw;
            }
            return obj;
        }

        static public OleDbDataReader ExecuterOleDBSelect(string strSQL, OleDbConnection objCN)
        {
            OleDbDataReader objDR = null;
            OleDbCommand objCom = new OleDbCommand(strSQL, objCN);
            try
            {
                objDR = objCom.ExecuteReader();
            }
            catch (Exception)
            {
                throw;
            }
            return objDR;
        }

        static public int ExecuterOleDBAction(string strSQL, OleDbConnection objCN, params Object[] objPM)
        {
            int nb = -1;
            OleDbCommand objCOM = new OleDbCommand(strSQL, objCN);
            try
            {
                foreach (Object obj in objPM)
                {
                    OleDbParameter objParameter = new OleDbParameter();
                    objParameter.Value = obj;
                    objCOM.Parameters.Add(objParameter);
                }
                nb = objCOM.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            return nb;
        }

    }
}
