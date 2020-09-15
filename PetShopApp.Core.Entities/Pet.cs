using System;

namespace PetShopApp.Core.Entities
{
    public class Pet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public PetType Type { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime SoldDate { get; set; }
        public string Colour { get; set; }
        public Owner Owner { get; set; }
        public string PreviousOwner { get; set; }
        public double Price { get; set; }

        public Pet(string Name, PetType Type, DateTime Birthdate, DateTime SoldDate, string Colour, Owner Owner, string PreviousOwner, double Price)
        {
            
            this.Name = Name;
            this.Type = Type;
            this.Birthdate = Birthdate;
            this.SoldDate = SoldDate;
            this.Colour = Colour;
            this.Owner = Owner;
            this.PreviousOwner = PreviousOwner;
            this.Price = Price;
        }

        public Pet()
        {

        }

        public override string ToString()
        {
            return ($"{ID} - {Name} - {Type} - {Birthdate} - {SoldDate} - {Colour} - {Owner} - {PreviousOwner} - {Price}");
        }
    }
}
