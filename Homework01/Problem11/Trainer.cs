namespace Homework01.Problem11
{
    using System.Collections.Generic;
    using System.Linq;

    class Trainer
    {
        private const decimal TournamentDamage = 10.0m;
        private int badgesCount;
        public List<Pokemon> Pockemons { get; set; }
        public int Order { get; }

        public Trainer(string name, Pokemon pokemon, int order)
        {
            Name = name;
            badgesCount = 0;
            Pockemons = new List<Pokemon>();
            Pockemons.Add(pokemon);
            Order = order;
        }

        public int BadgesCount
        {
            get { return this.badgesCount; }
            set { this.badgesCount = value; }
        }

        private string Name { get; }

        public void StartTournament(string element)
        {
            int pokemonsCount = Pockemons.Count(p => p.Element == element);
            if (pokemonsCount > 0)
            {
                badgesCount += 1;
            }
            else
            {
                HitPokemons(TournamentDamage);
                CleanPockemons();
            }
        }

        private void HitPokemons(decimal damage)
        {
            foreach (Pokemon pokemon in Pockemons)
            {
                pokemon.Health -= damage;
            }
        }

        private void CleanPockemons()
        {
            Pockemons = Pockemons
                .Where(p => p.Health > 0)
                .ToList();
        }

        public override string ToString()
        {
            return $"{Name} {badgesCount} {Pockemons.Count}";
        }
    }
}
