using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowDamageConsole
{
    class ArrowDamage : WeaponDamage
    {
        /// <summary>
        /// Конструктор вычисляет повреждения для значений Magic и Flaming по умолчанию 
        /// и начального броска 1d6.
        /// </summary>
        /// <param name="startingRoll">Начальный бросок 1d6</param>
        public ArrowDamage(int startingRoll) : base(startingRoll) { }

        private const decimal BASE_MULTIPLIER = 0.35M;
        private const decimal MAGIC_MULTIPLIER = 2.5M;
        private const decimal FLAME_DAMAGE = 1.25M;


        protected override void CalculateDamage()
        {
            decimal baseDamage = Roll * BASE_MULTIPLIER;
            if (Magic) baseDamage *= MAGIC_MULTIPLIER;
            if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
            else Damage = (int)Math.Ceiling(baseDamage);
        }
    }
}
