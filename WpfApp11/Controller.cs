using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp11.Model;

namespace WpfApp11
{
    public class Controller
    {
        DataBase database_ = new DataBase();

        // Add Person To Data Base
        public void AddPerson(string name, int age)
        {
            database_.Add(new Person(name, age));
        }
        // Get All Persons From Data Base
        public List<Person> GetAllPerson()
        {
            return database_.GetPeople();
        }
        // Remove Person From Data Base
        public void DeletePerson(Person a)
        {
            database_.DeletePerson(a);
        }
        // Find Person In Data Base
        public List<Person> FindPerson(string n)
        {
            return database_.FindPerson(n);
        }
    }
}
