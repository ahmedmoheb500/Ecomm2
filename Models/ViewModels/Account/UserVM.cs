﻿using EcommCMS.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommCMS.Models.ViewModels.Account
{
    public class UserVM
    {
        //Constructors
        public UserVM()
        {

        }
        public UserVM(UsersDTO user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            EmailAddress = user.EmailAddress;
            Username = user.Username;
            Password = user.Password;
        }
        //All the fields
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [Required] 
        public string Username { get; set; }
        [Required] 
        public string Password { get; set; }
    }
}