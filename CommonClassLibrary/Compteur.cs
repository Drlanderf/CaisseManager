using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace CommonClassLibrary
{
    public class Compteur
    {
        public RegistryKey rk { get; set; }
        public RegistryKey AdminKey { get; set; }



        public Compteur()
        {
            this.rk = Registry.CurrentUser.CreateSubKey("Software");
            this.AdminKey = rk.CreateSubKey("CaisseManager");
        }
        public string GetCmpt()
        {
            RegistryKey admin = AdminKey;
            if (admin != null)
            {
                if (admin.GetValue("Compteur") != null)
                {
                    return admin.GetValue("Compteur").ToString();
                }
                else
                    admin.SetValue("Compteur", 1);
            }
            return admin.GetValue("Compteur").ToString();

        }
        public void SetCmpt(int cmpt)
        {
            RegistryKey admin = AdminKey;
            if (admin != null)
            {
                if (admin.GetValue("Compteur") != null)
                {
                    admin.SetValue("Compteur", cmpt);
                }
                else
                    admin.SetValue("Compteur", 1);
            }
        }
        public void IncCmpt()
        {
            RegistryKey admin = AdminKey;
            if (admin != null)
            {
                if (admin.GetValue("Compteur") != null)
                {
                    SetCmpt(int.Parse(admin.GetValue("Compteur").ToString()) + 1);
                }
                else
                    admin.SetValue("Compteur", 1);
            }
        }
    }
}
