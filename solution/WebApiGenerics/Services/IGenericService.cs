namespace WebApiDefault.Services;

public interface IGenericService<T>
{
    Task<IList<T>> Get();
}