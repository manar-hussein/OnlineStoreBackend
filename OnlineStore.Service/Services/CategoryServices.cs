using OnlineStore.Domain.Interfaces;

namespace OnlineStore.Service.Services
{
    public class CategoryServices : ICategoryServices
    {
        private IUnitOfWork _unitOfWork;

        public CategoryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddCategory(Category category)
        {
            _unitOfWork.Repository<Category>().Add(category);
        }

        public IEnumerable<Category> GetCategories()
        {
          return _unitOfWork.Repository<Category>().GetAll();
        }

        public Category GetCategory(int id)
        {
            return _unitOfWork.Repository<Category>().GetById(id);
        }

        public void RemoveCategory(int id)
        {
            _unitOfWork.Repository<Category>().Delete(id);
        }

        public void UpdateCategory(Category category)
        {
            _unitOfWork.Repository<Category>().Update(category);
        }
    }
}
