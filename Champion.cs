namespace desafio_combate
{
    public class Champion
    {
        private string name;
        private int life;
        private int attack;
        private int armor;

        public Champion(string name, int life, int attack, int armor)
        {
            this.name = name;
            this.life = life;
            this.attack = attack;
            this.armor = armor;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Life
        {
            get { return life; }
            set { life = value; }
        }

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }

        public void TakeDamage(Champion other)
        {
            if (this.armor >= other.attack)
            {
                this.life -= 1;
            }
            else
            {
                this.life -= (other.attack - this.armor);
            }

            if (this.life < 0)
            {
                this.life = 0;
            }
        }

        public string Status()
        {
            if (life > 0)
            {
                return $"{name} : {life} de vida";
            }
            else
            {
                return $"{name} : {life} de vida (morreu)";
            }
        }
    }
}