using WebApiDefault.Model;

namespace WebApiDefault.Services;

public interface IKlantenService
{
    Task<IList<Klant>> Get();
}