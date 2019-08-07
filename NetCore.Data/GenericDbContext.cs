using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;

namespace NetCore.Data
{
    /// <summary>
    /// Clase que representa el contexto básico
    /// </summary>
    public class GenericDbContext : DbContext
    {
        /// <summary>
        /// Transaccion en curso si la hay
        /// </summary>
        protected IDbContextTransaction transaction;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options">Las opciones del DbContext</param>
        public GenericDbContext(DbContextOptions options) : base(options) { }

        /// <summary>
        /// Guarda los cambios de las entidades en la base de datos
        /// </summary>
        public virtual new void SaveChanges() => base.SaveChanges();

        /// <summary>
        /// Guarda los cambios de las entidades en la base de datos asíncronamente
        /// </summary>
        public virtual async Task SaveChangesAsync() => await base.SaveChangesAsync().ConfigureAwait(false);

        /// <summary>
        /// Metodo que inicia una transaccion
        /// </summary>
        public void BeginTransaction() => transaction = Database.BeginTransaction();

        /// <summary>
        /// Commit de la transaccion
        /// </summary>
        public void Commit()
        {
            try
            {
                if (transaction != null)
                {
                    transaction.Commit();
                    transaction.Dispose();
                    transaction = null;
                }
            }
            catch
            {
                if (transaction != null)
                    transaction.Rollback();

                throw;
            }
        }

        /// <summary>
        /// Rollback de la transaccion
        /// </summary>
        public void Rollback()
        {
            if (transaction != null)
            {
                transaction.Rollback();
                transaction.Dispose();
                transaction = null;
            }
        }
    }
}
