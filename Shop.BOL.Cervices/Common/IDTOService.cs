using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BOL.Cervices.Common
{
	public interface IDTOService<T> where T : class, new()
	{
		T Get(int id);
		IEnumerable<T> GetAll();
		IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
		void AddOrUpdate(T obj);
		void Delete(T obj);
	}
}
