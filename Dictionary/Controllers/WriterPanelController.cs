﻿using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dictionary.Controllers
{
    public class WriterPanelController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        // GET: WriterPanel
        public ActionResult WriterProfile()
        {
            return View();
        }
        public ActionResult MyHeading()
        {
            //id = 4;
            var values = hm.GetListByWriter();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CetegoryName,
                                                      Value = x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;
            return View();
        }
        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterID = 4;
            p.HeadingStatus = true;
            hm.HeadingAdd(p);
            return RedirectToAction("MyHeading");
        }
    }
}