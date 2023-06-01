using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Model
{
    public class Person
    {
        public string name_ { get; set; }
        public int age_ { get; set; }


        public Person(string n, int a)
        {
            name_ = n;
            age_ = a;
        }
        public override string ToString()
        {
            return $"Name: {name_}\n Age: {age_}";
        }
    }
}
