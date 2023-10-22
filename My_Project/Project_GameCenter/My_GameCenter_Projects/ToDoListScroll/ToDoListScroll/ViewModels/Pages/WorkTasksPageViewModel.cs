using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoListScroll.Helper;
using ToDoListScroll.ViewModels.BaseForPropertyChanged;
using ToDoListScroll.ViewModels.Controls;


namespace ToDoListScroll.ViewModels.Pages
{
    internal class WorkTasksPageViewModel: ForPropertyChanged
    {
        public ObservableCollection<WorkTasksViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTasksViewModel>();

        public string NewWorkTaskTitle {  get; set; }

        public string NewWorkTaskDescription { get; set; }  
        
        public ICommand AddNewTaskCommand { get; set; }

        public ICommand DeleteSelectedTasksCommand { get; set; }

        public WorkTasksPageViewModel()
        {
            AddNewTaskCommand = new CommandButtonConverter(AddNewTask);
            DeleteSelectedTasksCommand = new CommandButtonConverter(DeleteSelectedTasks);
        }

        private void AddNewTask() 
        {
            var newTask = new WorkTasksViewModel
            {
                Title = NewWorkTaskTitle,
                Description = NewWorkTaskDescription,
                CreatedDate = DateTime.Now
            };

            WorkTaskList.Add(newTask);

            NewWorkTaskTitle = string.Empty;
            NewWorkTaskDescription = string.Empty;

            ////OnPropertyChanged(nameof(NewWorkTaskTitle));
            ////OnPropertyChanged(nameof(NewWorkTaskDescription));
        }

        private void DeleteSelectedTasks()
        {
            var selectedTasksList = WorkTaskList.Where(x => x.IsSelected).ToList();

            foreach (var task in selectedTasksList)
            {
                WorkTaskList.Remove(task);
            }
        }

    }
}
