using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrowDamageConsole
{
    class SwordDamage : WeaponDamage
    {
        /// <summary>
        /// Конструктор вычисляет повреждения для значений Magic и Flaming по умолчанию 
        /// и начального броска 3d6.
        /// </summary>
        /// <param name="startingRoll">Начальный бросок 3d6</param>
        public SwordDamage(int startingRoll) : base(startingRoll) { }

        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        protected override void CalculateDamage()
        {
            decimal magicMultiplier = 1M;
            if (Magic) magicMultiplier = 1.75M;

            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
            if (Flaming) Damage += FLAME_DAMAGE;
        }
    }
}
