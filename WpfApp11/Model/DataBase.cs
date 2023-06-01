using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Model
{
    class DataBase
    {
        List<Person> people_;
        public DataBase()
        {
            people_ = new List<Person>();
        }
        // Add Person To Data Base
        public void Add(Person obj)
        {
            people_.Add(obj);
        }
        // Get All Persons in Data Base
        public List<Person> GetPeople()
        {
            return people_;
        }
        // Remove Person 
        public void DeletePerson(Person obj)
        {
            people_.Remove(obj);
        }
        // Find Persons In Data Base 
        public List<Person> FindPerson(string n)
        {
            List<Person> newPeople = new List<Person>();
            foreach (var item in people_)
            {
                if (item.name_ == n)
                {
                    newPeople.Add(item);
                }
            }
            return newPeople;
        }
    }
}
