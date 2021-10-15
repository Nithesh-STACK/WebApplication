using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using WebApplication.Controllers;
using WebApplication.KaniniModel;

namespace BookTest
{
  
        public class Tests
        {
            public Book c;
            public BooksController mc;
            public Logintabl lt;
            [SetUp]
        public void Setup()
        {
            c = new Book();
            mc = new BooksController();
            lt = new Logintabl();
        }
        [Test]
        public void ValidGetTest()
        {


            var res = mc.GetAllBooks().Result as OkObjectResult;
            Assert.AreEqual(200, res.StatusCode);
        }
        [Test]
        public void InValidGetTest()
        {


            var res = mc.GetAllBooks().Result as OkObjectResult;
            Assert.AreEqual(500, res.StatusCode);
        }
       
    }
}