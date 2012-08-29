using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace _008_LinqToXml.DAL
{
    public class Usuario
    {
        //crud

        private static readonly String ARQUIVO = HttpContext.Current.Server.MapPath(@"App_Data\Usuario.xml");

        public static void Insert(Model.Usuario u)
        {
            var xml = XDocument.Load(ARQUIVO);

            var linha = new XElement
            (
                "linha",
                new XAttribute("user", u.User),
                new XAttribute("password", u.Password)
            );

            if (xml.Descendants("linha")
                .SingleOrDefault(x => x.Attribute("user").Value.Equals(u.User)) == null)
            {
                xml.Descendants("linhas")
                    .First()
                    .Add(linha);
            }

            xml.Save(ARQUIVO);
        }

        public static void Update(Model.Usuario u)
        {
            var xml = XDocument.Load(ARQUIVO);

            xml.Descendants("linha")
                .SingleOrDefault(x => x.Attribute("user").Value.Equals(u.User))
                .Attribute("password")
                .Value = u.Password;

            xml.Save(ARQUIVO);
        }

        public static void Delete(Model.Usuario u)
        {
            var xml = XDocument.Load(ARQUIVO);

            xml.Descendants("linha")
                .SingleOrDefault(x => x.Attribute("user").Value.Equals(u.User))
                .Remove();

            xml.Save(ARQUIVO);
        }

        public static List<Model.Usuario> GetAll()
        {
            var xml = XDocument.Load(ARQUIVO);

            return xml.Descendants("linha").Select(item => new Model.Usuario
                    {
                        User = item.Attribute("user").Value,
                        Password = item.Attribute("password").Value
                    }).ToList();
        }

        public static Model.Usuario GetByUser(String user)
        {
            return GetAll().Find(o => o.User.Equals(user));
        }
    }
}