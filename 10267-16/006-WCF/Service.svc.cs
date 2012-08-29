using System.Collections.Generic;
using System.Linq;

namespace _006_WCF
{
    public class Service : IService
    {
        public List<Genero> Get()
        {
            return new Entities().Generos.ToList();
        }
    }
}
