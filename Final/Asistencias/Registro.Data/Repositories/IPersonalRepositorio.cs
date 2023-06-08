
using Asistencias.Repositories.Base;
using Registro.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencias.Repositories
{
    public interface IPersonalRepositorio : ICrudBase<Personal>
    {
        Personal buscarDNI(string dni);
    }
}
