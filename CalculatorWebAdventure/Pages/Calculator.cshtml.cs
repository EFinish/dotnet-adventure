using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculatorWebAdventure.Pages
{
    public class CalculatorModel : PageModel
    {
        [BindProperty]
        public double? Number1 { get; set; }
        [BindProperty]
        public double? Number2 { get; set; }
        [BindProperty]
        public string? Operation { get; set; } = "add";
        [BindProperty]
        public double? Result { get; set; }

        public IActionResult OnPost()
        {
            switch (Operation)
            {
                case "add":
                    Result = Number1.Value + Number2.Value;
                    break;
                case "subtract":
                    Result = Number1.Value - Number2.Value;
                    break;
                case "multiply":
                    Result = Number1.Value * Number2.Value;
                    break;
                case "divide":
                    if (Number2 != 0)
                    {
                        Result = Number1.Value / Number2.Value;
                    }
                    break;
            }

            return Page();
        }
    }
}