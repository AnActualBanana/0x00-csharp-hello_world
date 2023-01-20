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
        ///<summary> name </summary>
        private string name = "(No name)";
        ///<summary> name property(getter and setter) </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        ///<summary> method that returns the value of health of the Zombie object. </summary>
        public int GetHealth()
        {
            return health;
        }
        ///<summary> override that prints the Zombie object's attributes to stdout </summary>
        public override string ToString()
        {
            return String.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
