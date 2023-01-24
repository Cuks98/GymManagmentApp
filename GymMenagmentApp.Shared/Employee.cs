﻿namespace DataBaseAPI.Models
{
    public class Employee
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public int LevelOfSecurity { get; set; }
        public byte[]? Image { get; set; }
        public string? salt { get; set; }
        public double? Neto { get; set; }
        public double? Bruto { get; set; }

        public void updateEmployee(string firstName)
        {
            this.FirstName = firstName;
        }
    }
}
