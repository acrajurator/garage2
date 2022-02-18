﻿namespace Garage2._0.Models
{
    public class Member
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [CheckPersonNr]
        public string PersonNumber { get; set; }
        public int Age { get; set; }

        // Nav Prop
        public  ICollection<ParkVehicle> Vehicles { get; set; } = new List<ParkVehicle>();
        public Member()
        {
        }

        public Member(string firstName, string lastName, string personNumber, int age)
        {
            FirstName = firstName;
            LastName = lastName;    
            PersonNumber = personNumber;
            Age = age;
        }
    }
}
