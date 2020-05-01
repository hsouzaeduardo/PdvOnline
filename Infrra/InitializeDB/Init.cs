using Dominio.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.InitializeDB
{
    public static class Init
    {
        public static void InitDb(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item() { Descricao = "Cerveja", Disponivel = 0, DtCriacao = DateTime.Now, Preco = 5m, UsuarioCriacao = "EF" },
                new Item() { Descricao = "Vinho", Disponivel = 0, DtCriacao = DateTime.Now, Preco = 25m, UsuarioCriacao = "EF" },
                new Item() { Descricao = "Porção Fritas", Disponivel = 0, DtCriacao = DateTime.Now, Preco = 35m, UsuarioCriacao = "EF" },
                new Item() { Descricao = "Porção Pastel", Disponivel = 0, DtCriacao = DateTime.Now, Preco = 45m, UsuarioCriacao = "EF" },
                new Item() { Descricao = "Suco", Disponivel = 0, DtCriacao = DateTime.Now, Preco = 5m, UsuarioCriacao = "EF" },
                new Item() { Descricao = "Água", Disponivel = 0, DtCriacao = DateTime.Now, Preco = 5m, UsuarioCriacao = "EF" });


            modelBuilder.Entity<Comanda>().HasData(
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1000", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1001", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1002", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1003", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1004", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1005", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1006", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1007", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1008", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1009", Status = StatusComanda.Livre },
                new Comanda() { DtCriacao = DateTime.Now, UsuarioCriacao = "EF", Numero = "BDZ1010", Status = StatusComanda.Livre });


        }
    }
}

