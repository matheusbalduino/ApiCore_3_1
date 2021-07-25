using controleCobranca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controleCobranca.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(c => c.indice);

            builder.Property(c => c.cdContrato)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.nrTermo)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.lote)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(c => c.destinatario)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.Property(c => c.endereco)
                .IsRequired()
                .HasColumnType("varchar(120)");

            builder.Property(c => c.numero)
                .HasColumnType("varchar(10)");

            builder.Property(c => c.complemento)
                .IsRequired()
                .HasColumnType("varchar(60)");

            builder.Property(c => c.bairro)
                .IsRequired()
                .HasColumnType("varchar(30)");


            builder.Property(c => c.cep)
                .IsRequired()
                .HasColumnType("varchar(15)");


            builder.Property(c => c.cidade)
                .IsRequired()
                .HasColumnType("varchar(50)");


            builder.Property(c => c.uf)
                .IsRequired()
                .HasColumnType("char(2)");


            builder.Property(c => c.obs)
                .IsRequired()
                .HasColumnType("varchar(200)");


            builder.Property(c => c.registroPlano)
                .IsRequired()
                .HasColumnType("varchar(60)");

            builder.Property(c => c.dataEnvio)
                .IsRequired()
                .HasColumnType("DateTime");


            builder.Property(c => c.titulo)
                .IsRequired()
                .HasColumnType("varchar(40)");

            builder.Property(c => c.vencimento)
                .IsRequired()
                .HasColumnType("DateTime");

            builder.Property(c => c.obs)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.valor)
                .IsRequired()
                .HasColumnType("money");

            builder.ToTable("controleCobranca", "dbo");
        }
    }
}
