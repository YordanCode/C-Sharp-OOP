using System;

namespace FootballTeam
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Player(string name, int endurance, int sprint, int dribble,
            int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("A name should not be empty.");
                this.name = value;
            }
        }
        public int Endurance
        {
            get => this.endurance;
            private set { this.ValidateStat("Endurance", value); this.endurance = value; }
        }
        public int Sprint
        {
            get => this.sprint;
            private set { this.ValidateStat("Sprint", value); this.sprint = value; }
        }
        public int Dribble
        {
            get => this.dribble;
            private set { this.ValidateStat("Dribble", value); this.dribble = value; }
        }
        public int Passing
        {
            get => this.passing;
            private set { this.ValidateStat("Passing", value); this.passing = value; }
        }
        public int Shooting
        {
            get => this.shooting;
            private set { this.ValidateStat("Shooting", value); this.shooting = value; }
        }

        public double SkillLevel => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
        private void ValidateStat(string statName, int value)
        {
            if (value < 0 || value > 100)
                throw new ArgumentException($"{statName} should be between 0 and 100.");
        }
    }
}

