using Entities;
using Entities.Declarations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
    public class UserService : GenericRepository<User>, IUserService
    {
        DataContext _dataContext;
        public UserService(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
