namespace RoleplayGame

{
    public class Enemy: Character
    {
        public int VpValue { get; set; }

        public Enemy (string name, int vpValue)
        : base(name)
        {
            this.VpValue =vpValue; 
        }
    }

}