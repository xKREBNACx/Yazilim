using System;
using System.Collections.Generic;
using System.Text;

namespace D5O5
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            if(player.Id==1 &&
                player.BirthYear==1996 && 
                player.Name=="CANBERK" &&
                player.Surname=="MUZCUOĞLU" &&
                player.IdentityNumber==33333333333)
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
