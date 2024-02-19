using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiPrototype
{
    public class Record
    {
        public string name { get; set; }
        public string category { get; set; }
        public string structure { get; set; }
        public string definition { get; set; }


        public Record (string inputName, string inputCategory, string inputStructure, string inputDefinition)
        {
            name = inputName;
            category = inputCategory;
            structure = inputStructure;
            definition = inputDefinition;
        }

        public string DisplayRecord(Record inputRecord)
        {
            return name + " - " + category + ", " + structure + ", " + definition;
        }


    }
}
