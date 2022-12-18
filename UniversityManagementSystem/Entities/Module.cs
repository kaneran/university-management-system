using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.ValueObjects;

namespace UniversityManagementSystem.Entities
{
    public class Module
    {
        public ModuleId Id { get; set; }
        public string Title { get; set; }
        public Module(ModuleId Id, string title)
        {
            this.Id = Id;
            Title = title;
        }
    }
}
