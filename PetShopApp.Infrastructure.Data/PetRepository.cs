using PetShopApp.Core.DomainService;
using PetShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopApp.Infrastructure.Data
{
    public class PetRepository : IPetRepository
    {
        public Pet CreatePet(Pet pet)
        {
            return FakeDB.AddPet(pet);
        }

        public bool DeletePet(int iD)
        {
            if (FakeDB.PetList.Find(x => x.ID == iD) != null)
            {
                FakeDB.PetList.Remove(FakeDB.PetList.Find(x => x.ID == iD));
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pet EditPet(int ID, Pet pet)
        {
            if (FakeDB.PetList.Find(x => x.ID == ID) != null)
            {
                FakeDB.PetList[ID] = pet;
                return pet;
            }
            else
            {
                return null;
            }
        }

        public List<Pet> ReadPets()
        {
            return FakeDB.PetList;
        }

        public List<Pet> ReadPets(Filter filter)
        {
            IEnumerable<Pet> filtering = FakeDB.PetList;
            if (!string.IsNullOrEmpty(filter.SearchText))
            {
                switch (filter.SearchField.ToLower())
                {
                    case "name":
                        filtering = filtering.Where(c => c.Name.Contains(filter.SearchText));
                        break;
                    case "color":
                        filtering = filtering.Where(c => c.Colour.Contains(filter.SearchText));
                        break;

                }
            }
            return filtering.ToList();
        }
    }
}
