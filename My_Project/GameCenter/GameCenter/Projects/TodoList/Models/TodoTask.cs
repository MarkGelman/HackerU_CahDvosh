using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter.Projects.TodoList.Models
{
    class TodoTask
    {
        //properties: Id, Description, CreatedDate, IsComplete
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsComplete { get; set;}

        //Constructor (.....)
        public TodoTask (int id, string desctiption)
        {
            Id = id;
            Description = desctiption;
            CreatedDate = DateTime.Now;
            IsComplete = false;
            
        }
    }
}
