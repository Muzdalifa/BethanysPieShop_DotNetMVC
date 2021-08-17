using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category
                {
                    CategoryId = 1,
                    CaategoryName="Fruit pies",
                    Description = "All fruits pies"
                },
                new Category{
                    CategoryId = 2,
                    CaategoryName="Cheese cakes",
                    Description = "Cheesy all the way.."
                },
                new Category{
                    CategoryId = 3,
                    CaategoryName="Seosonal pies",
                    Description = "Get in the mood for for a seosonal pies"
                }
            };
    }
}


