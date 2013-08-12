using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Interfaces;
using Playground.Model.Concrete;

namespace Playground.Service
{
    public class LayoutService : ILayoutService
    {
        private ILayoutRepository _LayoutRepository;
        
        /// <summary>
        /// A contructor method that instatiates an object of type LayoutService
        /// </summary>
        /// <param name="layoutRepository"></param>
        public LayoutService(ILayoutRepository layoutRepository)
        {
            _LayoutRepository = layoutRepository;
        }

        /// <summary>
        /// A emthod to retrieve all the menu items for a given menu type and format them as
        /// a new Menu object
        /// </summary>
        /// <param name="menuType"></param>
        /// <returns>A menu object</returns>
        public Menu GetMenu(string menuType)
        {
            return new Menu() {
                Items = _LayoutRepository.GetMenuData(menuType)
            };
        }

    }
}
