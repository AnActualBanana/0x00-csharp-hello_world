using System;

namespace Enemies
{
    ///<summary> Zombie Class. </summary>
    public class Zombie
    {
        ///<summary> zombie's health. </summary>
        private int health;
        ///<summary> default constructor for zombie. </summary>
        public Zombie()
        {
            health = 0;
        }
        ///<summary> constructor for zombie with custom health value. </summary>
        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
        ///<summary> method that returns the value of health of the Zombie object. </summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
