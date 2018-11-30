using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Personel : BindableBase
    {
        private string _ad;
        private string _soyad;

        public string Ad
        {
            get => _ad;
            set
            {
                SetProperty(ref _ad, value);
            }
        }
        public string Soyad
        {
            get => _soyad;
            set
            {
                SetProperty(ref _soyad, value);
            }
        }

        public string AdSoyad => Ad + " " + Soyad;

        public void AdSoyadRefresh() => RaisePropertyChanged(nameof(AdSoyad));
    }
}
