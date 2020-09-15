using System;
using System.Collections.Generic;

namespace PetShopApp.Core.Entities
{
    public class Owner
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public List<Pet> OwnedPets { get; set; }

        public Owner(string FName, string LName, string PhoneNumber, string Email, string Address,  DateTime Birthdate, List<Pet> OwnedPets)
        {

            this.FName = FName;
            this.LName = LName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Address = Address;
            this.Birthdate = Birthdate;
            this.OwnedPets = OwnedPets;

        }

        public Owner(int ID) { }
        public override string ToString()
        {
            return ($"{ID} - {FName} - {LName} - {PhoneNumber} - {Email} - {Address} - {Birthdate} - {OwnedPets}");
        }
    }
}
