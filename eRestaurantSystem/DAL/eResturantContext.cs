using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region comment to test orion web editor
#endregion
#region Additional Namespaces
using System.Data.Entity;
using eRestaurantSystem.Data.Entities;
#endregion

namespace eRestaurantSystem.DAL
{
    internal class eResturantContext : DbContext
    {
        public eResturantContext() : base("eResturantDB") { }
        public DbSet<Item> Items { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<BillItem> BillItems { get; set; }


    }
    
}
