using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMove = false;
            bool isDead = false;
            int baseSpeed = 10;
            float multiplierSpeed = 0.5f;
            float currentSpeed = baseSpeed * multiplierSpeed;
            string playerName = "None";
            double playerMoney = 100;
            float playerHealth = 100f;
            float playerDamage = 5f;
            float playerAttackSpeed = 1f;

            Console.Write(currentSpeed);
        }
    }
}

    
