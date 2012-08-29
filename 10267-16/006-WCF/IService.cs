using System.Collections.Generic;
using System.ServiceModel;

namespace _006_WCF
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Genero> Get();
    }
}
