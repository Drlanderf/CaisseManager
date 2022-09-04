using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using System.Data.OleDb;
namespace CommonClassLibrary
{
    public class DAL
    {
        private OleDbConnection connection;
        private static DAL _instance = null;

        public static DAL getInstance()
        {
            if (_instance == null)
            {
                _instance = new DAL();
            }
            return _instance;//singleton
        }

        private DAL()
        {
            //ACCESS
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + 
                                       Environment.CurrentDirectory + 
                                       @"\CaisseManagerDB\DBCaisseManager.accdb;
                                       Persist Security Info=False;
                                       Jet OLEDB:Database Password=";
            connection = new OleDbConnection(connectionString);


            //mySQL
            /*
            private MySqlConnection connection;
            private const string server="";//IP DU SERVEUR
            private const string database = "";//BASE DE DONNEE A CONTACTER
            private const string username = "";//USERNAME DE CONNEXION
            private const string password = "";//MOT DE PASSE DE CONNEXION
            string connectstring = "server =" + server + 
                "; database=" + database + 
                "; username=" + username + 
                "; password = " + password + 
                ";";
            */
            //connection = new MySqlConnection(connectstring);

        }
        private void DB_open()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
        private void DB_close()

        {
            connection.Close();
        }
        public DataTable ExecuteQuery_dt(string Query)
        {
            DataTable dt = new DataTable();
            this.DB_open();
            try
            {
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                OleDbDataReader dataReader = cmd.ExecuteReader();
                dt.Load(dataReader);
                dataReader.Close();
                return dt;
            }
            finally
            {
                this.DB_close();
            }
        }
        public void ExecuteNonQuery_dt(string Query)
        {
            this.DB_open();
            try
            {
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                this.DB_close();
            }
        }
        public string ExecuteQuery(string Query,string WhatToSearch)
        {
            string data = null;
            this.DB_open();
            try
            {
                
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                OleDbDataReader dataReader = cmd.ExecuteReader();
                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {
                        switch(WhatToSearch)
                        {
                            case "Description":
                                data = dataReader[1].ToString();
                                return data;
                            case "PA":
                                data = dataReader[2].ToString();
                                return data;
                            case "PV":
                                data = dataReader[3].ToString();
                                return data;
                            default:
                                return data;
                        }
                    }
                }
                return data;
            }
            finally
            {
                this.DB_close();
            }
        }
        
        

        
        //TODO: Faire une grosse querry et traiter en mem et non faire plusieurs requete a chaque fois
        /*public string DBSearchDescription(string Query)
        {
            string qry = "SELECT TBLARTICLE.[DESCRIPTION] AS Status FROM TBLARTICLE WHERE(((TBLARTICLE.[CODE_BARRE]) = '" + Query + "'));";
            try
            {
                OleDbCommand cmd = new OleDbCommand(qry, connection);
                return retourSearch;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }*/
    }
}
