using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BOL.Cervices.Common
{
	public interface IDTOService<DTO_T/*, EF_E*/>
		where DTO_T : class, new() //типізований поко-класом(DTO_T)
		//where EF_E : class, new()  //типізований  Entity-класом(EF_E)
	{
		DTO_T Get(Guid id);
		IEnumerable<DTO_T> GetAll();
		IEnumerable<DTO_T> FindBy(Expression<Func<DTO_T, bool>> predicate);
		void AddOrUpdate(DTO_T obj);
		void Delete(DTO_T obj);
	}
}
