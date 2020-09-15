using PetShopApp.Core.DomainService;
using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.AppService.Impl
{
    public class OwnerService : IOwnerService
    {
        private IOwnerRepository _OwnerRepository;
        public OwnerService(IOwnerRepository OwnerRepository)
        {
            _OwnerRepository = OwnerRepository;
        }
        public Owner CreateOwner(Owner owner)
        {
            return _OwnerRepository.CreateOwner(owner);
        }

        public bool Delete(int iD)
        {
            return _OwnerRepository.DeleteOwner(iD);
        }

        public Owner EditOwner(int ID, Owner owner)
        {
            return _OwnerRepository.EditOwner(ID, owner);
        }

        public List<Owner> GetOwners()
        {
            return _OwnerRepository.ReadOwners();
        }

        public List<Owner> GetOwners(Filter filter)
        {
            if (!string.IsNullOrEmpty(filter.SearchText) && string.IsNullOrEmpty(filter.SearchField))
            {
                filter.SearchField = "First name";
            }

            return _OwnerRepository.ReadOwners(filter);
        }
    }
}
