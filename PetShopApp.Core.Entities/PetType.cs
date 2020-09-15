using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.Entities
{
    public class PetType
    {
        public int Id { get; set; }
        public string name { get; set; }
        public List<Pet> pets { get; set; }

        public PetType(int ID) { }
    }
}
