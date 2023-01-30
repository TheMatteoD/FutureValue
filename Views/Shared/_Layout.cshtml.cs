using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FutureValue.Views.Shared
{
    public class _Layout : PageModel
    {
        private readonly ILogger<_Layout> _logger;

        public _Layout(ILogger<_Layout> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}