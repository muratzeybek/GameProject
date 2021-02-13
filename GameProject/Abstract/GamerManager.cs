using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    class GamerManager : IGamerService
    {
        IValidationService _validationService;

        public GamerManager(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            if (_validationService.GamerValidate(gamer)) // veya ...(gamer)==true)) default u true dur.
            {
                Console.WriteLine("Gamer is saed.");
            }
            else
            {
                Console.WriteLine("Invalid gamer...");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer is deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is updated.");
        }
    }
}
