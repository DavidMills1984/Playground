using Playground.Data.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Playground.Data.EntityModels;
using System.Collections.Generic;
using Playground.Model.Concrete;
using Moq;
using System.Data.Objects.DataClasses;
using System.Linq;

namespace Playground.Tests.Layout
{
    
    
    /// <summary>
    ///This is a test class for LayoutRepositoryMapperTest and is intended
    ///to contain all LayoutRepositoryMapperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LayoutRepositoryMapperTest
    {

        IEnumerable<EFMenuItem> _MenuItems;
        IEnumerable<EFMenuSubItem> _SubMenuItems;
       
        /// <summary>
        /// Setup test data to be used in mapping tests
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            SetTestData();
        }

        /// <summary>
        /// Co-ordinating method for setting up data
        /// </summary>
        private void SetTestData()
        {
            SetSubMenuItems();
            SetMenuItems();
        }

        /// <summary>
        /// Set up EF test sub menu items
        /// </summary>
        private void SetSubMenuItems()
        {
            EFMenuSubItem menuItem1 = new EFMenuSubItem();
            EFMenuSubItem menuItem2 = new EFMenuSubItem();

            menuItem1.Link = "home/images";
            menuItem2.Link = "home/data";

            menuItem1.Name = "Images";
            menuItem2.Name = "Data";

            _SubMenuItems = new List<EFMenuSubItem>() { 
                menuItem1,
                menuItem2
            };
        }

        /// <summary>
        /// Setup EF test MenuItems
        /// </summary>
        private void SetMenuItems()
        {
            EFMenuItem menuItem1 = new EFMenuItem();
            EFMenuItem menuItem2 = new EFMenuItem();

            menuItem1.Link = "home/gallery";
            menuItem2.Link = "home/blog";

            menuItem1.Name = "Gallery";
            menuItem2.Name = "Blog";

            menuItem1.ItemMenuGroup = new EFMenuGroup();
            menuItem2.ItemMenuGroup = new EFMenuGroup();

            menuItem1.ItemMenuGroup.ControllerName = "Home";
            menuItem2.ItemMenuGroup.ControllerName = "Admin";

            _MenuItems = new List<EFMenuItem>() {
                menuItem1,
                menuItem2
            };
        }

        /// <summary>
        ///A test for MapToModelObject taking a list of EFMenuItems
        ///</summary>
        [TestMethod()]
        public void MapToModelObjectTest_EFMenuItem_List()
        {

            //Arrange -  done in initialisation

            //Act
            List<MenuItem> actual;
            actual = LayoutRepositoryMapper.MapToModelObject(_MenuItems).ToList();

            //Assert
            Assert.AreEqual(actual.Count, 2);
            MenuItem menuItem = actual.First();
            Assert.AreEqual(menuItem.Action, "home/gallery");
            Assert.AreEqual(menuItem.Controller, "Home");
            Assert.AreEqual(menuItem.Title, "Gallery");

        }

        /// <summary>
        ///A test for MapToModelObject for a single EF MenuItem
        ///</summary>
        [TestMethod()]
        public void MapToModelObjectTest_EFMenuItem()
        {
            //Arrange -  done in initialisation

            //Act
            MenuItem actual;
            actual = LayoutRepositoryMapper.MapToModelObject(_MenuItems.First());

            //Assert
            Assert.AreEqual(actual.Action, "home/gallery");
            Assert.AreEqual(actual.Controller, "Home");
            Assert.AreEqual(actual.Title, "Gallery");
        }

        /// <summary>
        ///A test for MapToModelObject for a list of EFSubMenuItems
        ///</summary>
        [TestMethod()]
        public void MapToModelObjectTest_EFSubMenuItem_List()
        {
            //Arrange -  done in initialisation

            //Act
            List<MenuItem> actual;
            actual = LayoutRepositoryMapper.MapToModelObject(_SubMenuItems).ToList();

            //Assert
            Assert.AreEqual(actual.Count, 2);
            MenuItem menuItem = actual.First();
            Assert.AreEqual(menuItem.Action, "home/images");
            Assert.AreEqual(menuItem.Title, "Images");
        }

        /// <summary>
        ///A test for MapToModelObject to map a single EFSubMenuItem
        ///</summary>
        [TestMethod()]
        public void MapToModelObjectTest_EFSubMenuItem()
        {
            //Arrange -  done in initialisation

            //Act
            MenuItem actual;
            actual = LayoutRepositoryMapper.MapToModelObject(_SubMenuItems.First());

            //Assert
            Assert.AreEqual(actual.Action, "home/images");
            Assert.AreEqual(actual.Title, "Images");
        }
    }
}
