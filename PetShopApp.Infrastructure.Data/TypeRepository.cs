using PetShopApp.Core.DomainService;
using PetShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShopApp.Infrastructure.Data
{
    public class TypeRepository : ITypeRepository
    {
        public List<PetType> ReadTypes()
        {
            return FakeDB.TypeList;
        }
        public PetType CreateType(PetType type)
        {
            return FakeDB.AddType(type);
        }

        public bool DeleteType(int iD)
        {
            if (FakeDB.TypeList.Find(x => x.Id == iD) != null)
            {
                FakeDB.TypeList.Remove(FakeDB.TypeList.Find(x => x.Id == iD));
                return true;
            }
            else
            {
                return false;
            }
        }

        public PetType EditType(int ID, PetType type)
        {
            if (FakeDB.TypeList.Find(x => x.Id == ID) != null)
            {
                FakeDB.TypeList[ID] = type;
                return type;
            }
            else
            {
                return null;
            }
        }

        public List<PetType> ReadTypes(Filter filter)
        {
            IEnumerable<PetType> filtering = FakeDB.TypeList;
            if (!string.IsNullOrEmpty(filter.SearchText))
            {
                switch (filter.SearchField.ToLower())
                {
                    case "name":
                        filtering = filtering.Where(c => c.name.Contains(filter.SearchText));
                        break;

                }
            }
            return filtering.ToList();
        }
    }
}
