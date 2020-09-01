using PetShopApp.Core.AppService;
using PetShopApp.Core.Entities;
using PetShopApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace PetShopAppUI
{
    public class Printer
    {
        private IPetService _PetService;
        public Printer(IPetService PetService)
        {
            _PetService = PetService;
        }
        private int Selection = 1;
        public void Print()
        {

            while (Selection > 0) 
            {
                
                MainMenu();
                string readLine = Console.ReadLine();
                Selection = int.Parse(readLine);

                switch (Selection)
                {
                    case 1:
                        Console.WriteLine("Create new pet");
                        Console.WriteLine("--------------------------------------------------\n");

                        string Name;
                        string Type;
                        DateTime BD;
                        DateTime SoldDate;
                        string Colour;
                        string PrevOwner;
                        double Price;

                        Console.WriteLine("Input pet name");
                        Name = Console.ReadLine();

                        if (string.IsNullOrEmpty(Name))
                        {
                            Name = "NO NAME";
                        }

                        Console.WriteLine("Input pet type");
                        Console.WriteLine("1: Dog");
                        Console.WriteLine("2: Cat");
                        Console.WriteLine("3: Dragon");
                        Console.WriteLine("4: Goat");
                        Console.WriteLine("--------------------------------------------------\n");
                        Type = Console.ReadLine();

                        if (string.IsNullOrEmpty(Type))
                        {
                            Type = "NO TYPE";
                        }
                        else if (Type == "1")
                        {
                            Type = "Dog";
                        }
                        else if (Type == "2")
                        {
                            Type = "Cat";
                        }
                        else if (Type == "3")
                        {
                            Type = "Dragon";
                        }
                        else if (Type == "4")
                        {
                            Type = "Goat";
                        }
                        else
                        {
                            Type = "UNKNOWN TYPE";
                        }

                        Console.WriteLine("Input pet birthdate (format MM-DD-YYYY)");
                        string readline = Console.ReadLine();

                        if (string.IsNullOrEmpty(readline))
                        {
                            BD = DateTime.Now;
                        }
                        else
                        {
                            BD = DateTime.Parse(readline);
                        }

                        Console.WriteLine("Input pet sold date (format MM-DD-YYYY)");
                        string Readline = Console.ReadLine();

                        if (string.IsNullOrEmpty(Readline))
                        {
                            SoldDate = DateTime.Now;
                        }
                        else
                        {
                            SoldDate = DateTime.Parse(Readline);
                        }

                        Console.WriteLine("Input pet colour");
                        Colour = Console.ReadLine();

                        if (string.IsNullOrEmpty(Colour))
                        {
                            Colour = "NO COLOR";
                        }

                        Console.WriteLine("Input previous pet owner");
                        PrevOwner = Console.ReadLine();

                        if (string.IsNullOrEmpty(PrevOwner))
                        {
                            PrevOwner = "NO OWNER";
                        }

                        Console.WriteLine("Input pet price");
                        readline = Console.ReadLine();

                        if (string.IsNullOrEmpty(readline))
                        {
                            Price = 0.00;
                        }
                        else
                        {
                            Price = double.Parse(readLine);
                        }

                        Pet newPet = new Pet(Name, Type, BD, SoldDate, Colour, PrevOwner, Price);
                        _PetService.CreatePet(newPet);
                        Console.WriteLine(Name + " Has been created!");
                        break;

                    case 2:
                        Console.WriteLine("List all existing pets");
                        Console.WriteLine("--------------------------------------------------\n");
                        List<Pet> petlist = new List<Pet>();
                        petlist = _PetService.GetPets();
                        petlist.ForEach(i => Console.WriteLine(i.ToString()));
                        Console.WriteLine("End of list...");
                        Console.WriteLine("--------------------------------------------------\n");
                        break;

                    case 3:
                        Console.WriteLine("Edit existing pet");
                        Console.WriteLine("--------------------------------------------------\n");
                        Console.WriteLine("Input pet ID");
                        readLine = Console.ReadLine();
                        int Id = int.Parse(readLine);
                        petlist = _PetService.GetPets();
                        Console.WriteLine("--------------------------------------------------\n");

                        if (Id > petlist.Count)
                        {
                            throw new IndexOutOfRangeException();
                        }

                        Console.WriteLine(petlist[Id].Name + " To be edited");
                        Console.WriteLine("--------------------------------------------------\n");

                        string newName = petlist[Id].Name;
                        string newType = petlist[Id].Type;
                        DateTime newBD = petlist[Id].Birthdate;
                        DateTime newSoldDate = petlist[Id].SoldDate;
                        string newColour = petlist[Id].Colour;
                        string newPrevOwner = petlist[Id].PreviousOwner;
                        double newPrice = petlist[Id].Price;

                        Console.WriteLine("Input new pet name");
                        newName = Console.ReadLine();

                        if (string.IsNullOrEmpty(newName))
                        {
                            newName = petlist[Id].Name;
                        }

                        Console.WriteLine("Input new pet type");
                        Console.WriteLine("1: Dog");
                        Console.WriteLine("2: Cat");
                        Console.WriteLine("3: Dragon");
                        Console.WriteLine("4: Goat");
                        Console.WriteLine("--------------------------------------------------\n");
                        newType = Console.ReadLine();

                        if (string.IsNullOrEmpty(newType))
                        {
                            newType = petlist[Id].Type;
                        }
                        else if (newType == "1")
                        {
                            newType = "Dog";
                        }
                        else if (newType == "2")
                        {
                            newType = "Cat";
                        }
                        else if (newType == "3")
                        {
                            newType = "Dragon";
                        }
                        else if (newType == "4")
                        {
                            newType = "Goat";
                        }
                        else
                        {
                            newType = petlist[Id].Type;
                        }

                        Console.WriteLine("Input new pet birthdate (format MM-DD-YYYY)");
                        string read = Console.ReadLine();

                        if (string.IsNullOrEmpty(read))
                        {
                            newBD = petlist[Id].Birthdate;
                        }
                        else
                        {
                            newBD = DateTime.Parse(read);
                        }

                        Console.WriteLine("Input new pet sold date (format MM-DD-YYYY)");
                        string Read = Console.ReadLine();

                        if (string.IsNullOrEmpty(Read))
                        {
                            newSoldDate = petlist[Id].SoldDate;
                        }
                        else
                        {
                            newSoldDate = DateTime.Parse(Read);
                        }

                        Console.WriteLine("Input new pet colour");
                        newColour = Console.ReadLine();

                        if (string.IsNullOrEmpty(newColour))
                        {
                            newColour = petlist[Id].Colour;
                        }

                        Console.WriteLine("Input new pet owner");
                        newPrevOwner = Console.ReadLine();

                        if (string.IsNullOrEmpty(newPrevOwner))
                        {
                            newPrevOwner = petlist[Id].PreviousOwner;
                        }

                        Console.WriteLine("Input new pet price");
                        readline = Console.ReadLine();

                        if (string.IsNullOrEmpty(readline))
                        {
                            newPrice = petlist[Id].Price;
                        }
                        else
                        {
                            newPrice = double.Parse(readLine);
                        }

                        Pet editPet = new Pet(newName, newType, newBD, newSoldDate, newColour, newPrevOwner, newPrice);
                        int petid = 0;
                        Id = petid;
                        if (_PetService.EditPet(petid, editPet) != null)
                        {
                            Console.WriteLine(newName + " Has been edited!");
                            Console.WriteLine("--------------------------------------------------\n");
                        }
                        else
                        {
                            Console.WriteLine(newName + " Has not been edited!");
                            Console.WriteLine("Something went wrong, try again!");
                            Console.WriteLine("--------------------------------------------------\n");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Delete existing pet");
                        Console.WriteLine("--------------------------------------------------\n");
                        Console.WriteLine("Input pet ID");
                        readLine = Console.ReadLine();
                        int id = int.Parse(readLine);
                        petlist = _PetService.GetPets();
                        if (id > petlist.Count)
                        {
                            throw new IndexOutOfRangeException();
                        }

                        else
                        {
                            Console.WriteLine(petlist[id] + " Deleted!");
                            _PetService.Delete(id);
                        }

                        Console.WriteLine("--------------------------------------------------\n");

                        break;

                    case 5:
                        Console.WriteLine("Inspect pet by ID");
                        Console.WriteLine("--------------------------------------------------\n");
                        Console.WriteLine("Input pet ID");
                        petlist = _PetService.GetPets();
                        readLine = Console.ReadLine();
                        id = int.Parse(readLine);

                        if (id > petlist.Count)
                        {
                            throw new IndexOutOfRangeException();
                        }

                        else
                        {
                            Console.WriteLine(petlist[id]);
                        }

                        Console.WriteLine(petlist[id].Name + " displaying!");
                        break;

                    case 6:
                        Console.WriteLine("Search by pet type");
                        Console.WriteLine("--------------------------------------------------\n");
                        Console.WriteLine("please select the type of pet you want\n");
                        Console.WriteLine("1: Dog");
                        Console.WriteLine("2: Cat");
                        Console.WriteLine("3: Dragon");
                        Console.WriteLine("4: Goat");
                        Console.WriteLine("--------------------------------------------------\n");

                        int s;
                        while (!int.TryParse(Console.ReadLine(), out s) || s < 1 || s > 4)
                        {
                            Console.WriteLine("please select a number between 1-4");
                        }
                        List<Pet> pets = _PetService.GetPets();
                        List<Pet> searchPet;

                        if (s.Equals(1))
                        {
                            searchPet = pets.FindAll(pet => pet.Type.Equals("Dog"));
                        }
                        else if (s.Equals(2))
                        {
                            searchPet = pets.FindAll(pet => pet.Type.Equals("Cat"));
                        }
                        else if (s.Equals(3))
                        {
                            searchPet = pets.FindAll(pet => pet.Type.Equals("Dragon"));
                        }
                        else
                        {
                            searchPet = pets.FindAll(pet => pet.Type.Equals("Goat"));
                        }

                        foreach (var pet in searchPet)
                        {
                            Console.WriteLine(pet.ToString());
                            Console.WriteLine("--------------------------------------------------\n");
                        }
                        break;

                    case 7:
                        Console.WriteLine("Sort pets by price");
                        Console.WriteLine("--------------------------------------------------\n");
                        petlist = _PetService.GetPets();
                        petlist = petlist.OrderBy(o => o.Price).ToList();
                        petlist.ForEach(i => Console.WriteLine(i.ToString()));
                        Console.WriteLine("--------------------------------------------------\n");
                        break;

                    case 8:
                        Console.WriteLine("Show 5 cheapest pets");
                        Console.WriteLine("--------------------------------------------------\n");
                        petlist = _PetService.GetPets();
                        petlist = petlist.OrderBy(o => o.Price).ToList();
                        if (petlist.Count < 5)
                        {
                            petlist.ForEach(i => Console.WriteLine(i.ToString()));
                        }
                        else { 
                        for (int i = 0; i < 4; i++)
                        {
                            Console.WriteLine(petlist[i].ToString());
                        }
                        }
                        Console.WriteLine("End of list...");
                        Console.WriteLine("--------------------------------------------------\n");
                        break;

                    case 0:
                        Console.WriteLine("Exit has been chosen...");
                        Console.WriteLine("Bye!");
                        Console.WriteLine("--------------------------------------------------\n");
                        break;

                    default:

                        Console.WriteLine("Oops, unknown command!");
                        Console.WriteLine("Try again please!");
                        Console.WriteLine("--------------------------------------------------\n");

                        break;
                }
            }
        }

        private void MainMenu()
        {
            Console.WriteLine("1: Create new pet");
            Console.WriteLine("2: List all existing pets");
            Console.WriteLine("3: Edit existing pet");
            Console.WriteLine("4: Delete existing pet");
            Console.WriteLine("5: Inspect pet by ID");
            Console.WriteLine("6: Search by pet type");
            Console.WriteLine("7: Sort pets by price");
            Console.WriteLine("8: Show 5 cheapest pets");
            Console.WriteLine("0: Exit program");
            Console.WriteLine("--------------------------------------------------\n");
            Console.WriteLine("Input your command...");
        }
    }
}
