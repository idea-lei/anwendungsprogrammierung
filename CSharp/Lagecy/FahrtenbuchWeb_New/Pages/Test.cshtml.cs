using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace FahrtenbuchWeb_New.Pages
{
    public class TestModel : PageModel
    {
        [Required(ErrorMessage = "email is required!")]
        public string Email { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
                OnGet();
            else
            {

            }
        }
    }
}
