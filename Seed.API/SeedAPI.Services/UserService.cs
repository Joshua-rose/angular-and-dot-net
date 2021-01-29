using SeedAPI.Interfaces;
using SeedAPI.Models;
using System;
using System.Collections.Generic;

namespace SeedAPI.Services
{
    public class UserService : IUserService
    {
        private IUserRepository repository;
        public UserService(IUserRepository userRepository)
        {
            repository = userRepository;
        }
        public User Create(User domain)
        {
            return repository.Save(domain);
        }
        public bool Update(User domain)
        {
            return repository.Update(domain);
        }
        public bool Delete(int id)
        {
            return repository.Delete(id);
        }
        public List<User> GetAll()
        {
            return repository.GetAll();
        }

        public IUser Create(IUser domain)
        {
            throw new NotImplementedException();
        }

        public bool Update(IUser domain)
        {
            throw new NotImplementedException();
        }

        IEnumerable<IUser> IUserService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
