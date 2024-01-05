using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IProjectService
	{
        IDataResult<Project> GetById(int projectId);

        IDataResult<List<Project>> GetList();

        IResult Add(Project project);
        IResult Delete(Project project);
        IResult Update(Project project);
    }
}

