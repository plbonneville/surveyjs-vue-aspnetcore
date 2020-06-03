using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SurveyJS_Vue_RazorPages.Pages
{
    [ValidateAntiForgeryToken]
    public class SurveyModel : PageModel
    {
        public void OnGet()
        {

        }
        
        public IActionResult OnPost([FromBody]PostSurveyResultModel model)
        {
            return new JsonResult(new { Id = 123 });
        }

        public class PostSurveyResultModel
        {
            // TODO: Add other properties here...
            public string Suggestions { get; set; }
        }
    }
}