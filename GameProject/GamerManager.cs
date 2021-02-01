using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // MicroService
    
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true
            {
                Console.WriteLine("kayit oldunuz");
            }
            else
            {
                Console.WriteLine("dogrulama basarisiz, kayit basarisiz");
            }

            



        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kayit guncelendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kayit silindi");
        }
    }
}
