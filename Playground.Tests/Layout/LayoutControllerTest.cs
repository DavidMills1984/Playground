using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;
using System.Linq;
using Moq;
using Playground.Model.Interfaces;
using Playground.Data.Concrete;
using Playground.WebUI.Controllers;
using Playground.Model.Concrete;

namespace Playground.Tests
{
    
    /// <summary>
    ///This is a test class for LayoutControllerTest and is intended
    ///to contain all LayoutControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LayoutControllerTest
    {
        private ILayoutService _LayoutService;

        /// <summary>
        /// Initialise the layout service used in tests
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            //Setup and return a Mocked layout model for testing

            Mock<ILayoutService> mockedService = new Mock<ILayoutService>();
            Mock<Menu> mockedMenu = new Mock<Menu>();
            Mock<MenuItem> mockedMenuItem = new Mock<MenuItem>();
            Mock<MenuItem> mockedSubMenuItem = new Mock<MenuItem>();

            //Setup mock sub menu item
            mockedSubMenuItem.Setup(m => m.Action).Returns("TestSubRef");
            mockedSubMenuItem.Setup(m => m.Title).Returns("TestSubTitle");

            //Setup mock menu item
            mockedMenuItem.Setup(m => m.Action).Returns("TestRef");
            mockedMenuItem.Setup(m => m.Title).Returns("TestTitle");
            mockedMenuItem.Setup(m => m.SubItems).Returns(new List<MenuItem>() {
                    mockedSubMenuItem.Object
                });

            //Seup mock menu
            mockedMenu.Setup(m => m.Items).Returns(new List<MenuItem>() {
                    mockedMenuItem.Object
                });

            //Use mock menu to populate new Layout service
            mockedService.Setup(m => m.GetMenu(It.IsAny<string>()))
                .Returns<string>(x => mockedMenu.Object);

            _LayoutService = mockedService.Object;
        }
        
        /// <summary>
        ///A test for LayoutController Constructor
        ///</summary>
        [TestMethod()]
        public void LayoutControllerConstructorTest()
        {
            //Arrange
            //Layout model has already been created in unit test initilisation

            //Act
            NavController mockController = new NavController(_LayoutService);

            List<MenuItem> result = ((Menu)mockController.Home().Model).Items;

            //Assert

            //Do we have a menu item?
            Assert.IsTrue(result.Any());
            MenuItem menuItem = result.First();

            //Is it the correct menu item?
            Assert.AreEqual(menuItem.Action, "TestRef");
            Assert.AreEqual(menuItem.Title, "TestTitle");

            //Do we have a sub item?
            Assert.IsTrue(menuItem.SubItems.Any());
            MenuItem subMenuItem = menuItem.SubItems.First();

            //Is it the correct menu item?

            Assert.AreEqual(subMenuItem.Action, "TestSubRef");
            Assert.AreEqual(subMenuItem.Title, "TestSubTitle");

        }
    }
}
