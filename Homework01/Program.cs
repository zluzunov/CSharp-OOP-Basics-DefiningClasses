namespace Homework01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Problem11;

    public class Program
    {
        static void Main()
        {
            string startCommand = "Tournament";
            string endCommand = "End";

            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input;
            while ((input=Console.ReadLine())!= startCommand)
            {
                string[] trainerData = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                string trainerName = trainerData[0];
                string pokemonName = trainerData[1];
                string pokemonElement = trainerData[2];
                decimal pokemonHealth = decimal.Parse(trainerData[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers[trainerName] = new Trainer(trainerName, pokemon, trainers.Count);
                }
                else
                {
                    trainers[trainerName].Pockemons.Add(pokemon);
                }
            }

            while ((input = Console.ReadLine()) != endCommand)
            {
                

                foreach (Trainer trainer in trainers.Values)
                {
                    trainer.StartTournament(input);
                }
            }

            IOrderedEnumerable<Trainer> orderedTrainers = trainers.Values
                .OrderByDescending(t => t.BadgesCount)
                .ThenBy(t => t.Order);

            foreach (Trainer trainer in orderedTrainers)
            {
                Console.WriteLine(trainer);
            }
        }
    }
}




