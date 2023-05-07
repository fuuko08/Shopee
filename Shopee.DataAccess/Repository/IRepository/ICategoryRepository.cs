using Shopee.Models;

namespace Shopee.DataAccess.Repository.IRepository
{
	public interface ICategoryRepository : IRepository<Category>
	{
		void Update(Category obj);
		void Save();
	}
}

