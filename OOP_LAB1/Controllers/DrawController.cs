using Microsoft.AspNetCore.Mvc;
using OOP_LAB1.Models;
using OOP_LAB1.Pages;

namespace OOP_LAB1.Controllers
{
    public class DrawController : Controller
    {
        private FigureList _figureList;
        public List<Figure> figures;
        public DrawController(FigureList figureList)
        {
            _figureList = figureList;
        }
        public IActionResult Index()
        {
            return View();
        }
        public List<Figure> GetFigures()
        {
            _figureList.Init();
            figures = _figureList.Figures;
            return figures;
        }
    }
}
