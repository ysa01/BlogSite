using BlogSite.Bussiness.Models.Requests.Category;
using BlogSite.Bussiness.Models.Requests.Content;
using BlogSite.Bussiness.Repositories;
using BlogSite.Data;
using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace BlogSite.Controllers
{
    public class ContentController : BaseController
    {
        // GET: Content
        
        public ActionResult Insert()
        {
            return View(contentrepository.All());
        }
        [HttpPost]
        public ActionResult Insert( InsertContentRequest request)
        {
            contentrepository.Insert(request);
            return View(contentrepository.All());
        }
        //alttaki kod kullanıcı tarafından girilen yorumların listesi yani formdaki veriler
        public ActionResult List()
        {
            return View(contentrepository.GetAll());
        }
        //alttaki get ve post olan iki action ikiside formdaki yorumları güncellemek için
        public ActionResult UpdateList(int Id)
        {
            return View(contentrepository.GetById(Id));
        }

        [HttpPost]
        public ActionResult UpdateList(CONTENTS content)
        {
            contentrepository.Update(content);

            return RedirectToAction("List");
        }

        
        public ActionResult Delete(int Id)
        {
            contentrepository.Delete(Id);
            return RedirectToAction("List");
        }
        public ActionResult DeleteCategories(int Id)
        {
            contentrepository.DeleteCategories(Id);
            return RedirectToAction("Categories");
        }


        //forma anasayfaya da gidiyor kartların içine de gidiyor ama sadece update list sayfasından yükleme yapabilirsin
        [HttpGet]
        public ActionResult SaveImages(int Id)
        {
            return View();

        }
        [HttpPost]
        public ActionResult SaveImages(string hiddenId, HttpPostedFileBase UploadImage )
        {
            if (UploadImage.ContentLength > 0)
            {
                string imageFileName = hiddenId + ".jpeg";
                string folderPath = Path.Combine(Server.MapPath("~/UploadImages"),imageFileName);
                UploadImage.SaveAs(folderPath);
                contentrepository.InsertImage(Convert.ToInt32(hiddenId), imageFileName);
                ViewBag.Message = hiddenId + ".jpg isimli resim başarıyla yüklendi.";
            }
            else
            {
                ViewBag.Message = "resim yüklenemedi";
                return Redirect("SaveImages");
               
            }
            
            return View();
        }
        //database deki eklediğimiz kategorileri listeleme actionı
        public ActionResult Categories()
        {
            return View(contentrepository.All());
        }
        
        public ActionResult CategoriesInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CategorIesInsert(InsertCotegoriesRequest request)
        {
            contentrepository.CategoriesInsert(request);
            return RedirectToAction("Categories");
        }
        public ActionResult UpdateCategories()
        {
            return View();
        }
       
       
        public ActionResult UpdateFormCategories(int Id)
        {
            var category = contentrepository.GetId(Id);
            return View(new UpdateCategoryRequest {CATEGORIID=category.CATEGORIID,CATEGORILINK=category.CATEGORILINK,CATEGORINAME=category.CATEGORINAME });
        }
        [HttpPost]
        public ActionResult UpdateFormCategories(UpdateCategoryRequest categori)
        {
            contentrepository.UpdateCategories(categori);
            return RedirectToAction("Categories");
        }
    }
}