using ManagementCarApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ManagementCarApplication.Controllers.Api
{
    [RoutePrefix("api/CarroApi")]
    public class CarroApiController : ApiController
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("GetCarros")]
        public List<CarroDTO> Get()
        {
            return (from c in db.Carros
                    select new CarroDTO { Nome = c.Nome, Origem = c.Origem, Ano = c.Ano }).ToList(); ;
        }

        [Route("GetCarroByNome")]
        public List<CarroDTO> Get(string Nome)
        {

            List<CarroDTO> listaCarro = new List<CarroDTO>();

            if (!string.IsNullOrEmpty(Nome))
            {
                listaCarro = (from c in db.Carros
                             where c.Nome == Nome
                             select new CarroDTO { Nome = c.Nome, Origem = c.Origem, Ano = c.Ano }).ToList();
            }

            return listaCarro;
        }

        [Route("GetCarroByOrigem")]
        public List<CarroDTO> GetCarroByOrigem(string Origem)
        {
            List<CarroDTO> listaCarro = new List<CarroDTO>();

            if (!string.IsNullOrEmpty(Origem))
            {
                listaCarro = (from c in db.Carros
                              where c.Origem == Origem
                              select new CarroDTO { Nome = c.Nome, Origem = c.Origem, Ano = c.Ano }).ToList();
            }

            return listaCarro;
        }

        [Route("CadastraCarro")]
        public void Post([FromBody] Carro carro)
        {
            if (carro == null)
            {
                return;
            }

            db.Carros.Add(carro);
            db.SaveChanges();
        }

        [Route("DetalhaCarro")]
        public List<Carro> GetDetalhamento()
        {
            return db.Carros.ToList();
        }

        [Route("EditaCarro/{Id}")]
        public void Put([FromUri] int id, [FromBody] Carro carro)
        {

            if (id == carro.Id)
            {
                var objetoEdicao = db.Carros.Find(id);
                if (objetoEdicao != null)
                {   
                    objetoEdicao.Nome = carro.Nome;
                    objetoEdicao.KmPorGalao = carro.KmPorGalao;
                    objetoEdicao.CavaloPotencia = carro.CavaloPotencia;
                    objetoEdicao.Peso = carro.Peso;
                    objetoEdicao.Acelerecao = carro.Acelerecao;
                    objetoEdicao.Ano = carro.Ano;
                    objetoEdicao.Origem = carro.Origem;
                }
                db.SaveChanges();
            }
            else
            {
                return;
            }
        }

        [Route("DeletaCarro/{Id}")]
        public void Delete([FromUri] int id)
        {

            Carro carro = db.Carros.Find(id);

            if (carro != null)
            {
                db.Carros.Remove(carro);
                db.SaveChanges();
            }

        }

    }
}
