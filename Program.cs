/* code made when I was studying Object Oriented Programming, in udemy.com
   URL of the course: https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/
   so, it's based on professor Nelio Alves's material
 */

using Exerc3_Enum_Comp.Entities;
using Exerc3_Enum_Comp.Entities.Enums;
using System;

namespace Exerc3_Enum_Comp
{
    class Program
    {
        static void Main(string[] args)
        {
            // recieving client data
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            // recieving order data
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            // objects that will be used
            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            // for used to get product's data and instantiating the objects that will be used to show the information after (using ToString() )
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.Write(order);
        }
    }
}
