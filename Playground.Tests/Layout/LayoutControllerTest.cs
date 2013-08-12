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


        private TestContext testContextInstance;
        private ILayoutService _LayoutService;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes

        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
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
        
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for LayoutController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
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
