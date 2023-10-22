using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListScroll.ViewModels.BaseForPropertyChanged;

namespace ToDoListScroll.ViewModels.Controls
{
    public class WorkTasksViewModel:ForPropertyChanged
    {
        public bool IsSelected {  get; set; }   

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate {  get; set; }
    }
}
