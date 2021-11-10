using Manufactures.Data;
using Manufactures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manufactures.Business
{
    public class ProductBusiness
    {
         private ProductContext productContext;
        
        public Manufacturer Get(string name)
        {
            using (productContext = new ProductContext())
            { 
                return productContext.Manufacturers.Find(name); 
            }
        }

        public void AddManufacturer(Manufacturer manufacturer, Model model)
        {
            using (productContext = new ProductContext())
            {
                var categorySearch = productContext.Models.FirstOrDefault(m => m.Name == model.Name);             
                productContext.Models.Add(model);
                productContext.SaveChanges();
                productContext.Manufacturers.Add(manufacturer);
                productContext.SaveChanges();               
            }
        }

       public void UpdateManufacturer(Manufacturer manufacturer)
        { 
            using (productContext = new ProductContext())
            {
                var item = productContext.Manufacturers.Find(manufacturer.Id);
                if (item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(manufacturer);
                   productContext.SaveChanges();
                }

            }
         }

        public void UpdateModel(Model model)
        {
            using (productContext = new ProductContext())
            {
                var item = productContext.Models.Find(model.Id);
                if (item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(model);
                    productContext.SaveChanges();
                }

            }
        }


        public void Delete(int id)
        {
            using (productContext = new ProductContext())
            {
                var model = productContext.Models.Find(id);
                if (model != null)
                {
                    productContext.Models.Remove(model);
                    productContext.SaveChanges();
                }
            }
        }

    }
}
