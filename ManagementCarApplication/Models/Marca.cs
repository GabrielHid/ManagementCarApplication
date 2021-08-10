﻿using System.ComponentModel.DataAnnotations;

namespace ManagementCarApplication.Models
{
    public class Marca
    {

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Origem { get; set; }

    }
}