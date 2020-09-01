using PetShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.AppService
{
    public interface IPetService
    {
        public List<Pet> GetPets();
        bool Delete(int iD);
        public Pet CreatePet(Pet pet);
        public Pet EditPet(int ID, Pet pet);
    }
}
