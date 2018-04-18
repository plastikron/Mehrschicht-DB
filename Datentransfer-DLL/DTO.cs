using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace DatentransferDLL
{
    public class DTO : IDTO
    {
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;

        public List<Kunde> GetAllCustomers()
        {
            List<Kunde> liKunde = new List<Kunde>();
            OleDbConnection con = new OleDbConnection();
            OleDbConnectionStringBuilder stbuilder = new OleDbConnectionStringBuilder();
            stbuilder.DataSource = "H:\\Eigene Dateien\\FI11\\C#\\Mehrschicht\\Datentransfer-DLL\\bin\\Debug\\Nwind.accdb";
            stbuilder.Provider = "Microsoft.ACE.OLEDB.12.0";
            con.ConnectionString = stbuilder.ConnectionString;
            try
            {
                con.Open();
            }
            catch(Exception ex)
            {

            }
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Customers";
            try
            {
                reader = cmd.ExecuteReader();


            
            while(reader.Read())
            {
                Kunde k = MKKundenObjekt(reader);
                liKunde.Add(k);
            }
            }
            catch (Exception)
            {

            }
            return liKunde;
        }
        private Kunde MKKundenObjekt(OleDbDataReader reader)
        {
            Kunde k = new Kunde();
            try
            {
                k.KundenId = Convert.ToString(reader[0]);
                k.KundenName = Convert.ToString(reader[1]);
                k.Ansprechpartner = Convert.ToString(reader[2]);
                k.Strasse = Convert.ToString(reader[3]);
                k.Ort = Convert.ToString(reader[4]);
            }
            catch(Exception exc)
            {

            }
            return k;
        }
    }
}
