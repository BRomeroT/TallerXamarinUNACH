using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNACH.TallerXamarin.Core.Model;

namespace UNACH.TallerXamarin.Core.ViewModel
{
    public class SaludoViewModel : ViewModelBase
    {
        public SaludoViewModel()
        {
            Usuario.PropertyChanged += (s, e) =>
            {
                switch (e.PropertyName)
                {
                    case "Nombre":
                        SaludarCommand.RaiseCanExecuteChanged();
                        break;
                    default:
                        break;
                }
            };
        }
        
        private Usuario usuario;
        public Usuario Usuario
        {
            get { return usuario ?? (usuario = new Usuario()); }
            set { Set(ref usuario, value); }
        }
        
        private string saludo;
        public string Saludo
        {
            get { return saludo; }
            set { Set(ref saludo, value); }
        }

        RelayCommand saludarCommand = null;
        public RelayCommand SaludarCommand
        {
            get
            {
                return saludarCommand ?? (saludarCommand = new RelayCommand(() =>
                {
                    Saludo = $"Hola {Usuario.Nombre} {DateTime.Now.ToString()}";
                }, 
                () => { return !string.IsNullOrWhiteSpace(Usuario.Nombre); }));
            }
        }
    }
}
