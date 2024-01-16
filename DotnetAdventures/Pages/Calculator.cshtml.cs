using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetAdventures.Pages
{
    public class CalculatorModel : PageModel
    {
        public double? Number1 { get; set; }
        public double? Number2 { get; set; }
        public string Operation { get; set; }
        public double Result { get; set; }

        public void OnPost()
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
                    // TODO handle divide by zero`
                    break;
            }
        }
    }
}