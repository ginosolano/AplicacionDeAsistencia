using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencias.Repositories.Base
{
    public interface ICrudBase<T>
    {
        /// <summary>
        /// Insertar registros
        /// </summary>
        /// <param name="coreObject"></param>
        void Insert(T coreObject);
        /// <summary>
        /// Actualizar datos
        /// </summary>
        /// <param name="coreObject"></param>
        void Update(T coreObject);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetItem(Guid id);
        void Delete(T coreObject);
        IList<T> GetList();
    }
}
