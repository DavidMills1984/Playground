using Playground.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Playground.Model.Interfaces;
using Playground.Model.Concrete;
using Moq;
using Playground.Data.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Playground.Tests.Layout
{
    
    /// <summary>
    ///This is a test class for LayoutServiceTest and is intended
    ///to contain all LayoutServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LayoutServiceTest
    {

        private ILayoutRepository _LayoutRepository;

        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void Initialize()
        {
            List<MenuItem> menuItems = new List<MenuItem>() {
               new MenuItem() { 
                   Action="Gallery", 
                   Controller="Home", 
                   Title="Gallery",
                   SubItems = new List<MenuItem>() {
                        new MenuItem() { Action="Images", Controller="Home", Title="Images"}
                   }
               },
                new MenuItem() {
                    Action="Blog",
                    Controller="Home",
                    Title="Blog"
               } 
            };

            Mock<LayoutRepository> layoutRepository = new Mock<LayoutRepository>();
            layoutRepository.Setup(x => x.GetMenuData(It.IsAny<string>()))
                .Returns(menuItems);

            _LayoutRepository = layoutRepository.Object;
        }

        /// <summary>
        ///A test for GetMenu
        ///</summary>
        [TestMethod()]
        public void GetMenuTest()
        {
            //Arrange
            LayoutService testService = new LayoutService(_LayoutRepository);

            //Act
            Menu actual = testService.GetMenu("AdminMenu");

            //Assert
            Assert.AreEqual(actual.Items.Count, 2);
            //Test Menu items are working as expected
            MenuItem menuItem = actual.Items.First();
            Assert.AreEqual(menuItem.Title, "Gallery");
            Assert.AreEqual(menuItem.Action, "Gallery");
            Assert.AreEqual(menuItem.Controller, "Home");
            Assert.AreEqual(menuItem.SubItems.Count, 1);
            //Test SubMenu items are working as expected
            menuItem = menuItem.SubItems.First();
            Assert.AreEqual(menuItem.Title, "Images");
            Assert.AreEqual(menuItem.Action, "Images");
            Assert.AreEqual(menuItem.Controller, "Home");
            
        }
    }
}
