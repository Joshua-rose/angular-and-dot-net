using SeedAPI.Interfaces;
using System;

namespace SeedAPI.ViewModels
{
    public class LoginViewModel: IBaseViewModel
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
