using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Mangement.DAL.Models
{
    public class Project:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public int OwnerId { get; set; }
        public ICollection<Tasks> Tasks { get; set; } = new List<Tasks>();
    }
}
