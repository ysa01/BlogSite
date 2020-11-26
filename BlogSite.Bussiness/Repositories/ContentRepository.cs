using BlogSite.Bussiness.Models.Requests.Category;
using BlogSite.Bussiness.Models.Requests.Content;
using BlogSite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BlogSite.Bussiness.Repositories
{
    public class ContentRepository : IContentRepository
    {
        readonly BLOG_DBEntities _context = new BLOG_DBEntities();
        //alttaki kod anasayfaya düşecek olan resimli makaleleri carların içine yerleştirmek için sayfada listeleme işlemi yapıyoruz
        public List<CONTENTS> IndexView()
        {
            List<CATEGORİ> categori = _context.CATEGORİ.ToList();
            List<CONTENTS> contents = _context.CONTENTS.ToList();
            var asdf = contents.Select(x => x.CONTENTFILES).ToList();
            return contents;
        }
        public CONTENTS DevaminiOku(int id)
        {
            var devaminioku = _context.CONTENTS.FirstOrDefault(x => x.ID == id);
            return devaminioku;
        }
        public void Insert(InsertContentRequest request)
        {

            CONTENTS content = new CONTENTS()
            {
                CATEGORIID = request.CategoriId,
                CONTENTTEXT = request.ContentText,
                HEAD = request.ContentHead,
                //CONTENTFILE=request.ContentFile
                INSERTDATE = DateTime.Now,
                STATUS = 1,
                USERID = 1

            };
            _context.CONTENTS.Add(content);
            _context.SaveChanges();
        }
        public void CategoriesInsert(InsertCotegoriesRequest request)
        {
            CATEGORİ categori = new CATEGORİ()
            {
                CATEGORILINK = request.categoriesLink,
                CATEGORINAME = request.categoriesName,
                INSERTDATE = DateTime.Now,
                STATUS = 1,
                USERID = 1
            };
            _context.CATEGORİ.Add(categori);
            _context.SaveChanges();
        }
        public CATEGORİ GetId(int Id)
        {
            var asdx = _context.CATEGORİ.FirstOrDefault(x => x.CATEGORIID == Id);
            return asdx;
        }
        public void UpdateCategories(UpdateCategoryRequest request)
        {

            var categori = _context.CATEGORİ.FirstOrDefault(x => x.CATEGORIID == request.CATEGORIID);


            categori.CATEGORIID = request.CATEGORIID;
            categori.CATEGORILINK = request.CATEGORILINK;
            categori.CATEGORINAME = request.CATEGORINAME;
            categori.UPDATEDATE = DateTime.Now;
            categori.STATUS = 1;
            categori.USERID = 1;
            _context.SaveChanges();



        }
        public void DeleteCategories(int Id)
        {
            var categori = _context.CATEGORİ.FirstOrDefault(x => x.CATEGORIID == Id);
            var contents = categori.CONTENTS.AsEnumerable();
            foreach (var item in contents)
            {
                var files = item.CONTENTFILES.AsEnumerable();
                _context.CONTENTFILES.RemoveRange(files);                
            }

            _context.CONTENTS.RemoveRange(contents);
            _context.SaveChanges();

            _context.CATEGORİ.Remove(categori);
            _context.SaveChanges();

        }
        public void Update(CONTENTS content)
        {
            if (content.ID == 0)
            {
                _context.CONTENTS.Add(content);
                _context.SaveChanges();
            }
            else
            {
                var data = _context.CONTENTS.FirstOrDefault(x => x.ID == content.ID);
                data.HEAD = content.HEAD;
                data.CONTENTTEXT = content.CONTENTTEXT;
                data.UPDATEDATE = DateTime.Now;
                _context.SaveChanges();


            }
        }
        public void UpdateContent(CONTENTS content)
        {
            var dbcontent = _context.CONTENTS.FirstOrDefault(x => x.ID == content.ID);
            dbcontent.HEAD = content.HEAD;
            dbcontent.CONTENTTEXT = content.CONTENTTEXT;
            dbcontent.UPDATEDATE = DateTime.Now;
            _context.SaveChanges();
        }
        public List<CONTENTS> GetAll()
        {
            var asd = _context.CONTENTS.ToList();
            return asd;

        }
        public List<CATEGORİ> All()
        {
            var asd = _context.CATEGORİ.ToList();
            return asd;

        }
        public CONTENTS GetById(int Id)
        {
            var asdx = _context.CONTENTS.FirstOrDefault(x => x.ID == Id);
            return asdx;
        }
        public void Delete(int Id)
        {
            var content = _context.CONTENTS.FirstOrDefault(x => x.ID == Id);
            _context.CONTENTS.Remove(content);
            _context.SaveChanges();

        }
        public void InsertImage(int contentId, string path)
        {
            CONTENTFILES file = new CONTENTFILES()
            {
                CONTENTID = contentId,
                INSERTDATE = DateTime.Now,
                PATH = path,
                STATUS = 1
            };
            _context.CONTENTFILES.Add(file);
            _context.SaveChanges();
        }

        //public static implicit operator ContentRepository(AuthRepository v)
        //{
        //    throw new NotImplementedException();
        //}
    }


}

public interface IContentRepository
{
    void Insert(InsertContentRequest request);
    void Update(CONTENTS request);
    CONTENTS GetById(int Id);
    void UpdateContent(CONTENTS content);
    List<CONTENTS> IndexView();
    CONTENTS DevaminiOku(int id);
    List<CATEGORİ> All();
    List<CONTENTS> GetAll();
    CATEGORİ GetId(int Id);
    void UpdateCategories(UpdateCategoryRequest request);
    void DeleteCategories(int Id);

}

