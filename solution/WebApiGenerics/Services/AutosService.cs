using Microsoft.EntityFrameworkCore;
using WebApiDefault.Model;

namespace WebApiDefault.Services;

public class AutosService : IAutosService
{
    private readonly ApplicationContext _context;
    private readonly DbSet<Auto> _autosRepo;

    public AutosService(ApplicationContext context)
    {
        _context = context;
        _autosRepo = context.Set<Auto>();
    }

    public async Task<IList<Auto>> Get()
    {
        return await _autosRepo.ToListAsync();
    }

    public async Task<Auto?> Get(int id)
    {
        return await _autosRepo.FirstOrDefaultAsync(a => a.Id.Equals(id));
    }
}