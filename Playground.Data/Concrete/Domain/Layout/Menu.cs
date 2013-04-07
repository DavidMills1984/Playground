using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Playground.Model.Interfaces;
using Playground.Data.EntityModels;

namespace Playground.Data.Concrete
{
    public class Menu : IMenu
    {
        public List<IMenuItem> Items { get; set; }

        public Menu()
        {
            this.Items = new List<IMenuItem>();

            using (PlaygroundEntities db = new PlaygroundEntities())
            {
                var entityItems = db.MenuItems.ToList();

                entityItems.ForEach(x => this.Items.Add(new MenuItem() { 
                    Reference = x.Link, 
                    Title = x.Name, 
                    SubItems = GetSubItems(x.Id) 
                }));
            }

        }

        private List<IMenuItem> GetSubItems(int Id)
        {
            List<IMenuItem> returnList = new List<IMenuItem>();

            using (PlaygroundEntities db = new PlaygroundEntities())
            {
                var entityItems = db.MenuSubItems.Where(x => x.ParentId == Id).ToList();

                entityItems.ForEach(x => returnList.Add(new MenuItem()
                {
                    Reference = x.Link,
                    Title = x.Name
                }));
            }

            return returnList;
        }
    }
}
