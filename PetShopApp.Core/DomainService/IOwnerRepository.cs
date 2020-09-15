using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.DomainService
{
    public interface IOwnerRepository
    {
        public List<Owner> ReadOwners();
        bool DeleteOwner(int iD);
        public Owner CreateOwner(Owner owner);
        public Owner EditOwner(int ID, Owner owner);
        public List<Owner> ReadOwners(Filter filter);
    }
}
