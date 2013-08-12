using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Interfaces;
using Playground.Model.Concrete;
using Playground.Data.EntityModels;
using Playground.Data.Mappers;


namespace Playground.Data.Concrete
{
    public class LayoutRepository : ILayoutRepository
    {
        private PlaygroundEntities _LayoutRepository;

        public LayoutRepository()
        {
            _LayoutRepository = new PlaygroundEntities();
        }

        public List<MenuItem> GetMenuData(string menuGroup)
        {
            List<MenuItem> items = new List<MenuItem>();

            using (_LayoutRepository = new PlaygroundEntities())
            {
                var entityItems = _LayoutRepository.EFMenuItems.Where(x => x.ItemMenuGroup.GroupName == menuGroup).ToList();
                items = entityItems.MapToModelObject().ToList();
            }

            return items;
        }
    }
}
