using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductApi.Infrastructure;

namespace ProductApi.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        ProductRepository repo;
        [TestInitialize]
        public void TestSetup()
        {
            ProductInitializeDB db = new ProductInitializeDB();
            System.Data.Entity.Database.SetInitializer(db);
            repo = new ProductRepository();
        }
        [TestMethod]
        public void ShouldProductRepoInititalizingTwoRecordsInBegining()
        {
            var result = repo.GetProducts();
            Assert.IsNotNull(result);
            var nv = result.ToList().Count;
            Assert.AreEqual(2, nv);
        }

        [TestMethod]
        public void ShouldReturnProductForTheGivenInputId()
        {
            string idInput = "1";
            var result = repo.GetById(idInput);
            Assert.IsNotNull(result);
            string nv = result.Title;
            Assert.AreEqual("Hammer", nv);
        }
    }
}
