using System;

namespace ClinicApp.HelperClasses
{
    public static class DateHelper
    {
        public static int CalculateAge(DateTime birthdate, DateTime currentdate)
        {
            int age = currentdate.Year - birthdate.Year;

            if (currentdate.Month < birthdate.Month ||
               (currentdate.Month == birthdate.Month && currentdate.Day < birthdate.Day))
            {
                age--;
            }

            return age;
        }
    }
}
