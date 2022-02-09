using System;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;
using HPlus.Ecommerce.Controllers;
using HPlus.Ecommerce.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HPlus.Ecommerce.Tests
{
    [TestClass]
    public class SampleTests
    {
        [TestMethod]
        public void GetLoginIndex()
        {
            // arrange
            var controllerUnderTest = new LoginController();

            // act
            var result = controllerUnderTest.Index() as ViewResult;

            // assert
            Assert.IsTrue(result.ViewName == "" || result.ViewName == "Index");
        }

        [TestMethod]
        public void GetProductIndex()
        {
            // arrange
            var controllerUnderTest = new ProductController();
            
            // act
            var result = controllerUnderTest.Index() as ViewResult;

            // assert
            Assert.IsTrue(result.ViewName == "" || result.ViewName == "Index");
        }

        [TestMethod]
        public void GeProductDetail()
        {
            var controllerUnderTest = new ProductController();
            var result = controllerUnderTest.Detail("womens-winter-jacket") as ViewResult;
            var product = (Product)result.ViewBag.Product;
            Assert.AreEqual("Women's Winter Jacket", product.Name);
        }
    }
}
