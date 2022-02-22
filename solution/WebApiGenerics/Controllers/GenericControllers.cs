using WebApiGenerics.Model;
using WebApiGenerics.Services;

namespace WebApiGenerics.Controllers;

public class GenericMedewerkersController : GenericController<Medewerker>
{
    public GenericMedewerkersController(IGenericService<Medewerker> service) : base(service)
    {
    }
}