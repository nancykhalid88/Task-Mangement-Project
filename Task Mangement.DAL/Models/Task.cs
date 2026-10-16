using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Mangement.DAL.Models.Enums;

namespace Task_Mangement.DAL.Models
{
    public class Task:BaseEntity
    {
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public DateTime? DueDate { get; set; }
        public Project Project { get; set; } = null!;
        public int ProjectId { get; set; }
    }
}
