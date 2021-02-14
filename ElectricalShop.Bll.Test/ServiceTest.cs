using System;
using ElectricalShop.Bll.Services.Interfaces;
using ElectricalShop.Common.Models;
using NUnit.Framework;

namespace ElectricalShop.Bll.Test
{
    [TestFixture]
    public class ServiceTest
    {
        private IService<Item> _itemService;

        [SetUp]
        public void Init()
        {
            _itemService = null;
        }

        [Test]
        public void Service_NameRequired()
        {
            Item item = _itemService.Create(new Item());
            string name = item.Name;

            Assert.That(name, Is.Not.Empty);
        }

        [Test]
        public void Service_IdRequired()
        {
            Item item = _itemService.Create(new Item());
            int id = item.Id;

            Assert.That(id, Is.Not.Empty);
        }

        [Test]
        public void Service_ProductCategoryIdRequired()
        {
            Item item = _itemService.Create(new Item());
            int productCategoryId = item.ProductCategoryId;

            Assert.That(productCategoryId, Is.Not.Empty);
        }

        [Test]
        public void Service_DescriptionRequired()
        {
            Item item = _itemService.Create(new Item());
            string description = item.Description;

            Assert.That(description, Is.Not.Empty);
        }

        [Test]
        public void Service_PriceRequired()
        {
            Item item = _itemService.Create(new Item());
            decimal price = item.Price;

            Assert.That(price, Is.Not.Empty);
        }

        [Test]
        public void Service_ProductTypeIdRequired()
        {
            Item item = _itemService.Create(new Item());
            int productTypeId = item.ProductTypeId;

            Assert.That(productTypeId, Is.Not.Empty);
        }

        [Test]
        public void Service_TypeRequired()
        {
            Item item = _itemService.Create(new Item());
            ItemType type = item.Type;

            Assert.That(type, Is.Not.Empty);
        }
    }
}
