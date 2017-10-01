using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorDemo.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public Contact Contact { get; set; }

        public void OnGet()
        
        {
            Message = "Your contact page.";
            Message += "...www";
        }

        public ActionResult OnPost() {
            return RedirectToPage();
        }
    }

    public class Contact {
        public string Name { get;set; }
        public string Email { get; set; }
    }
}
