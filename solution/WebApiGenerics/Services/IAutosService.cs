using WebApiGenerics.Model;

namespace WebApiGenerics.Services;

public interface IAutosService : IGenericService<Auto>
{
    Task<Auto?> Get(int id);
}