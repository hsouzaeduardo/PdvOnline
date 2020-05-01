using Dominio;
using Dominio.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarItensComandaUmItem()
        {

            Item item = new Item() { Descricao = "Cerveja", Preco = 10 };

            Comanda comanda = new Comanda() { Status = StatusComanda.Aberta, Numero = "BZE1000" };

            var ItemComanda = new ItemComanda() { Comanda = comanda, ComandaId = comanda.Id, Item = item, ItemId = item.Id, Quantidade = 5 };
           
            Comanda comandaItem = new Comanda();

            comandaItem = comanda;

            comandaItem.Itens.Add(ItemComanda);

            var soma = comandaItem.Itens.Sum(x => x.Quantidade * x.Item.Preco);

            Assert.AreEqual(50, soma);
        }

        [TestMethod]
        public void SomarItensComandaMaisItens()
        {

            Item item = new Item() { Descricao = "Cerveja", Preco = 10 };
            Item item2 = new Item() { Descricao = "Vinho", Preco = 50 };

            Comanda comanda = new Comanda() { Status = StatusComanda.Aberta, Numero = "BZE1000" };

            var ItemComanda = new ItemComanda() { Comanda = comanda, ComandaId = comanda.Id, Item = item, ItemId = item.Id, Quantidade = 5 };
            var ItemComanda2 = new ItemComanda() { Comanda = comanda, ComandaId = comanda.Id, Item = item2, ItemId = item2.Id, Quantidade = 8 };

            Comanda comandaItem = new Comanda();

            comandaItem = comanda;
            comandaItem.Itens.Add(ItemComanda);
            var soma = comandaItem.Itens.Sum(x => x.Quantidade * x.Item.Preco);
            Assert.AreEqual(50, soma);

            comandaItem.Itens.Add(ItemComanda2);
            var soma2 = comandaItem.Itens.Sum(x => x.Quantidade * x.Item.Preco);
            Assert.AreEqual(450, soma2);
        }
    }
}
