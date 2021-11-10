using Manufactures.Business;
using Manufactures.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufactures.Presentation
{
    public class Display
    {
        private int closeOperationId = 6;
        private ProductBusiness productBusiness = new ProductBusiness();

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new manufacturer");
            Console.WriteLine("3. Add new model");
            Console.WriteLine("4. Update manufacturer");
            Console.WriteLine("5. Update model");
            Console.WriteLine("6. Fetch models by ID");
            Console.WriteLine("7. Fetch manufacturer by ID");
            Console.WriteLine("8. Delete model by ID");
            Console.WriteLine("9. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        AddManufacturer();
                        break;
                    case 2:
                        UpdateManufacturer();
                        break;
                    case 3:
                        UpdateModel();
                        break;
                    case 4:
                        DeleteModel();
                        break;
                    default:
                        break;

                }
            } while (operation != closeOperationId);
        }

        public Display()
        {
            Input();
        }
        private void DeleteModel()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            productBusiness.Delete(id);
            Console.WriteLine("Done.");
        }


        private void UpdateManufacturer()
        {
            Manufacturer manufacturer = new Manufacturer();
            Console.WriteLine("Enter ID to update: ");
            int manufacturerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name to update: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter country to update: ");
            string country = Console.ReadLine();
            productBusiness.UpdateManufacturer(manufacturer);
        }

        private void UpdateModel()
        {
            Model model= new Model();
            Console.WriteLine("Enter ID to update: ");
            int manufacturerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name to update: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter year to update: ");
            int year = int.Parse(Console.ReadLine());
            productBusiness.UpdateModel(model);
        }


        private void AddManufacturer()
        {
            Manufacturer manufacturer = new Manufacturer();
            Model model = new Model();
            Console.WriteLine("Enter Id: ");
            manufacturer.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            manufacturer.Name = Console.ReadLine();
            Console.WriteLine("Enter country: ");
            manufacturer.Country = Console.ReadLine();
            Console.WriteLine("Enter model: ");
            model.Name = Console.ReadLine();
            productBusiness.AddManufacturer(manufacturer, model);
        }
    }
}
