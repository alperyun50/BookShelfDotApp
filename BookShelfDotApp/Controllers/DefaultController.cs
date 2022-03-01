using BookShelfDotApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelfDotApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var bk = new List<Books>()
                {
                   new Books() {Id=1, BookName="Pürdikkat", Author="Cal Newport" },
                   new Books() {Id=2, BookName="Cesur yeni dünya", Author="Aldous Huxley"},
                   new Books() {Id=3, BookName="Ben robot", Author="Isaac Asimov"},
                   new Books() {Id=4, BookName="Homo ludens", Author="Johan Huizinga"},
                   new Books() {Id=5, BookName="Sistem", Author="James Ball"}
                };
            
            return View(bk);
        }
    }
}
