using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;

namespace CaddAmmerpet.API_Configuration.LocalDB
{
    public class LocalDBConnection
    {
        DatabaseConnection dbConnection = new DatabaseConnection();
        OleDbConnection oledbConnection;
        Application ExcelObj = new Application();
        public int @Id;
        public string @Name;
        public int InsertData()
        {

            string path = "C:/Prakash/DotNet/Cadd_DB.xlsx";
            if (System.IO.Path.GetExtension(path) == ".xlsx")
            {
                oledbConnection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=2\"");
            }
            oledbConnection.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = oledbConnection;
            List<LocalDBConnection> listObj = new List<LocalDBConnection>()
            {
                new LocalDBConnection() {Id=1,Name="EEE" }
            };
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Insert into [Department$] (DID,DNAME) values(@Id,@Name)";
            foreach (var item in listObj)
            {
                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Name", item.Name);
            }
            int a=cmd.ExecuteNonQuery();
 return a;
        }
        public int UpdateData()
        {
            return 1;
        }
        public System.Data.DataTable GetData()
        {
            System.Data.DataTable dt=new System.Data.DataTable();
            return dt;
        }


    }
}