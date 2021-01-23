using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            CorporateCustomer customer1 = new CorporateCustomer();
            customer1.Id = 1;
            customer1.CompanyName = "SDNR LLC.";
            customer1.CustomerNum = "11111";
            customer1.VergiNum = "1234567890";

            Individual customer2 = new Individual();
            customer2.Id = 1;
            customer2.Name = "Serpil";
            customer2.LastName = "DÖNER";
            customer2.TcNum = "170811554800";


            Customer customer3 = new CorporateCustomer();
            Customer customer4 = new Individual();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Add(customer4);





            //**//Gerçek ve Tüzel kişiler için companyname bilgisi ayrılmalıdır. //**//
            //**//Ancak tipe göre ayırmak da doğru değildir.



        }
    }
}
