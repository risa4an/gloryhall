using System;
namespace gloryhall.Data.ViewModels
{
    public class CreateUserViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }

   
}
