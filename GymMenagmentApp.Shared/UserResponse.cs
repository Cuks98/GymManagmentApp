﻿using DataBase.API.Models;
using System.Collections.Generic;

namespace DataBaseAPI.Models
{
    public class UserResponse
    {
        public int? ErrorId { get; set; }
        public string ErrorMsg { get; set; }
        public List<User> Users { get; set; }
    }
}
