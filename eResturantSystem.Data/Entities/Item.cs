using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Adittional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace eRestaurantSystem.Data.Entities
{
    [Table("Items")]
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string Description { get; set; }
        public double CurrentPrice { get; set; }
        public double CurrentCost { get; set; }
        public Boolean Active { get; set; }
        public int Calories { get; set; }
        public string Comment { get; set; }
        [ForeignKey("MenuCategories")]
        public int MenuCategoryID { get; set; }

        //public virtual 
    }
}
