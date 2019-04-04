using CRUD_CallSP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_CallSP.Controllers
{
    public class BarangController : Controller
    {
        DAL.db context = new DAL.db();
        // GET: Barang
        public ActionResult Index()
        {
            DataSet ds = context.Index();
            ViewBag.barang = ds.Tables[0];
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection fc)
        {
            barang b = new barang();
            b.nama_barang = fc["nama_barang"];
            b.harga_barang = Convert.ToInt32(fc["harga_barang"]);
            b.total_barang = Convert.ToInt32(fc["total_barang"]);
            context.Create(b);
            TempData["msg"] = "Inserted";
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            DataSet ds = context.ShowById(id);
            ViewBag.record = ds.Tables[0];
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection fc)
        {
            barang b = new barang();
            b.kode_barang = id;
            b.nama_barang = fc["nama_barang"];
            b.harga_barang = Convert.ToInt32(fc["harga_barang"]);
            b.total_barang = Convert.ToInt32(fc["total_barang"]);
            context.Edit(b);
            TempData["msg"] = "Updated";
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            context.Delete(id);
            TempData["msg"] = "Deleted";
            return RedirectToAction("Index");
        }
    }
}