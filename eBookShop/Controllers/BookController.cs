﻿using eBookShop.Models.Domain;
using eBookShop.Repositories.Abstract;
using eBookShop.Repositories.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace eBookShop.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService bookService;
        private readonly IAuthorService authorService;
        private readonly IGenreService genreService;
        private readonly IPublisherService publisherService;

        public BookController(IBookService bookService, IGenreService genreService, IPublisherService publisherService, IAuthorService authorService)
        {
            this.bookService = bookService;
            this.authorService = authorService;
            this.genreService = genreService;
            this.publisherService = publisherService;
        }
        public IActionResult Add()
        {
            var model = new Book();
            model.AuthorList = authorService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {  Text = a.AuthorName, Value = a.Id.ToString()}).ToList();
            model.PublisherList = publisherService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {  Text = a.PublisherName, Value = a.Id.ToString()}).ToList();
            model.GenreList = genreService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {  Text = a.Name, Value = a.Id.ToString()}).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Book model)
        {
            model.AuthorList = authorService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = a.AuthorName, Value = a.Id.ToString(), Selected = a.Id == model.AuthorId}).ToList();
            model.PublisherList = publisherService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = a.PublisherName, Value = a.Id.ToString(), Selected = a.Id == model.PublisherId }).ToList();
            model.GenreList = genreService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = a.Name, Value = a.Id.ToString(), Selected = a.Id == model.GenreId}).ToList();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = bookService.Add(model);
            if (result)
            {
                TempData["msg"] = "Added Successfully";
                return RedirectToAction(nameof(Add));
            }
            TempData["msg"] = "Error has occured on server side";
            return View(model);
        }

        public IActionResult Update(int id)
        {
            var model = bookService.FindById(id);
            model.AuthorList = authorService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = a.AuthorName, Value = a.Id.ToString(), Selected = a.Id == model.AuthorId }).ToList();
            model.PublisherList = publisherService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = a.PublisherName, Value = a.Id.ToString(), Selected = a.Id == model.PublisherId }).ToList();
            model.GenreList = genreService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = a.Name, Value = a.Id.ToString(), Selected = a.Id == model.GenreId }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Book model)
        {
            model.AuthorList = authorService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = a.AuthorName, Value = a.Id.ToString(), Selected = a.Id == model.AuthorId }).ToList();
            model.PublisherList = publisherService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = a.PublisherName, Value = a.Id.ToString(), Selected = a.Id == model.PublisherId }).ToList();
            model.GenreList = genreService.GetAll().Select(a => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = a.Name, Value = a.Id.ToString(), Selected = a.Id == model.GenreId }).ToList();
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var result = bookService.Update(model);
            if (result)
            {
                return RedirectToAction("GetAll");
            }
            TempData["msg"] = "Error has occured on server side";
            return View(model);
        }

        public IActionResult Delete(int id)
        {

            var result = bookService.Delete(id);
            return RedirectToAction("GetAll");
        }

        public IActionResult GetAll()
        {
            var data = bookService.GetAll();
            return View(data);
        }
    }
}
