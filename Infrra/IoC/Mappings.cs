using Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.IoC
{
    public static class Mappings
    {
        public static void  MapItemComanda(this ModelBuilder modelBuilder){

            modelBuilder.Entity<ItemComanda>().HasKey(pk => new { pk.ComandaId, pk.ItemId });

            modelBuilder.Entity<ItemComanda>().HasOne(fk => fk.Comanda).WithMany(fk => fk.Itens).HasForeignKey(x => x.ComandaId);

            modelBuilder.Entity<ItemComanda>().HasOne(fk => fk.Item).WithMany(fk => fk.Comandas).HasForeignKey(x => x.ItemId);
        }
    }
}
