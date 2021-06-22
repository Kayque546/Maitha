using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    class Cliente
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string email{ get; set; }
        public int CPFCNPJ { get; set; }
        public virtual List<Contato> Contatos  { get; set; };
    }
}
