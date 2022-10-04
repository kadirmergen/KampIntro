using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==1997 && gamer.FirstName=="Kadir" 
                && gamer.LastName=="Mergen" && gamer.IdentityNumber==12345)
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
