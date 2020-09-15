using PetShopApp.Core.DomainService;
using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.AppService.Impl
{
    public class TypeService : ITypeService
    {
        private ITypeRepository _TypeRepository;
        public TypeService(ITypeRepository TypeRepository)
        {
            _TypeRepository = TypeRepository;
        }
        public PetType CreateType(PetType type)
        {
            return _TypeRepository.CreateType(type);
        }

        public bool Delete(int iD)
        {
            return _TypeRepository.DeleteType(iD);
        }

        public PetType EditType(int ID, PetType type)
        {
            return _TypeRepository.EditType(ID, type);
        }

        public List<PetType> GetTypes()
        {
            return _TypeRepository.ReadTypes();
        }

        public List<PetType> GetTypes(Filter filter)
        {
            if (!string.IsNullOrEmpty(filter.SearchText) && string.IsNullOrEmpty(filter.SearchField))
            {
                filter.SearchField = "Type name";
            }

            return _TypeRepository.ReadTypes(filter);
        }
    }
}
