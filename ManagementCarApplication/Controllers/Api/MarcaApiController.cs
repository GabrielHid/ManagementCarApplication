using ManagementCarApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ManagementCarApplication.Controllers.Api
{
    [RoutePrefix("api/MarcaApi")]
    public class MarcaApiController : ApiController
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("GetMarcas")]
        public List<Marca> Get()
        {
            return db.Marcas.ToList();
        }

        [Route("GetMarcaByNome")]
        public List<Marca> Get(string Nome)
        {
            return db.Marcas.Where(m => m.Nome == Nome).ToList();

        }

        [Route("GetMarcaByOrigem")]
        public List<Marca> GetByOrigem(string Origem)
        {
            return db.Marcas.Where(m => m.Origem == Origem).ToList();
        }


        [Route("CadastraMarca")]
        public void Post([FromBody] Marca marca)
        {
            if (marca != null)
            {
                db.Marcas.Add(marca);
                db.SaveChanges();
            }
            else
            {
                return;
            }
        }

        [Route("EditaMarca/{Id}")]
        public void Put([FromUri] int Id, [FromBody] Marca marca)
        {
            if (Id == marca.Id)
            {
                var objetoEdicao = db.Marcas.Find(Id);
                if (objetoEdicao != null)
                {
                    objetoEdicao.Nome = marca.Nome;
                    objetoEdicao.Origem = marca.Origem;
                }

                db.SaveChanges();
            }
            else
            {
                return;
            }
        }

        [Route("DeletaMarca/{Id}")]
        public void Delete([FromUri] int Id)
        {
            var marca = db.Marcas.Find(Id);

            if (marca != null)
            {
                db.Marcas.Remove(marca);
                db.SaveChanges();
            }
            else
            {
                return;
            }
        }
    }
}
