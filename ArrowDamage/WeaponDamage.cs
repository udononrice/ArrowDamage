using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowDamageConsole
{
    abstract class WeaponDamage
    {
        /// <summary>
        /// Конструктор вычисляет повреждения для значений Magic и Flaming по умолчанию 
        /// и начального броска.
        /// </summary>
        /// <param name="startingRoll">Начальный бросок</param>
        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        /// <summary>
        /// Содержит рассчитаный урон.
        /// </summary>
        public int Damage { get; protected set; }

        /// <summary>
        /// Содержит случайно сгенерированное число.
        /// </summary>
        private int roll;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// True если оружие волшебное; False в противном случае.
        /// </summary>
        private bool magic;
        public bool Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }

        /// <summary>
        /// True если оружие огненное; False в противном случае.
        /// </summary>
        private bool flaming;
        public bool Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }

        protected abstract void CalculateDamage();
    }
}
