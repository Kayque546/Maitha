using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Dominio.Entidades
{
    public class Conta : Base
    {
        public int ClienteId { get; set; }
        public int AgenciaId { get; set; }
        public string Tipo { get; set; }
        public int NRconta { get; set; }
        public decimal Saldo { get; set; }

        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }
    }
}
