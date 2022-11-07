using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Controllers;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Tests.Controllers
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void AboutTest()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            ViewResult result = controller.About() as ViewResult;
            //Assert
            Assert.IsNotNull(result.Model);
            AboutModel aboutModel = result.Model as AboutModel; 
            Assert.AreEqual("Soolane Moris", aboutModel.Name);
        }
    }
}
