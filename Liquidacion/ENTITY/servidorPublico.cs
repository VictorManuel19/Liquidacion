using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class servidorPublico:liquidacion
    {
        public servidorPublico()
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
            liquidar = semanaCotizada * 3.0;

            return liquidar;
        }
        public override string ToString()
        {
            return $"Regimen {tipoRegimen} Nombre {nombre} numero ID {numeroIdentificacion} semanas cotizadas {semanaCotizada} Salario {ibl} Sexo {sexo} Edad {edad} Liquidacion {liquidar}";
        }
    }

}
