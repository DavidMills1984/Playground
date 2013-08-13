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
        public List<MenuItem> GetMenuData(string menuGroup)
        {
            List<MenuItem> items = new List<MenuItem>();

            using (PlaygroundEntities db = new PlaygroundEntities())
            {
                var entityItems = db.EFMenuItems.Where(x => x.ItemMenuGroup.GroupName == menuGroup).ToList();
                items = entityItems.MapToModelObject().ToList();
            }

            return items;
        }
    }
}
