using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    static class ContentManager
    {
        static Dictionary<PagesList, IContentControl> Pages = new Dictionary<PagesList, IContentControl>();
        static Dictionary<TaskControlsList, IContentControl> Controls = new Dictionary<TaskControlsList, IContentControl>();


        /// <summary>
        /// Property for currentPage
        /// </summary>
        static PagesList currentPage;

        /// <summary>
        /// Property for currentControl
        /// </summary>
        static TaskControlsList currentControl;

        /// <summary>
        /// Property for currentPage
        /// </summary>
        public static PagesList CurrentPage
        {
            get => currentPage;        
            set => currentPage = value;
        }

        /// <summary>
        /// Property for currentControl
        /// </summary>
        public static TaskControlsList CurrentControl
        {
            get => currentControl;
            set => currentControl = value;
        }

        /// <summary>
        /// Method to show selected page
        /// </summary>
        /// <param name="_pageToShow"> page to show </param>
        public static void Show(PagesList _pageToShow)
        {
            Pages[_pageToShow].Pokaz();
            currentPage = _pageToShow;
        }

        /// <summary>
        /// Method to show selected control
        /// </summary>
        /// <param name="_controlToShow"> control to show </param>
        public static void Show(TaskControlsList _controlToShow)
        {
            Controls[_controlToShow].Pokaz();
            currentControl = _controlToShow;
        }

        /// <summary>
        /// Method to hide current page
        /// </summary>
        public static void HidePage()
        {
            Pages[currentPage].Ukryj();
        }

        /// <summary>
        /// Method to hide currentControl
        /// </summary>
        public static void HideControl()
        {
            Controls[currentControl].Ukryj();
        }

        /// <summary>
        /// Method to add new Page to dictionary
        /// </summary>
        /// <param name="_NewPage"> page to add </param>
        /// <returns></returns>
        public static IContentControl AddNewPage(PagesList _NewPage)
        {
            Pages.Add(_NewPage, PageValueConverter.Convert(_NewPage));
            return Pages[_NewPage];
        }

        /// <summary>
        /// Method to add new Control to dictionary
        /// </summary>
        /// <param name="_NewControl"> control to add </param>
        /// <returns></returns>
        public static IContentControl AddNewControl(TaskControlsList _NewControl)
        {
            Controls.Add(_NewControl, PageValueConverter.Convert(_NewControl));
            return Controls[_NewControl];
        }

        /// <summary>
        /// Method to return selected page
        /// </summary>
        /// <param name="_pageToGet"> page to get </param>
        /// <returns> selected page </returns>
        public static IContentControl GetPage(PagesList _pageToGet)
        {
            return Pages[_pageToGet];
        }

        public static IContentControl GetControl(TaskControlsList _controlToGet)
        {
            return Controls[_controlToGet];
        }
    }
}
