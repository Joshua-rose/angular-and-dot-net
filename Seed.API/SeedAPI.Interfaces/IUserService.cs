using System.Collections.Generic;
using System.Text;
using System;

namespace SeedAPI.Interfaces
{
    public interface IUserService
    {
        public IUser Create(IUser domain);
        public bool Update(IUser domain);
        public bool Delete(int id);
        public IEnumerable<IUser> GetAll();
    }
}