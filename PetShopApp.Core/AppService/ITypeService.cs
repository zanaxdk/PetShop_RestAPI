using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.AppService
{
    public interface ITypeService
    {
        public List<PetType> GetTypes();
        bool Delete(int iD);
        public PetType CreateType(PetType type);
        public PetType EditType(int ID, PetType type);
        public List<PetType> GetTypes(Filter filter);
    }
}
