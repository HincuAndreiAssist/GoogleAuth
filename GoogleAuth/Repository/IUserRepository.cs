using GoogleAuth.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleAuth.Repository
{
    public interface IUserRepository
    {
        Task<User> InsertAsync(User user);
        Task<List<User>> GetAllUsersAsync();
    }
}
