﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    class Contato
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente cliente { get; set; }
        public string TipoContato{ get; set; }
        public string Telefone { get; set; }
    }
}