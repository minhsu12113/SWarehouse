using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Utilitys
{
    public class CustomAttribute : Attribute
    {
        public CustomAttribute(string tag) => Tag = tag;
        public String Tag { get; set; }
    }
}
