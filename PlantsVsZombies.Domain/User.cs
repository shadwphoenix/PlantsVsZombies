using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantsVsZombies.Domain
{
    internal class User
    {
        public String UserName { get; }
        public String Password { get; set; }
        public decimal Coin { get; private set; }

        public User(String userName, String password)
        {
            UserName = userName;
            Password = password;
        }

        //private List<Plant> plantCollection { get; }
        //private List<Zombie> zombieCollection { get; }

        public void IncreaseCoin(decimal amount)
        {

        }

        private void decreaseCoin(decimal amount)
        {

        }

    }
}
