﻿namespace IMS.Services.AuthAPI.Models.Dto
{
    public class UserRegistrationRequestDto
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Role {  get; set; }
        public string Password { get; set; }
    }
}
