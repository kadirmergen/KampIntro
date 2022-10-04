using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    internal interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
