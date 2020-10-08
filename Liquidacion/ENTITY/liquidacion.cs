using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public abstract class liquidacion
    {
        public string tipoRegimen { get; set; }
        public string nombre { get; set; }
        public double numeroIdentificacion { get; set; }
        public int semanaCotizada { get; set; }
        public double ibl { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }
        public double liquidar { get; set; }
        public abstract double Liquidar();
    }
}
