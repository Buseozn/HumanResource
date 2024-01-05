using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IUserService
	{
        IDataResult<User>GetById(int userId);

		IDataResult<List<User>>GetList();

		IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}

