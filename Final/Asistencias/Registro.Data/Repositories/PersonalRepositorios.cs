using Asistencias.Data.Repositories.Base;

using Asistencias.Repositories;
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
    public class PersonalRepositorios : Context, IPersonalRepositorio
    {
        public Personal buscarDNI(string dni)
        {
            var obj = DbContext.Personals.FirstOrDefault(x => x.DNI == dni);
            if (obj == null) return null;
            return obj;
        }

        public void Delete(Personal CoreObject)
        {
            var obj = DbContext.Personals.FirstOrDefault(x => x.Id == CoreObject.Id);
            if (obj == null) return;
            DbContext.Personals.Remove(obj);
            DbContext.SaveChanges();

        }
 
        public Personal GetItem(Guid id)
        {
            var obj = DbContext.Personals.FirstOrDefault(x => x.Id == id);
            if (obj == null) return null;
            return obj;
        }

        public IList<Personal> GetList()
        {
            return DbContext.Personals.ToList();

        }

        public void Insert(Personal coreObject)
        {
            DbContext.Personals.AddOrUpdate(coreObject);
            DbContext.SaveChanges();

        }

        public void Update(Personal coreObject)
        {
            var obj = DbContext.Personals.FirstOrDefault(x => x.Id == coreObject.Id);
            if (obj == null) return;
            obj.Nombre = coreObject.Nombre;
            obj.Apellido = coreObject.Apellido;
            obj.FechaNac = coreObject.FechaNac;
            obj.Foto = coreObject.Foto;
            obj.Domicilio = coreObject.Domicilio;
            obj.Email = coreObject.Email;
            obj.DNI = coreObject.DNI;
            obj.IdHorario = coreObject.IdHorario;
            DbContext.Personals.AddOrUpdate();
            DbContext.SaveChanges();

        }
    }
}
