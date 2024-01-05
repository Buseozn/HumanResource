using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Project : IEntity
	{
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Employee { get; set; }
        public DateTime ProjectDate { get; set; }

    }
}

