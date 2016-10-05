using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNACH.TallerXamarin.Core.Model
{
    public class Usuario : ObservableObject
    {

        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                Set(ref nombre, value);
            }
        }
    }
}
