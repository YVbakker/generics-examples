using WebApiDefault.Model;

namespace WebApiDefault.Services;

public interface IMedewerkersService
{
    Task<IList<Medewerker>> Get();
}