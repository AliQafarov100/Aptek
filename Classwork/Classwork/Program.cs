using System;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Drug drug = new Drug();
            Console.WriteLine("Enter name drug: ");
            drug.Name = Console.ReadLine();
            Console.WriteLine("Enter count drug: ");
            drug.Count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price count: ");
            drug.Price = double.Parse(Console.ReadLine());


            Drug drug1 = new Drug();
            Console.WriteLine("Enter name drug: ");
            drug1.Name = Console.ReadLine();
            Console.WriteLine("Enter count drug: ");
            drug1.Count = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter price count: ");
            drug1.Price = double.Parse(Console.ReadLine());

            Pharmacy pharmacy = new Pharmacy();
            Console.WriteLine("Enter money: ");
            double money = double.Parse(Console.ReadLine());
            Console.WriteLine("Specify name of drug: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter count drug which you retrieve: ");
            int count = int.Parse(Console.ReadLine());



            pharmacy.AddDrug(drug);
            pharmacy.AddDrug(drug1);
            pharmacy.SaleDrug(name, count, money);
            

            foreach (var item in pharmacy.drugs)
            {
                


                //if (money > item.Price)
                //{
                //    while (money > item.Price)
                //    {
                //        Console.WriteLine("Would you buy anything?");
                //        char choose = char.Parse(Console.ReadLine());

                //        if (choose == 'y')
                //        {
                //            Console.WriteLine("Specify name of drug: ");
                //            string name1 = Console.ReadLine();
                //            Console.WriteLine("Enter count drug which you retrieve: ");
                //            int count1 = int.Parse(Console.ReadLine());
                //            money -= count1 * item.Price;
                //            pharmacy.SaleDrug(name1, count1, money);
                //        }
                //        else if (choose == 'n')
                //        {
                //            Console.WriteLine("Thank you for purchase!");
                //        }
                //    }

                //}
            }

        }

    }
}
