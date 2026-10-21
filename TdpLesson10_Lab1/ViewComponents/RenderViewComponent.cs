using Microsoft.AspNetCore.Mvc;
using TdpLesson10_Lab1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TdpLesson10_Lab1.ViewComponents
{
    public class RenderViewComponent : ViewComponent
    {
        private List<MenuItem> MenuItems = new List<MenuItem>();

        public RenderViewComponent()
        {
            // Giả lập danh sách các mục menu
            MenuItems = new List<MenuItem>()
            {
                new MenuItem() { Id = 1, Name = "Branches", Link = "Branches/List" },
                new MenuItem() { Id = 2, Name = "Students", Link = "Students/List" },
                new MenuItem() { Id = 3, Name = "Subjects", Link = "Subjects/List" },
                new MenuItem() { Id = 4, Name = "Courses", Link = "Courses/List" }
            };
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Trả về View "RenderLeftMenu" kèm theo dữ liệu MenuItems
            return View("RenderLeftMenu", MenuItems);
        }
    }
}