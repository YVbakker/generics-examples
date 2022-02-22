using Microsoft.EntityFrameworkCore;
using WebApiGenerics.Model;

namespace WebApiGenerics.Services;

public class GenericService<T> : IGenericService<T> where T : class
{
    private readonly ApplicationContext _context;
    private readonly DbSet<T> _repo;

    public GenericService(ApplicationContext context)
    {
        _context = context;
        _repo = context.Set<T>();
    }

    public async Task<IList<T>> Get()
    {
        return await _repo.ToListAsync();
    }
}