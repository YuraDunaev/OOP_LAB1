using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OOP_LAB1.Models;

namespace OOP_LAB1.Pages
{
    public class IndexModel : PageModel
    {
        private FigureList _figureList;
        private readonly ILogger<IndexModel> _logger;
        public List<Figure> figures;
        public IndexModel(ILogger<IndexModel> logger, FigureList figureList)
        {
            _logger = logger;
            _figureList = figureList;
        }
        public void OnGet()
        {
        }
    }
}