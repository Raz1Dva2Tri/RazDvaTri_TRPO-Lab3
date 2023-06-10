using Microsoft.AspNetCore.Mvc;
using RazDvaTri_TRPO_Lab3.ASP.Models;

namespace RazDvaTri_TRPO_Lab3.ASP.Controllers
{

    public class TriangleController : Controller
   {
       public ActionResult Index()
       {
           return View(new Triangle_Model());
       }

        [HttpPost]
        public ActionResult UpdateTriangle(Triangle_Model model)
        {
            if (ModelState.IsValid)
            {
                // проверка допустимости длин сторон треугольника
                if (model.TryLength())
               {
                        ViewBag.TriangleData = CalculateTriangleCoordinates(model);
                    }
               else
                    {
                        ModelState.AddModelError("", "Ошибка в ведение длин");
                    ViewBag.TriangleData = "Ошибка в ведение длин";
                    }
               }


           return View("Index", model);
            }
        
       private string CalculateTriangleCoordinates(Triangle_Model model)
       {
           
           string coordinates = $"Площадь треугольника {model.S}";
           return coordinates;
       }
   }
}
