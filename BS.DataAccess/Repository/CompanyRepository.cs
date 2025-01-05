using BS.DataAccess.Data;
using BS.DataAccess.Repository.IRepository;
using BS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BS.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>,ICompanyRepository
	{

		private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db):base(db) 
        {
				_db = db;
        }

       

		public void Update(Company obj)
		{
			_db.Companies.Update(obj); ;
		}
	}
}
