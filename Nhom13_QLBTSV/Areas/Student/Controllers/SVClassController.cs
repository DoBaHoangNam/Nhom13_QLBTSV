﻿using QLBTSV.Content.Custom.Class;
using QLBTSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLBTSV.Areas.Student.Controllers
{
    public class SVClassController : Controller
    {
        // GET: Student/SVClass
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("DangNhap", "HomeAdmin", new { area = "Admin" });
            }
            else
            {
                QL_PROJECTEntities db = new QL_PROJECTEntities();
                var session = Session["user"].ToString();
                //List<LOPMONHOC> lop = db.LOPMONHOCs.Where(m => m.magv == session).ToList();
                List<SINHVIENMONHOC> lop = db.SINHVIENMONHOCs.Where(m => m.mssv == session).ToList();


                return View(lop);
            }
        }

        [HttpGet]
        [Route("Detail/{id}")]
        public ActionResult Detail(string id)
        {

            ClassID model = new ClassID();
            model.Id = id;
            // Gán giá trị cho các thuộc tính khác của model


            if (Session["user"] == null)
            {
                return RedirectToAction("DangNhap", "HomeAdmin", new { area = "Admin" });
            }
            else
            {

                return View(model);
            }
        }
    }
}