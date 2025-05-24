using System;
using System.ComponentModel.DataAnnotations;

namespace studentmgmt.Models
{
    public class NoWeekendBirthdayAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return true; // Let the Required attribute handle null values

            if (value is DateTime dateOfBirth)
            {
                // Check if the date falls on a weekend (Saturday or Sunday)
                DayOfWeek dayOfWeek = dateOfBirth.DayOfWeek;
                return dayOfWeek != DayOfWeek.Saturday && dayOfWeek != DayOfWeek.Sunday;
            }

            return false; // If value is not a DateTime, validation fails
        }
    }
}