using PetShopApp.Core.DomainService;
using PetShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopApp.Infrastructure.Data
{
    public class OwnerRepository : IOwnerRepository
    {
        public Owner CreateOwner(Owner owner)
        {
            return FakeDB.AddOwner(owner);
        }

        public bool DeleteOwner(int iD)
        {
            if (FakeDB.OwnerList.Find(x => x.ID == iD) != null)
            {
                FakeDB.OwnerList.Remove(FakeDB.OwnerList.Find(x => x.ID == iD));
                return true;
            }
            else
            {
                return false;
            }
        }

        public Owner EditOwner(int ID, Owner owner)
        {
            if (FakeDB.OwnerList.Find(x => x.ID == ID) != null)
            {
                FakeDB.OwnerList[ID] = owner;
                return owner;
            }
            else
            {
                return null;
            }
        }

        public List<Owner> ReadOwners()
        {
            return FakeDB.OwnerList;
        }

        public List<Owner> ReadOwners(Filter filter)
        {
            IEnumerable<Owner> filtering = FakeDB.OwnerList;
            if (!string.IsNullOrEmpty(filter.SearchText))
            {
                switch (filter.SearchField.ToLower())
                {
                    case "FName":
                        filtering = filtering.Where(c => c.FName.Contains(filter.SearchText));
                        break;
                    case "LName":
                        filtering = filtering.Where(c => c.LName.Contains(filter.SearchText));
                        break;

                }
            }
            return filtering.ToList();
        }
    }
}
