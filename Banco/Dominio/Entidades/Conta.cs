﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    class Conta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente  { get; set; }
        public string Tipo { get; set; }
        public int NRconta { get; set; }
        public decimal Saldo { get; set; }
    }
}