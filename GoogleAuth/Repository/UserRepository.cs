using GoogleAuth.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleAuth.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly WebApiContext context;
        private readonly DbSet<User> dbSet;

        public UserRepository(WebApiContext context)
        {
            this.context = context;
            dbSet = context.Set<User>();
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User> InsertAsync(User user)
        {
            var result = (await dbSet.AddAsync(user)).Entity;
            await context.SaveChangesAsync();
            return result;
        }
    }
}
