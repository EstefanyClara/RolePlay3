using System.Collections.Generic; 
namespace RoleplayGame
{
    public class Hero: Character
    {

        public int acumulaVp
        {
            get
            {
                return this.acumulaVp; 
            }
            set
            {
                this.acumulaVp=value; 
            }
        }

        public Hero(string name)
        : base(name)
        {
        }
        public void AddVp(Enemy enemy)
        {
            this.acumulaVp += enemy.VpValue; 
        }
    }
}