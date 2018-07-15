using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppEntityFrameworkCore
{
    class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"data source=.\sqlexpress;initial catalog=db_Uber;integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(x =>
            {
                x.ToTable("tbl_Usuario");

                x.HasKey(y => y.ID);

                x.Property(y => y.ID).HasColumnName("ID_Usuario");
                x.Property(y => y.Nome).HasColumnName("Nome_Usuario");
                x.Property(y => y.Sobrenome).HasColumnName("Sobrenome_Usuario");
            });

            modelBuilder.Entity<FormaPag>(x =>
            {
                x.ToTable("tbl_FormPag");

                x.HasKey(y => y.FormaPagamento);

                x.Property(y => y.FormaPagamento).HasColumnName("FormaPagamento");
            });

            modelBuilder.Entity<Motorista>(x =>
            {
                x.ToTable("tbl_Motorista");

                x.HasKey(y => y.ID);

                x.Property(y => y.ID).HasColumnName("ID_Motorista");
                x.Property(y => y.Nome).HasColumnName("Nome_Motorista");
                x.Property(y => y.Precokm).HasColumnName("Precokm_Motorista");
            });

            modelBuilder.Entity<Corridas>(x =>
            {
                x.ToTable("tbl_Corridas");

                x.HasKey(y => y.ID);

                x.Property(y => y.ID).HasColumnName("ID_Corrida");
                x.Property(y => y.Usuario).HasColumnName("Usuario_Corrida");
                x.Property(y => y.Preco).HasColumnName("Preco_Corrida");
                x.Property(y => y.Horario).HasColumnName("Horario_Corrida");
                x.Property(y => y.Pagamento).HasColumnName("Pagamento_Corrida");
                x.Property(y => y.Fpagamento).HasColumnName("FormaPagamento");
                //x.Property(y => y.ID_Usuario).HasColumnName("ID_Usuario");
                //x.Property(y => y.ID_Motorista).HasColumnName("ID_Motorista");

            });

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<FormaPag> FormaPagamentos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Corridas> Corridas { get; set; }
    }
}