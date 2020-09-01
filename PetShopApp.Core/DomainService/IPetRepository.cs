using PetShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.DomainService
{
    public interface IPetRepository
    {
        public List<Pet> ReadPets();
        bool DeletePet(int iD);
        public Pet CreatePet(Pet pet);
        public Pet EditPet(int ID, Pet pet);
    }
}
