using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ProjectManager
{
    static class TaskControlManager
    {
        /// <summary>
        /// List of task items
        /// </summary>
        static List<ListProjectItemControl> listProjectControls = new List<ListProjectItemControl>();

        /// <summary>
        /// Method to add new item to list
        /// </summary>
        /// <param name="_taskModel"></param>
        /// <returns></returns>
        public static ListProjectItemControl AddNewControl(TaskModel _taskModel)
        {
            ListProjectItemControl listProjectItemControl = new ListProjectItemControl(_taskModel);
            listProjectControls.Add(listProjectItemControl);
            ShowAtNewLocation(listProjectItemControl);
            return listProjectItemControl;
        }

        /// <summary>
        /// Method to show new List Item
        /// </summary>
        /// <param name="_listProjectItemControl"></param>
        private static void ShowAtNewLocation(ListProjectItemControl _listProjectItemControl)
        {
            (ContentManager.GetControl(TaskControlsList.SideBarList) as ListProjectControl).Controls.Add(_listProjectItemControl);
            _listProjectItemControl.Location = new Point(0,_listProjectItemControl.Height * listProjectControls.Count);
        }
    }
}
