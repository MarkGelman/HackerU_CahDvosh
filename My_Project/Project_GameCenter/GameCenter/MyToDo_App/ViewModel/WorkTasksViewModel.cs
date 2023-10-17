using MyToDo_App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo_App.ViewModel
{
    internal class WorkTasksViewModel
    {
        public ObservableCollection<WorkTaskModel>TasksList = new ObservableCollection<WorkTaskModel>();
        public string NewTitle;
        public string NewDescription;

        public WorkTasksViewModel()
        {
            
        }

        public void AddNewTask()
        {
            WorkTaskModel newTask = new WorkTaskModel
            {
                title = NewTitle,
                description = NewDescription,
                date = DateTime.Now
            };

            TasksList.Add(newTask);

            NewTitle = String.Empty; 
            NewDescription = String.Empty;
        }
    }
}
