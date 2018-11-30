using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class MainWindowViewNodel:BindableBase
    {
        public  Personel Kisi { get; set; }

        public DelegateCommand GuncelleCommand => new DelegateCommand(Guncelle);

        private void Guncelle()
        {
            RaisePropertyChanged(nameof(Kisi));

        

            //Kisi.AdSoyadRefresh();

        }

        public MainWindowViewNodel()
        {
            var kisi = new Personel();

            kisi.Ad = "gok";
            kisi.Soyad = "faruk";

            Kisi = kisi;
        }
    }
}
