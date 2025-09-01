using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace first_C__program
{
    public class JsonConfig
    {
        private string? _name;
        public int Id { get; set; }
        public int Salery { get; set; }
        public string? Name { get => _name; set => _name = value; }
    }

    public class JsonConfigList
    {
        public List<JsonConfig> People { get; set; } = [];

    }
    public class Data
    {
        private string? _name;

        public int Id { get; set; }
        public string? Name { get => _name; set => _name = value; }
        public int Salery { get; set; }
    }
}
