using System;

namespace PetShopApp.Core.Entities
{
    public class Owner
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string OwnedPet { get; set; }

        public Owner(string Name, DateTime Birthdate, string OwnedPet)
        {

            this.Name = Name;
            this.Birthdate = Birthdate;
            this.OwnedPet = OwnedPet;

        }
        public override string ToString()
        {
            return ($"{ID} - {Name} - {Birthdate} - {OwnedPet}");
        }
    }
}
