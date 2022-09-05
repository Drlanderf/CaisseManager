using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;//nécéssaire pour missing value dans excel
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace CommonClassLibrary
{
    public class ExcelManagement
    {
        //public string TodayDate = DateTime.Now.ToString();
        string TemplateFacture;
        Excel.Application oXl;
        Excel._Workbook oWb;
        Excel._Worksheet oSheet;
        public Excel.Application ExcelOpen()
        {
                string src = Environment.CurrentDirectory + @"\CaisseManagerTemplate\Template_Facture.xlsm";
                string dest = Environment.CurrentDirectory + @"\CaisseManagerTemp\Template_Facture.xlsm";

                try
                {
                    File.Copy(src, dest, true);
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox.Message);
                }
            oXl = new Excel.Application();
            this.oXl.Visible = true; //true pour dev
            this.TemplateFacture = Environment.CurrentDirectory + @"\CaisseManagerTemp\Template_Facture.xlsm";
            this.oWb = (Excel._Workbook)(this.oXl.Workbooks.Open(this.TemplateFacture, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value));
            return oXl;
        }
        public void Facture(DateTime DATE_PRINT, DateTime DATE_ECHEANCE, string TVA, string COMMANDE, string RefCommClient)
        {
            try
            {
                oXl = ExcelOpen();
#pragma warning disable CS0219 // The event is never used
                double ligne = 1, cDESCRIPTION = 1;
#pragma warning restore CS0219
                //FACTURE INFOS
                oSheet = (Excel._Worksheet)oWb.Sheets["Facture"];
                oSheet.Range["FACTURE"].Value = Compteur.getCmpt().ToString();
                oSheet.Range["DATE_PRINT"].Value = DATE_PRINT.ToString();
                oSheet.Range["DATE_ECHEANCE"].Value = DATE_ECHEANCE.ToString();
                oSheet.Range["TVA"].Value = TVA;
                oSheet.Range["COMMANDE"].Value = COMMANDE;
                oSheet.Range["RefCommClient"].Value = RefCommClient;

                //DETAIL
               /* oSheet = (Excel.Worksheet)oWb.Sheets["Detail"];
                oSheet.Cells[]*/


                oSheet.PageSetup.FitToPagesWide = 1;
                oSheet.PageSetup.FitToPagesTall = 1;
                oWb.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, Environment.CurrentDirectory + @"\CaisseManagerFacturation\Facture n " + Compteur.getCmpt().ToString() + ".pdf");
                Compteur.incCmpt();
                oWb.Close(true);
                oXl.Quit();
                //TODO: CHERCHER A SAVOIR INSERER DANS L'AUTRE FEUILLE POUR "DETAIL TICKET"

                
            }
            catch(Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                Console.WriteLine(errorMessage+" Error");
            }
            


        }
        public void Detail()
        {
            try
            {
                oXl = ExcelOpen();
                oXl.Visible = true;

            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                Console.WriteLine(errorMessage + " Error");
            }
        }
        public void SelectWorkSheet(int SheetNumber)
        {

            this.oSheet = oWb.Worksheets[SheetNumber];
        }
    }
}
