﻿using QLBTSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLBTSV.Areas.Student.Controllers
{
    public class SV_DetailStudentController : Controller
    {
        // GET: Student/SV_DetailStudent
        [HttpGet]
        [Route("SV_DetailStudent/Details/{id}")]
        public ActionResult Details(string id)
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("DangNhap", "HomeAdmin", new { area = "Admin" });
            }
            else
            {

                QL_PROJECTEntities db = new QL_PROJECTEntities();
                var userID = id;

                var sinhvien = db.SINHVIENs.FirstOrDefault(sv => sv.massv == userID);


                if (sinhvien != null)
                {
                    var mssv = sinhvien.massv;
                    var ten = sinhvien.ten;
                    var namsinh = sinhvien.namsinh;
                    var sdt = sinhvien.sdt;
                    var lop = sinhvien.lop;
                    var nienkhoa = sinhvien.nien_khoa;
                    var email = sinhvien.email;

                    ViewBag.mssv = mssv;
                    ViewBag.ten = ten;
                    ViewBag.namsinh = namsinh;
                    ViewBag.sdt = sdt;
                    ViewBag.lop = lop;
                    ViewBag.nienkhoa = nienkhoa;
                    ViewBag.email = email;

                }
                return View();
            }
        }
    }
}