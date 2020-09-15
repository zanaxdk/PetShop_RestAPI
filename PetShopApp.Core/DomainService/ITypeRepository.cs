using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.DomainService
{
    public interface ITypeRepository
    {
        public List<PetType> ReadTypes();
        bool DeleteType(int iD);
        public PetType CreateType(PetType type);
        public PetType EditType(int ID, PetType type);
        public List<PetType> ReadTypes(Filter filter);
    }
}
