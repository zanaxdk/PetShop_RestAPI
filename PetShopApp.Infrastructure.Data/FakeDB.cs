﻿using PetShopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Infrastructure.Data
{
    public class FakeDB
    {
        public static List<Pet> PetList = new List<Pet>();
        public static int Id = 0;

        public void InitData()
        {
            AddPet(new Pet("Pet1", "Dragon", DateTime.Now.AddYears(-710), DateTime.Now.AddDays(-7), "Blue", "Owner1", 45000.99));
            AddPet(new Pet("Pet2", "Goat", DateTime.Now.AddYears(-7), DateTime.Now.AddMonths(-7), "Green", "Owner2", 4.99));
            AddPet(new Pet("Pet3", "Dog", DateTime.Now.AddYears(-1), DateTime.Now.AddYears(-30), "Red", "Owner3", 2.00));
            AddPet(new Pet("Pet4", "Cat", DateTime.Now.AddYears(-10), DateTime.Now.AddDays(-1), "Yellow", "Owner4", 999.99));
        }

        public static Pet AddPet(Pet pet)
        {
            Id++;
            pet.ID = Id;
            PetList.Add(pet);
            return pet;
        }


    }
}