using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    class ValidationManager : IValidationService
    {
        public bool GamerValidate(Gamer gamer)
        {
            if (gamer.NationalityId==12345 && gamer.FirstName =="Murat" && gamer.LastName=="ZEYBEK" && gamer.DateOfBirth==1982)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
