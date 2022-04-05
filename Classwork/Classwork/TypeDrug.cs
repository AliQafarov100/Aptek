using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork
{
    class TypeDrug
    {
        public int Id { get; }
        public static int Count;
        public string TypeName { get; set; }

        public TypeDrug()
        {
            Id = ++Count;
        }


        public override string ToString()
        {
            return TypeName;
        }
    }
}
