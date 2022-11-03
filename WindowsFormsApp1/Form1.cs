using KolayMuhasebe.Import;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var user = new UserImportClass
            {
                UserName = "admin",
                Password = "admin12345"
            };

            var muhasebeFis = new MuhasebeFisImportClass()
            {
                FisTarihi = DateTime.Now,
                DonemAdi = "2022-2023 Dönemi",
                FisAciklama = "Import Fişi",
            };

            var fisHareketler = new List<MuhasebeFisHareketImportClass>()
            {
                new MuhasebeFisHareketImportClass
                {
                    HesapKodu = "100 01",
                    Borc = 2500,
                    Alacak = 0,
                    HareketNotu = "Ürün Satış"
                },
                new MuhasebeFisHareketImportClass
                {
                    HesapKodu = "320 01 01",
                    Borc = 0,
                    Alacak = 2500,
                    HareketNotu = "Ürün Satış"
                }
            };

            var import = new MuhasebeFisImport(user, muhasebeFis, fisHareketler);
            import.ExecuteImport();
        }
    }
}
