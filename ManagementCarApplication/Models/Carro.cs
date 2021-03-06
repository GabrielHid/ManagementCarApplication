using System;
using System.ComponentModel.DataAnnotations;

namespace ManagementCarApplication.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int KmPorGalao { get; set; }

        public int Cilindros { get; set; }

        public int CavaloPotencia { get; set; }

        public int Peso { get; set; }

        public int Acelerecao { get; set; }

        public DateTime Ano { get; set; }

        public string Origem { get; set; }
    }
}