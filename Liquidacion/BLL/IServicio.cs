using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IServicio
    {
        bool Guardar(object datos);
        bool Update(object datos);
        bool Delete(object datos);
        bool Read(object datos);

        object ReadAll();

    }
}
