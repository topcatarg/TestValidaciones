using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestValidaciones
{ 
public class ClaseA: ClaseBase
    {

        private string _nombre;

        [Required]
        public string nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                RaisePropertyChanged("nombre");
            }
        }

        private int _valor;

        [Range(0,50)]
        public int valor
        {
            get { return _valor; }
            set
            {
                _valor = value;
                RaisePropertyChanged("valor");
            }
        }


    }
}
