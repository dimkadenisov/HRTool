using System;
using Microsoft.AspNetCore.Identity;

namespace HRTool.DAL.Models
{
    //Модель пользователя приложения
    public class User : IdentityUser
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        //TODO: имплементировать ролевые классы
        //public Role RoleName {get; set;}
    }
}