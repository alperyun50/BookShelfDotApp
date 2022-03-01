using BookShelfDotApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelfDotApp.ViewComponents
{
    public class NewBooks : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var bookList = new List<Books>()
            {
                new Books() {Id=6, BookName="Korku", Author="Zweig"},
                new Books() {Id=7, BookName="Anna Karanina", Author="Tolstoy"}
            };

            return View(bookList);
        }
    }
}
