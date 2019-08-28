using ALE.ETLBox.ConnectionManager;
using ALE.ETLBox.ControlFlow;
using ALE.ETLBox.DataFlow;
using ALE.ETLBox;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
namespace CaddAmmerpet.API_Configuration.ETL
{
    public class ETLControlFlowTask
    {
        public void GetCurrentDatabaseConnection(string connectionString)
        {
            ControlFlow.CurrentDbConnection = new SqlConnectionManager(new ConnectionString(connectionString));
        }
        public int CreateDatabase(string dbName)
        {
            GetCurrentDatabaseConnection("");
            CreateDatabaseTask.Create(dbName);
            return 1;
        }
        public bool CreateTable(string tblName)
        {
            GetCurrentDatabaseConnection("");
            CreateTableTask.Create(tblName,new List<TableColumn>() {
                new TableColumn("","",allowNulls:false,isIdentity:true,isPrimaryKey:true)
            });
            return ControlFlow.CurrentLoadProcess.WasSuccessful;
        }
    }
}