using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel;
using eRestaurantSystem.DAL;
using eRestaurantSystem.Data.Entities;
using eRestaurantSystem.Data.DTO;
using eRestaurantSystem.Data.POCOs;
#endregion

namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class ItemsController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<MenuCategoryFoodItemsDTO> MenuCategoryFoodItemsDTO_Get()
        {
            using (var context = new eResturantContext())
            {
                var results = from food in context.Items
                              group food by new { food.MenuCategory.Description } into tempdataset
                              select new MenuCategoryFoodItemsDTO
                              {
                                  MenuCategoryDescription = tempdataset.Key.Description
                                  ,
                                  FoodItems = (     from a in tempdataset
                                                    select new FoodItemCounts
                                                    {
                                                            ItemID = a.ItemID
                                                        , FoodDescription = a.Description
                                                        , CurrentPrice = a.CurrentPrice
                                                        , TimesServed = a.BillItems.Count()
                                                    }
                                              ).ToList()
                              };

                return results.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<MenuCategoryFoodItems> MenuCategoryFoodItems_Get()
        {
            using (var context = new eResturantContext())
            {
                var results = from food in context.Items
                              orderby food.MenuCategory.Description
                              select new MenuCategoryFoodItems
                              {
                                  MenuCategoryDescription = food.MenuCategory.Description
                                  , ItemID = food.ItemID
                                  , FoodDescription = food.Description
                                  , CurrentPrice = food.CurrentPrice
                                  , TimesServed = food.BillItems.Count()
                              };


                return results.ToList();
            }
        }
    }
}
