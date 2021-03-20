using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    static class PageValueConverter
    {

        /// <summary>
        /// Converter to convert PagesList value to control
        /// </summary>
        /// <param name="_page"> page to convert </param>
        /// <returns> new control or null </returns>
        public static IContentControl Convert(PagesList _page)
        {
            switch(_page)
            {
                case PagesList.LoginPage:
                    return new LoginControl();
                case PagesList.MainPage:
                    return new MainPage();
                default:
                    return null;
            }
        }
        /// <summary>
        /// Converter to convert PagesList value to control
        /// </summary>
        /// <param name="_page"> page to convert </param>
        /// <returns> new control or null </returns>
        public static IContentControl Convert(TaskControlsList _control)
        {
            switch (_control)
            {
                case TaskControlsList.CreateEditTaskControl:
                    return new CreateAndEditTaskControl();
                case TaskControlsList.SideBarList:
                    return new ListProjectControl();
                default:
                    return null;
            }
        }
    }
}
