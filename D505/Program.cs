using System;

namespace D5O5
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new UserValidationManager());
            playerManager.Add(new Player {
                Id = 1, 
                BirthYear = 1996,
                Name="CANBERK",
                Surname="MUZCUOĞLU",
                IdentityNumber=33333333333 });
          
        }
    }
}
