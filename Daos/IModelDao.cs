using System.Collections.Generic;
using System.Threading.Tasks;
using Des_evaluacion_frontend.Models;

namespace Des_evaluacion_frontend.Daos
{
    public interface IModelDao<T> where T : class
    {
        /// <summary>
        /// Get all the models
        /// </summary>
        /// <returns>All the models</returns>
        Task<List<T>> All();
    }
}