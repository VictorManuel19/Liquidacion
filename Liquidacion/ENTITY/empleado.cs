using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class empleado : liquidacion
    {
        public empleado()
        {
            this.tipoRegimen = tipoRegimen;
            this.nombre = nombre;
            this.numeroIdentificacion = numeroIdentificacion;
            this.semanaCotizada = semanaCotizada;
            this.ibl = ibl;
            this.sexo = sexo;
            this.edad = edad;
            this.liquidar = liquidar;
        }
        public override double Liquidar()
        {
            liquidar = semanaCotizada * 1.5;

            return liquidar;
        }

    }

    
}
