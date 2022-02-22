using Microsoft.EntityFrameworkCore;
using WebApiGenerics.Model;

namespace WebApiGenerics.Services;

public class KlantenService : IGenericService<Klant>
{
    private readonly ApplicationContext _context;
    private readonly DbSet<Klant> _klantenRepo;

    public KlantenService(ApplicationContext context)
    {
        _context = context;
        _klantenRepo = context.Set<Klant>();
    }

    public async Task<IList<Klant>> Get()
    {
        return await _klantenRepo.ToListAsync();
    }
}