using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestValidaciones
{
    public class ClaseB: ClaseA
    {

        private string _nombreb;

        [Required]
        public string nombreb
        {
            get { return _nombreb; }
            set
            {
                _nombreb = value;
                RaisePropertyChanged("nombreb");
            }
        }

    }
}
