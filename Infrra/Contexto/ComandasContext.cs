using Dominio.Entity;
using Infra.InitializeDB;
using Infra.IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Infra.Contexto
{
    public class ComandasContext : DbContext
    {
        public ComandasContext(DbContextOptions<ComandasContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.MapItemComanda();
            modelBuilder.InitDb();
        }

        public DbSet<Conta> Contas { get; set; }

        public DbSet<Comanda> Comandas { get; set; }

        public DbSet<Item> Itens { get; set; }

        public DbSet<Nota> Nota { get; set; }
    }

    
    //install-package  Microsoft.Extensions.Configuration.Json -version 2.1
    //install-package  Microsoft.Extensions.Configuration.FileExtensions 2.1
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ComandasContext>
    {
        public IConfigurationRoot Config { get; private set; }

        public ComandasContext CreateDbContext(string[] args)
        {
            Config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            var builder = new DbContextOptionsBuilder<ComandasContext>();

            var connectionString = Config.GetConnectionString("ComandaDB");

            
            builder.UseSqlServer(connectionString);

            return new ComandasContext(builder.Options);
        }
    }
}
