using System.ServiceModel;

namespace _001_WCF
{
    [ServiceContract]
    public interface IGeneroService
    {
        [OperationContract(Name = "GetFirst10")]
        Genero[] Get();

        [OperationContract(Name = "GetById")]
        Genero Get(int id);
    }
}
