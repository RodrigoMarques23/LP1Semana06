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

        public string GetName()
        {
            return name;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;

            }
        }
    }
}