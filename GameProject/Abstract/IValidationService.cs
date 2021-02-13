using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IValidationService
    {
        public bool GamerValidate(Gamer gamer);
    }
}
