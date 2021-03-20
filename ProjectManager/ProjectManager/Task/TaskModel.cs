using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public  class TaskModel
    {
        public Guid Id { get; private set; }

        public string Title{ get; private set; }

        public string Description { get; private set; }

        public string Icon { get; private set; }

        public TaskModel(string _Title, string _Description,string _Icon)
        {
            Title = _Title;
            Description = _Description;
            Icon = _Icon;
        }
    }
}
