using Microsoft.EntityFrameworkCore;

namespace Des_evaluacion_frontend.Helpers
{
    public static class EntityHelper
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class 
            => dbSet.RemoveRange(dbSet);
    }
}