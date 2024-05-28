using Microsoft.AspNetCore.Mvc;
using ajax2.Models;
using Microsoft.AspNetCore.Components.Forms.Mapping;

namespace ajax2.Controllers
{
    public class CustomerController : Controller
    {
        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            //Get some data - usually comes form a database

            //In this case we will hard-code the data
            customers = new List<Customer>();
            customers.Add(new Customer(0, "Sherry", 11));
            customers.Add(new Customer(1, "Adam", 12));
            customers.Add(new Customer(2, "Kevin", 19));
            customers.Add(new Customer(3, "Candice", 26));
            customers.Add(new Customer(4, "Name", 36));
            customers.Add(new Customer(5, "Shell", 39));
            customers.Add(new Customer(6, "Sherry 2", 50));
        }

        // GET: Customer 
        public IActionResult Customer(int customerNumber)
        {
            List<string> customers = new List<string>();
            customers.Add("Adam");
            customers.Add("Beatrice");
            customers.Add("Charlie");
            (List<string>, Customer) tulpa = (customers, this.customers[customerNumber]);
                
            return View(tulpa);
        }

        public IActionResult OnSelectCustomer(string Customers)
        {
            int i;
            if (Customers == "Adam")
            {
                i = 1;
            }
            else if(Customers == "Beatrice")
            {
                i = 2;
            }
            else
            {
                i = 3;
            }

            return PartialView("_CustomersDetails", customers[i]);
            //return RedirectToAction("Customer", new { customerNumber = Int32.Parse(customerNumber) });
        }

        public IActionResult Face(string[] color, string[] brand, string[] PurposeFor, string sortOrder)
        {
            //return View(filtercars.ToList());
            return View();
        }
    }
}
