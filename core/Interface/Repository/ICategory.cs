using System;
using core.Domain.Model;

namespace core.Interface.Repository
{
    public interface ICategory
    {
        bool AddCategory(MCategory category);
        bool UpdateCategory(MCategory category);
        bool DeleteCategory(int Id);
        List<MCategory> ShowCategory();
        List<MCategory> ShowParentCategory(int Id);
        List<MCategory> ShowChaildCategory(int Id);
    }
}