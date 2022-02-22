using Microsoft.EntityFrameworkCore;
using WebApiDefault.Model;

namespace WebApiDefault.Services;

public class MedewerkersService : IMedewerkersService
{
    private readonly ApplicationContext _context;
    private readonly DbSet<Medewerker> _medewerkersRepo;

    public MedewerkersService(ApplicationContext context)
    {
        _context = context;
        _medewerkersRepo = context.Set<Medewerker>();
    }

    public async Task<IList<Medewerker>> Get()
    {
        return await _medewerkersRepo.ToListAsync();
    }
}