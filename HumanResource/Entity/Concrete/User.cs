using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class User:IEntity 
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Position { get; set; }
	}
}

