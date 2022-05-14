using System;
using System.Data;
using System.Data.SqlClient;

namespace App20210728
{
    class Program
    {
        static void Main(string[] args)
        {
            string cnnstr = @"Data Source=DESKTOP-FI4HSGV\MANSURSQL;Initial Catalog=TEST_17072021;Integrated Security=True";
            using (SqlConnection _con = new SqlConnection(cnnstr))
            {
                string choice;
                do
                {
                    Console.WriteLine("01- Add new Country");
                    Console.WriteLine("02- Delete Country");
                    Console.WriteLine("03- List All Countries");
                    Console.WriteLine("11- Add new Customer");
                    Console.WriteLine("12- Update Customer Name");
                    Console.WriteLine("13- Delete Customer");
                    Console.WriteLine("14- List All Customers");
                    Console.WriteLine("00- Exit");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("");
                    choice = Console.ReadLine();

                    if(choice == "14")
                    {
                        BLC.BLC.GetData(_con);
                    }else if(choice == "01")
                    {
                        BLC.BLC.InsertCountry(_con);
                    }else if (choice == "03")
                    {
                        BLC.BLC.GetCountries(_con);
                    }else if (choice == "02")
                    {
                        BLC.BLC.deleteCountry(_con);
                    }else if (choice == "11")
                    {
                        BLC.BLC.InsertCustomer(_con);
                    }else if (choice == "12")
                    {
                        BLC.BLC.updateCustomer(_con);
                    }else if (choice == "13")
                    {
                        BLC.BLC.deleteCustomer(_con);
                    }else
                    {
                        Console.WriteLine("enter a valid choice"); 
                        Console.WriteLine("");
                    }
                } while (choice != "00");
                
                
                
                
               

            } // <-- At this point we are sure that the connection will be closed & cleared from memory
        }

        
    }
}
