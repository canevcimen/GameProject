using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName =="Can" && gamer.LastName == "Evcimen" && gamer.IdentityNumber=="123456" && gamer.Id==1 )
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
