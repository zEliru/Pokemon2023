namespace Pokemon2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon[] arrayOfPokemons = PokemonVendingMachine();
            Pokemon firstPokemon = arrayOfPokemons[0];
            Pokemon secondPokemon = arrayOfPokemons[0];
            int choice = 0;
            int countOfPokemons = 0;


            bool gameReadyToStart = false;
            while (!gameReadyToStart) 
            {
                try {
                    Console.WriteLine("Choose your pokemon. 1 for bulb, 2 for charmander");
                    choice = Convert.ToInt32(Console.ReadLine());
                    countOfPokemons++;
                    if (countOfPokemons == 1) firstPokemon = arrayOfPokemons[choice-1];
                    else if (countOfPokemons == 2) secondPokemon= arrayOfPokemons[choice-1];
                    gameReadyToStart = countOfPokemons == 2;
                }
                catch(Exception e)
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
            Pokemon bulbasaur = new Pokemon();
            Stats bulbasaurStats = new Stats();
            
            bulbasaur.id = 1;
            bulbasaur.name = "Bulbasaur";
            bulbasaur.type = "grass";
            bulbasaurStats.health = 69;
            bulbasaurStats.damage = 69;
            bulbasaurStats.defense = 69;
            bulbasaur.stats = bulbasaurStats;
            //bulbasaur.stats.health = 69;
            //bulbasaur.stats.damage = 69;
            //bulbasaur.stats.defense = 69;
            bulbasaur.spells = arrayOfSpells[1];
            vendingMachine[0] = bulbasaur;


            Pokemon charmander = new Pokemon();
            charmander.id = 2;
            charmander.name = "Charmander";
            charmander.type = "fire";
            //charmander.stats.health = 69;
            //charmander.stats.damage = 69;
            //charmander.stats.defense = 69;
            charmander.spells = arrayOfSpells[2];

            vendingMachine[1] = charmander;



            return vendingMachine;





        }
        public static Spell[] CreateSpells()
        {
            Spell[] spells = new Spell[100];
            Spell admin = new Spell();
            admin.id = 0;
            admin.name = "admin";
            admin.power = 69696969;
            admin.type = "psychic";
            spells[0] = admin;

            Spell tackle = new Spell();

           
            tackle.id = 1;
            tackle.name = "tackle";   
            tackle.power = 15;
            tackle.type = "normal";
            spells[1] = tackle;

            Spell frenzyPlant = new Spell();
           
            frenzyPlant.id = 2;
            frenzyPlant.name = "Frenzy Plant";
            frenzyPlant.power = 69;
            frenzyPlant.type = "grass";
            spells[2] = frenzyPlant;



            return spells;
          
        }

        public static void GameStart(Pokemon ally, Pokemon enemy) {
            Console.WriteLine($"{ally.name} vs {enemy.name}");
        }



    }
}