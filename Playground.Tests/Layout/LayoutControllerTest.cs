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
using Playground.WebUI.Models;

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
        private ILayoutRepository repository;

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
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            //Setup and return a Mocked layout model for testing

            Mock<ILayoutRepository> mockedRepository = new Mock<ILayoutRepository>();
            Mock<IMenu> mockedMenu = new Mock<IMenu>();
            Mock<IMenuItem> mockedMenuItem = new Mock<IMenuItem>();
            Mock<IMenuItem> mockedSubMenuItem = new Mock<IMenuItem>();

            //Setup mock sub menu item
            mockedSubMenuItem.Setup(m => m.Reference).Returns("TestSubRef");
            mockedSubMenuItem.Setup(m => m.Title).Returns("TestSubTitle");

            //Setup mock menu item
            mockedMenuItem.Setup(m => m.Reference).Returns("TestRef");
            mockedMenuItem.Setup(m => m.Title).Returns("TestTitle");
            mockedMenuItem.Setup(m => m.SubItems).Returns(new List<IMenuItem>() {
                    mockedSubMenuItem.Object
                });

            //Seup mock menu
            mockedMenu.Setup(m => m.Items).Returns(new List<IMenuItem>() {
                    mockedMenuItem.Object
                });

            mockedRepository.Setup(m => m.Menu).Returns(mockedMenu.Object);

            //Use mock menu to populate new Layout model

            this.repository = mockedRepository.Object;
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
            NavController mockController = new NavController(repository);

            List<IMenuItem> result = (List<IMenuItem>)mockController.Menu().Model;

            //Assert

            //Do we have a menu item?
            Assert.IsTrue(result.Any());
            IMenuItem menuItem = result.First();

            //Is it the correct menu item?
            Assert.AreEqual(menuItem.Reference, "TestRef");
            Assert.AreEqual(menuItem.Title, "TestTitle");

            //Do we have a sub item?
            Assert.IsTrue(menuItem.SubItems.Any());
            IMenuItem subMenuItem = menuItem.SubItems.First();

            //Is it the correct menu item?

            Assert.AreEqual(subMenuItem.Reference, "TestSubRef");
            Assert.AreEqual(subMenuItem.Title, "TestSubTitle");

        }
    }
}
