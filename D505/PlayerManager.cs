using System;
using System.Collections.Generic;
using System.Text;

namespace D5O5
{
    class PlayerManager : IPlayerService
    {
        IUserValidationService _userValidationService;

        public PlayerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Player player)
        {
            if(_userValidationService.Validate(player)==true)
            {
                Console.WriteLine("Kayıt oldu");

            }
            else
            {
                Console.WriteLine("Doğrulama yapılamadı.Kayıt Başarısız.");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kayıt Silindi");
           
        }

        public void Update(Player player)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
