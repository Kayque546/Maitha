using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Config
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto> 
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired();
            builder.Property(c => c.CodigDeBarras).IsRequired();

            

        } 
    }
}
