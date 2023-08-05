using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Category.cs
namespace Achtsamkeit.Backend
{
    public class Category
    {
        public string Name { get; set; }
        public List<string> Subcategories { get; set; } = new List<string>();
    }
}

