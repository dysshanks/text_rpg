namespace text_game
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to my text based rpg pls insert a name: ");
            string name = Console.ReadLine();
            
            player player = new player();
            player.name = name;
            player.lvl = 1;
            player.hp = 100;
            player.mp = 30;
            player.def = 7;
            
            Console.WriteLine($"hello {player.name}");
        }

        public class player
        {
            public string name;
            public int score;
            public int lvl;
            public int hp;
            public int mp;
            public int def;
            public int atk;
            public int ballance;
        }
    }
}