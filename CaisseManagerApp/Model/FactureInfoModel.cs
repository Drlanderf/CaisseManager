using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonClassLibrary;
//TODO : Refaire ce model sur base de ce que j'ai fait pour ArticleModel
namespace CaisseManagerApp.Model
{
    public class FactureInfoModel
    {
        public DateTime DATE_PRINT { get; set; }
        public DateTime DATE_ECHEANCE { get; set; }
        public string TVA { get; set; }
        public string COMMANDE { get; set; }
        public string RefCommClient { get; set; }
        public string Rayon { get; set; }
        public FactureInfoModel()
        {
            this.DATE_PRINT = DateTime.Now;
            this.DATE_ECHEANCE = DateTime.Now;
        }
        public void FacturationPrint()
        {
            ExcelManagement myFacture = new ExcelManagement();
            myFacture.Facture(this.DATE_PRINT,
                    this.DATE_ECHEANCE,
                    this.TVA,
                    this.COMMANDE);
        }
    }
}
