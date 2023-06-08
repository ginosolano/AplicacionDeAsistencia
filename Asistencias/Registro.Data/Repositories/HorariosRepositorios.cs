using Asistencias.Data.Repositories.Base;
using Registro.Data.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencias.Repositories
{
    public class HorariosRepositorios : Context, IHorariosRepositorios
    {
        public void Delete(Horario coreObject)
        {
            var obj = DbContext.Horarios.FirstOrDefault(x => x.Id == coreObject.Id);
            if (obj == null) return;
            DbContext.Horarios.Remove(obj);
            DbContext.SaveChanges();
        }
        public Horario GetItem(Guid id)
        {
            var obj = DbContext.Horarios.FirstOrDefault(x => x.Id == id);
            return obj;
        }

        public IList<Horario> GetList()
        {
            return DbContext.Horarios.ToList();
        }

        public void Insert(Horario coreObject)
        {
            DbContext.Horarios.Add(coreObject);
            DbContext.SaveChanges();
        
        }

        public void Update(Horario coreObject)
        {
            var obj = DbContext.Horarios.FirstOrDefault(x => x.Id == coreObject.Id);
            if (obj == null) return;
            obj.hsSalida = coreObject.hsSalida;
            obj.minSalida = coreObject.minSalida;
            obj.hsEntrada = coreObject.hsEntrada;
            obj.minEntrada = coreObject.minEntrada;
            DbContext.Horarios.AddOrUpdate(obj);
            DbContext.SaveChanges();

        }


    }
}
