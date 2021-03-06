﻿using ComicBooksGallary.Data;
using ComicBooksGallary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBooksGallary.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;
        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }
        public ActionResult index()
        {
            var comicBooks = _comicBookRepository.GetComicBook();
            return View(comicBooks);
        }

            public ActionResult Detail(int? id)
            {
            if (id==null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id);
            return View(comicBook);             
            }
    }
}