
using Registro.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencias.Data.Repositories.Base
{
    public class Context
    {
        private AsistenciasEntities _dbContext { get; set; }
        public AsistenciasEntities DbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    _dbContext = new AsistenciasEntities();
                }
                return _dbContext;
            }
        }

    }
}
