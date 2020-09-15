using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.AppService
{
    public interface IOwnerService
    {
        public List<Owner> GetOwners();
        bool Delete(int iD);
        public Owner CreateOwner(Owner owner);
        public Owner EditOwner(int ID, Owner owner);
        public List<Owner> GetOwners(Filter filter);
    }
}
