using ClinicApp.HelperClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClinicApp.EntityModels
{
    public enum Gender
    {
        [Description("Мужской")]
        Male,
        [Description("Женский")]
        Female
    };

    public class PatientCard
    {
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }
        public String PhoneNumber { get; set; }
        public List<Request> Requests { get; set; }
        public int Age { get => DateHelper.CalculateAge(DateOfBirth, DateTime.Now); }
    }
}
