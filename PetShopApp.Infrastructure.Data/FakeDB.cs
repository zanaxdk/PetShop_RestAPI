using PetShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Infrastructure.Data
{
    public static class FakeDB
    {
        public static List<Pet> PetList = new List<Pet>();
        public static List<Owner> OwnerList = new List<Owner>();
        public static List<PetType> TypeList = new List<PetType>();
        public static int Id = 0;
        public static int ID = 0;
        public static int iD = 0;

        public static void InitData()
        {
            AddPet(new Pet("Pet1", new PetType(1), DateTime.Now.AddYears(-710), DateTime.Now.AddDays(-7), "Blue", new Owner(1), "Owner1", 45000.99));
            AddPet(new Pet("Pet2", new PetType(2), DateTime.Now.AddYears(-7), DateTime.Now.AddMonths(-7), "Green", new Owner(2), "Owner2", 4.99));
            AddPet(new Pet("Pet3", new PetType(3), DateTime.Now.AddYears(-1), DateTime.Now.AddYears(-30), "Red", new Owner(3), "Owner3", 2.00));
            AddPet(new Pet("Pet4", new PetType(4), DateTime.Now.AddYears(-10), DateTime.Now.AddDays(-1), "Yellow", new Owner(4), "Owner4", 999.99));
        }

        public static Pet AddPet(Pet pet)
        {
            
            pet.ID = Id;
            Id++;
            PetList.Add(pet);
            return pet;
        }

        public static Owner AddOwner(Owner owner)
        {
            
            owner.ID = ID;
            ID++;
            OwnerList.Add(owner);
            return owner;
        }

        public static PetType AddType(PetType pettype)
        {

            pettype.Id = iD;
            iD++;
            TypeList.Add(pettype);
            return pettype;
        }


    }
}
