using System;
using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private IProjectDal _projectDal;
        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IResult Add(Project project)
        {
            _projectDal.Add(project);
            return new SuccessResult(Messages.ProjectAdded);
        }

        public IResult Delete(Project project)
        {
            _projectDal.Delete(project);
            return new SuccessResult(Messages.ProjectDeleted);
        }

        public IDataResult<Project> GetById(int projectId)
        {
            return new SuccessDataResult<Project>(_projectDal.Get(p => p.ProjectId == projectId));
        }

        public IDataResult<List<Project>> GetList()
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetList().ToList());
        }

        public IResult Update(Project project)
        {
            _projectDal.Update(project);
            return new SuccessResult(Messages.ProjectUpdated);
        }
    }
}

