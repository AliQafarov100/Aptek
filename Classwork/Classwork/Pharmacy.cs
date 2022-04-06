using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class Pharmacy
    {
        public int Id { get; }
        public string Name { get; set; }

        public  Drug[] drugs = new Drug[0];

        public static int counter;


        public Pharmacy()
        {
            Id = ++counter;
        }

        public void AddDrug(Drug drug)
        {
            Array.Resize(ref drugs, drugs.Length + 1);
            drugs[drugs.Length - 1] = drug;
        }

        public void DrugList()
        {
            foreach(var item in drugs)
            {
                Console.WriteLine(item);
            }
        }

        public void SaleDrug(string name, int count, double money)
        {
            foreach (var item in drugs)
            {
                if (item.Name == name && item.Count > count && item.Price < money)
                {
                    money -= count * item.Price;
                    item.Count -= count;
                    Console.WriteLine(item);
                    Console.WriteLine($"Remaining money: {money}");
                }
                else
                {
                    Console.WriteLine($"product which ID {item.Id} the sale was not carried out!");
                }
                
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} | Id: {Id}";
        }
    }
}
