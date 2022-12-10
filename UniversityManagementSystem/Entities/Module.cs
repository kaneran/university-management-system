using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Entities
{
    public class Module
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Module(int Id, string title)
        {
            this.Id = Id;
            Title = title;
        }
    }
}
