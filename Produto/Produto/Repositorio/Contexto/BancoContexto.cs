﻿using Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Contexto
{
    public class BancoContexto : DbContext
    {
        DbSet<Produto> Produtos { get; set; }

        public BancoContexto(DbContextOptions options) : base(options)
        {
        } 
    }
}
