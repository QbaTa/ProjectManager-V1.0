using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    interface IContentControl
    {
        /// <summary>
        /// Method to show control
        /// </summary>
        void Pokaz();

        /// <summary>
        /// Method to hide control
        /// </summary>
        void Ukryj();
    }
}
