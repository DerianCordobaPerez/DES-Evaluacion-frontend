using System.Collections.Generic;
using System.Threading.Tasks;
using Des_evaluacion_frontend.Models;

namespace Des_evaluacion_frontend.Daos
{
    public interface IModelDao<T>
    {
        Task<List<T>> GetDataList();
    }
}