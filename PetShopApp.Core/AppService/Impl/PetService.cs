using PetShopApp.Core.DomainService;
using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.AppService.Impl
{
    public class PetService : IPetService
    {
        private IPetRepository _PetRepository;
        public PetService(IPetRepository PetRepository) 
        {
            _PetRepository = PetRepository;
        }

        public List<Pet> GetPets()
        {
            return _PetRepository.ReadPets();
        }

        public bool Delete(int ID)
        {
           return _PetRepository.DeletePet(ID);
        }

        public Pet CreatePet(Pet pet)
        {
            return _PetRepository.CreatePet(pet);
        }

        public Pet EditPet(int ID, Pet pet)
        {
            return _PetRepository.EditPet(ID, pet);
        }

        public List<Pet> GetPets(Filter filter)
        {
            if (!string.IsNullOrEmpty(filter.SearchText) && string.IsNullOrEmpty(filter.SearchField))
            {
                filter.SearchField = "name";
            }

            return _PetRepository.ReadPets(filter);
        }
    }
}
