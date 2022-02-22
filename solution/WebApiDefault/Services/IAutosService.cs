using WebApiDefault.Model;

namespace WebApiDefault.Services;

public interface IAutosService
{
    Task<IList<Auto>> Get();
    Task<Auto?> Get(int id);
}