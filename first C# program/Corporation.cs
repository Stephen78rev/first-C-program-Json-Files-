using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace first_C__program
{

    public class Corporation
    {
        public List<Person> People { get; set; } = [];
        // public List<Person> PeopleData { get; set; } = [];

    }
    public class Person
    {
        private string? _name;
        public int Id { get; set; }
        public int Salary { get; set; }
        public string? Name { get => _name; set => _name = value; }
    }
   
}