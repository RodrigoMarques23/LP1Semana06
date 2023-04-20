namespace GameSix
{
    public class Foe
    {
        private string name;//var name
        private float health;//var health
        private float shield;//var shield
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Foe(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}