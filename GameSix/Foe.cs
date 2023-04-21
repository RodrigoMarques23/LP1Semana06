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
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }
        public float GetHealth()
        {
            return health;
        }
        public float GetShield()
        {
            return shield;
        }
        public void SetName(string name)
        {
            this.name = name.Trim();
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
        public void PickUpPowerUp(PowerUp.PowerUps power, float x)
        {
            if (power == PowerUp.PowerUps.Health)
            {
                health += x;

                if (health > 100)
                {
                    health = 100;
                }
            }
            else if (power == PowerUp.PowerUps.Shield)
            {
                shield += x;

                if (shield > 100)
                {
                    shield = 100;
                }
            }
        }
    }
}