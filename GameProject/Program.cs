using System;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Gamer gamer = new Gamer()
            {
                NationalityId = 12345,
                FirstName = "Murat",
                LastName = "ZEYBEK",
                DateOfBirth = 1982
            };

            GamerManager gamerManager = new GamerManager(new ValidationManager());
            gamerManager.Add(gamer);
        }
    }
}
