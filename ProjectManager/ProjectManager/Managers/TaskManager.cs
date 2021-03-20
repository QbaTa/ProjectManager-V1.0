using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    static class TaskManager
    {
        /// <summary>
        /// Task List
        /// </summary>
        static List<TaskModel> tasks = new List<TaskModel>();

        /// <summary>
        /// Property to get the task count
        /// </summary>
        public static int GetCount { get => tasks.Count(); }

        /// <summary>
        /// Method to add new task
        /// </summary>
        /// <param name="_Title"> Task title </param>
        /// <param name="_Description"> Task Description </param>
        /// <param name="_Icon"> Task icon </param>
        public static TaskModel AddNewTask (string _Title, string _Description,string _Icon)
        {
            TaskModel taskModel = new TaskModel(_Title, _Description, _Icon);
            tasks.Add(taskModel);
            return taskModel;
        }

        /// <summary>
        /// Method to remove task from list
        /// </summary>
        /// <param name="_index"></param>
        /// <returns></returns>
        public static TaskModel RemoveTask(int _index)
        {
            TaskModel taskToRemove = GetTask(_index);
            tasks.RemoveAt(_index);
            return taskToRemove;
        }

        /// <summary>
        /// Method  to get task from list
        /// </summary>
        /// <param name="_index"> index of a task in list </param>
        /// <returns> task in index _index </returns>
        public static TaskModel GetTask(int _index)
        {
            if (GetCount == 0)
                return null;
            return tasks[_index];
        }
    }
}
