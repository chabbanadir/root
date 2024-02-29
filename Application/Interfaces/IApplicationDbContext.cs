using Microsoft.EntityFrameworkCore;


namespace Application.Interfaces
{
    public interface IApplicationDbContext
    {
       // DbSet<TEntity> Entities { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
