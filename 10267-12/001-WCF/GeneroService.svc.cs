using System.Linq;

namespace _001_WCF
{
    public class GeneroService : IGeneroService
    {
        public Genero[] Get()
        {
            Genero[] retorno = null;

            using (var e = new Entities())
            {
                retorno = e.Generos.Take(10).ToArray();
            }

            return retorno;
        }

        public Genero Get(int id)
        {
            using (var e = new Entities())
            {
                return e.Generos.FirstOrDefault(c => c.Id == id);
            }
        }
    }
}
