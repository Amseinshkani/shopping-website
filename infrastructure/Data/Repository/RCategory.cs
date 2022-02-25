using System.Linq.Expressions;
using System.Net.Mime;
using System;
using core.Domain.Model;
using core.Interface.Repository;
using Infrastructure.Data.Context;
using infrastructure.Data.Entity;
namespace infrastructure.Data.Repository
{
    public class RCategory : ICategory
    {
        private readonly context _context;
        public RCategory(context text)
        {
            _context = text;
        }
        public bool AddCategory(MCategory category)
        {
            Category cat = new Category()
            {
                Name = category.Name,
                Parentid = category.Parentid,
                status = true,
            };
            _context.categories.Add(cat);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateCategory(MCategory category)
        {
            try
            {
                var select = _context.categories.Where(a => a.Id == category.Id).SingleOrDefault();

                select.Name = category.Name;
                select.Parentid = category.Parentid;
                select.status = category.status;

                _context.categories.Update(select);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }

        }
        public bool DeleteCategory(int Id)
        {
            try
            {

                var Dselect = _context.categories.Where(w => w.Id == Id).SingleOrDefault();

                _context.categories.Remove(Dselect);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }

        }

        public List<MCategory> ShowCategory()
        {
            var select = _context.categories.Where(s => s.status == true).ToList();




        }

        public List<MCategory> ShowChaildCategory(int Id)
        {
            throw new NotImplementedException();
        }

        public List<MCategory> ShowParentCategory(int Id)
        {
            throw new NotImplementedException();
        }
    }
}