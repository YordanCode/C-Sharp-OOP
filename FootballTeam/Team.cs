using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeam
{
    public class Team
    {
        private string name;
        private readonly List<Player> players;
        public Team(string name)
        {
            this.Name = name;
            this.players = new();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        public int Rating => this.players.Count > 0 ? (int)Math.Round(this.players.Average(p => p.SkillLevel)) : 0;
        public void AddPlayer(Player player) 
            => this.players.Add(player);
        public bool RemovePlayer(string playerName)
        {
            Player playerToRemove = this.players.FirstOrDefault(p => p.Name == playerName);
            if (playerToRemove != null)
            {
                this.players.Remove(playerToRemove);
                return true;
            }
            return false;
            ;
        }
    }
}
