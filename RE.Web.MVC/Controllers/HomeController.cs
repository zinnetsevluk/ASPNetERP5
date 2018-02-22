using RE.BLL.Repository;
using RE.Web.MVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RE.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //var urunler = new ProductRepo().GetAll();//tüm ürünler gelcek
            ////satıştaki ürünler
            ////var satistakiurunler = new ProductRepo().GetAll().Where(x => x.Discontinued == false).ToList(); getAll a where yazma alttakini kullan.
            //var satistakiurunler= new ProductRepo().Queryable().Where(x => x.Discontinued == false).ToList();
            //return View(satistakiurunler);
           // var toplamurunAdet = new ProductRepo().Queryable().Count();//getall demedik sorguyu getirmeden count unu aldık.

            return View();
        }
        public async Task<JsonResult> GrafikData1()
        {
            var kategoriler = await new CategoryRepo().GetAllAsync();//kategorileri aldık
            List<KategoriRaporModel> liste = new List<KategoriRaporModel>();
            foreach (var item in kategoriler)
            {
                liste.Add(new KategoriRaporModel
                {
                    Ad = item.CategoryName,
                    Adet = item.Products.Count
                });
            }

            return Json(liste, JsonRequestBehavior.AllowGet);
        }
    }
}