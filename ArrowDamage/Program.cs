using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowDamageConsole
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage(RollDice(3));
            ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));

            while (true)
            {
                Console.Write("0 без магического/огненного урона, 1 для магического, " +
                    "2 для огненного, 3 для магического и огненного, что-нибудь другое для выхода: ");
                char key = Console.ReadKey(false).KeyChar;
                if (key != '0' && key != '1' && key != '2' && key != '3') return;

                Console.Write("\nS для меча, A для лука, что-либо ещё для выхода: ");
                char weaponKey = Char.ToUpper(Console.ReadKey().KeyChar);

                switch(weaponKey)
                {
                    case 'S':
                        swordDamage.Roll = RollDice(3);
                        swordDamage.Magic = (key == '1' || key == '3');
                        swordDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"\nВыпало {swordDamage.Roll} для урона на {swordDamage.Damage}HP");
                        break;

                    case 'A':
                        arrowDamage.Roll = RollDice(1);
                        arrowDamage.Magic = (key == '1' || key == '3');
                        arrowDamage.Flaming = (key == '2' || key == '3');
                        Console.WriteLine($"\nВыпало {arrowDamage.Roll} для урона на {arrowDamage.Damage}HP");
                        break;

                    default:
                        return;
                }
            }
        }

        private static int RollDice(int numberOfRolls)
        {
            int total = 0;
            for (int i = 0; i < numberOfRolls; i++) total += random.Next(1, 7);
            return total;
        }
    }
}
