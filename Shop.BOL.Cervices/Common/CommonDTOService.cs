using AutoMapper;
using Step.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BOL.Cervices.Common
{
	public abstract class CommonDTOService<DTO_T, EF_E> : IDTOService<DTO_T>
		where DTO_T : class, new() //типізований поко-класом(DTO_T)
		where EF_E : class, new()  //типізований  Entity-класом(EF_E)
	{
		IGenericRepository<EF_E> eRep; //репозиторій відповідної Entity-колекції
		IMapper mapper;

		// конфігурація мапера за замовчуванням. Можна перевизначити в нащадках (при потребі)
		protected virtual MapperConfiguration MapConfig()
		{
			MapperConfiguration config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<DTO_T, EF_E>();
				cfg.CreateMap<EF_E, DTO_T>();
			});
			return config;
		}
		// створення мапера з параметрами, можливо вже зміненим в нащадку	
		private void MapperInstantiate()
		{
			mapper = MapConfig().CreateMapper();
		}

		public CommonDTOService(IGenericRepository<EF_E> tRep)
		{
			this.eRep = tRep;       // ініціалізація репозиторію отриманим з параметрів
			MapperInstantiate();    //ініціалізація мапера в конструторі
		}

		public DTO_T Get(Guid id)
		{
			EF_E ef_entity = eRep.Get(id);

			return mapper.Map<DTO_T>(ef_entity);
		}

		public IEnumerable<DTO_T> GetAll()
		{
			return eRep.GetAll()
				.Select(ef_entity => mapper.Map<DTO_T>(ef_entity));
		}

		public void AddOrUpdate(DTO_T obj)
		{
			eRep.AddOrUpdate(mapper.Map<EF_E>(obj));
		}

		public void Delete(DTO_T obj)
		{
			eRep.Delete(mapper.Map<EF_E>(obj));
		}

		public IEnumerable<DTO_T> FindBy(Expression<Func<DTO_T, bool>> predicate)
		{
			return this.GetAll().AsQueryable().Where(predicate); //предікат накладаємо на вже вибрану і відмапляну колекцію обєктів
		}
	}
}
