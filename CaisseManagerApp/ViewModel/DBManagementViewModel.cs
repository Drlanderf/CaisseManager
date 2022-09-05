using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using static System.Net.Mime.MediaTypeNames;
using System.Data.OleDb;
using CommonClassLibrary;

namespace CaisseManagerApp.ViewModel
{
    public class DBManagementViewModel : ViewModelBase
    {

        public DBManagementViewModel()
        {
        }

        public string Row_Article(string Code_BarreTmp, string WhatToSearch)
        {//TODO : RETOURNER UN ARTICLE !!!! MODEL A FAIRE
            try
            {
                DAL myDAL = DAL.GetInstance();
                string result = myDAL.ExecuteQuery("SELECT " +
                    "TBLARTICLE.[CODE_BARRE], " +
                    "TBLARTICLE.[DESCRIPTION], " +
                    "TBLARTICLE.[PA], " +
                    "TBLARTICLE.[PV] " +
                    "FROM TBLARTICLE " +
                    "WHERE(((TBLARTICLE.[CODE_BARRE]) = '" + Code_BarreTmp + "'));", WhatToSearch);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

    }
}
