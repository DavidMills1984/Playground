using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Concrete;
using Playground.Data.EntityModels;


namespace Playground.Data.Mappers
{
    public static class LayoutRepositoryMapper
    {
        /// <summary>
        /// A method that converts a list of MenuItem entity framework objects into 
        /// business objects used in the system
        /// </summary>
        /// <param name="menuItems"></param>
        /// <returns>An enumerable containing MenuItems</returns>
        public static IEnumerable<MenuItem> MapToModelObject(this IEnumerable<EFMenuItem> menuItems)
        {
            return menuItems.Select(x => x.MapToModelObject()).ToList();
        }

        /// <summary>
        /// A method that converts a MenuItem entity framework objects into 
        /// a business object used in the system
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns>An MenuItem object</returns>
        public static MenuItem MapToModelObject(this EFMenuItem menuItem)
        {
            return new MenuItem()
            {
                Action = menuItem.Link,
                Controller = menuItem.ItemMenuGroup.ControllerName,
                Title = menuItem.Name,
                SubItems = menuItem.MenuSubItems.MapToModelObject().ToList()
            };

        }

        /// <summary>
        /// A method that converts a list of EFMenuSubItem entity framework objects into 
        /// business objects used in the system
        /// </summary>
        /// <param name="menuItems"></param>
        /// <returns>An enumerable containing MenuItem</returns>
        public static IEnumerable<MenuItem> MapToModelObject(this IEnumerable<EFMenuSubItem> menuItems)
        {
            return menuItems.Select(x => x.MapToModelObject()).ToList();
        }

        /// <summary>
        /// A method that converts a EFMenuSubItem entity framework object into 
        /// a business object used in the system
        /// </summary>
        /// <param name="menuItem"></param>
        /// <returns>An MenuItem object</returns>
        public static MenuItem MapToModelObject(this EFMenuSubItem menuItem)
        {
            return new MenuItem()
            {
                Action = menuItem.Link,
                Controller = "",
                Title = menuItem.Name,
                SubItems = new List<MenuItem>()
            };
        }
    }
}
