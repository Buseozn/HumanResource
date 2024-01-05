using System;
using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfProjectDal : EfEntityRepositoryBase<Project, HumanResourceContext>, IProjectDal
	{ 
        
	}
}

