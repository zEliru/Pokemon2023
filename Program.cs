namespace Pokemon2023
{
    internal class Program
    {
        static void Main(string[] args) 
        { //commit test
            Pokemon[] arrayOfPokemons = PokemonVendingMachine();
            Pokemon firstPokemon = arrayOfPokemons[0];
            Pokemon secondPokemon = arrayOfPokemons[0];
            int choice;
            int countOfPokemons = 0;


            bool gameReadyToStart = false;
            while (!gameReadyToStart)
            {
                try 
                {
                    Console.WriteLine("Choose your pokemon. 1 for bulb, 2 for charmander");
                    choice = Convert.ToInt32(Console.ReadLine());
                    countOfPokemons++;
                    if (countOfPokemons == 1) firstPokemon = arrayOfPokemons[choice - 1];
                    else if (countOfPokemons == 2) secondPokemon = arrayOfPokemons[choice - 1];
                    gameReadyToStart = countOfPokemons == 2;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please, start over. Read carefully.");
                    countOfPokemons = 0;

                }


            }

            GameStart(firstPokemon, secondPokemon);


        }




        public static Pokemon[] PokemonVendingMachine()
        {
            Pokemon[] vendingMachine = new Pokemon[100];
            Spell[] arrayOfSpells = CreateSpells();
            Stats[] myPokemonStats = StatsVendingMachine();
            Pokemon bulbasaur = new();
            

            bulbasaur.Id = 1;
            bulbasaur.Name = "Bulbasaur";
            bulbasaur.Type = "grass";

            bulbasaur.PokemonStats = myPokemonStats[0];
            //bulbasaur.stats.health = 69;
            //bulbasaur.stats.damage = 69;
            //bulbasaur.stats.defense = 69;
            bulbasaur.PokemonSpells = arrayOfSpells[1];
            vendingMachine[0] = bulbasaur;


            Pokemon charmander = new();
            charmander.Id = 2;
            charmander.Name = "Charmander";
            charmander.Type = "fire";
            charmander.PokemonStats = myPokemonStats[1];
            charmander.PokemonSpells = arrayOfSpells[2];

            vendingMachine[1] = charmander;



            return vendingMachine;





        }
        public static Spell[] CreateSpells()
        {
            Spell[] spells = new Spell[100];
            Spell admin = new ();
            admin.Id = 0;
            admin.Name = "admin";
            admin.Power = 69696969;
            admin.Type = "psychic";
            spells[0] = admin;

            Spell tackle = new();


            tackle.Id = 1;
            tackle.Name = "tackle";
            tackle.Power = 15;
            tackle.Type = "normal";
            spells[1] = tackle;

            Spell frenzyPlant = new();

            frenzyPlant.Id = 2;
            frenzyPlant.Name = "Frenzy Plant";
            frenzyPlant.Power = 69;
            frenzyPlant.Type = "grass";
            spells[2] = frenzyPlant;



            return spells;

        }
        public static Stats[] StatsVendingMachine()
        {
            Stats[] arrayOfStats = new Stats[2];
            Stats bulbStats = new(69, 69, 69);
            arrayOfStats[0] = bulbStats;

            Stats charmanderStats = new(68, 68, 68);
            arrayOfStats[1] = charmanderStats;

            return arrayOfStats;


            
        }
        public static void GameStart(Pokemon ally, Pokemon enemy) {
            Console.WriteLine($"{ally.Name} vs {enemy.Name}");
            //Console.WriteLine($"{ally.PokemonStats.damage}"); --Creates a warning because it may be null
        }



    }
}