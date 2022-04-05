using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class Drug
    {
        public int Id { get; }
        public string Name { get; set; }
        public TypeDrug Type { get; set; }

        public int Count { get; set; }
        public double Price { get; set; }

        public static int Counter;


        public Drug()
        {
            Id = ++Counter;
        }

        public override string ToString()
        {
            return $"Id :{Id} | Name: {Name} | Price: {Price} | Count: {Count}";
        }


    }
}
