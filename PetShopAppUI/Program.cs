using PetShopApp.Core.AppService;
using PetShopApp.Infrastructure.Data;
using PetShopApp.Core.DomainService;
using System;
using PetShopApp.Core.AppService.Impl;

namespace PetShopAppUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            FakeDB _fakeDB = new FakeDB();
            _fakeDB.InitData();
            IPetRepository petRepository = new PetRepository();
            IPetService petService = new PetService(petRepository);
            Printer printer = new Printer(petService);
            printer.Print();

        }
    }
}
