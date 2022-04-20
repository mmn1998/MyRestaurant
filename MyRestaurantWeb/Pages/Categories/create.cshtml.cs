using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyRestaurantWeb.Model;

namespace MyRestaurantWeb.Pages.Categories
{
    public class createModel : PageModel
    {
        public Category Category { get; set; }
        public void OnGet()
        {
        }
    }
}
