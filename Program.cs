using System;
using System.Transactions;

namespace myProject
{
    class Game
    {
        private int _Id;
        private string _Title;
        private string _Publisher;
        private static int _Transactions = 0;

        public Game()
        {
            _Id = 0;
            _Title = "";
            _Publisher = "";
        }

        public Game(int id, string title, string publisher)
        {
            _Id = id;
            _Title = title;
            _Publisher = publisher;
        }

        public void SetTrans()
        {
            _Transactions++;
        }
        public int GetTrans()
        {
            return _Transactions;
        }

        public int GetId() { return _Id; }
        public string GetTitle() { return _Title; }
        public string GetPublisher() { return _Publisher; }

        public void SetId(int id) { _Id = id; }
        public void SetTitle(string title) { _Title = title; }
        public void SetPublisher(string publisher) { _Publisher = publisher; }
    }

    class myGameStore
    {
        static void Main(string[] args)
        {
            // Default Constructor
            Game witcher = new Game();
            witcher.SetId(1);
            witcher.SetTitle("Witcher 3");
            witcher.SetPublisher("CD Projekt Red");
            witcher.SetTrans();

            //Default user entered Constructor
            Game user = new Game();
            Console.WriteLine("Please enter in a game ID:");
            user.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter in a game Title");
            user.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter in a game publisher");
            user.SetPublisher(Console.ReadLine());
            user.SetTrans();
            Console.WriteLine();

            //Parameterized Constructoor
            Game ff7 = new Game(3, "Final Fantasy 7", "Square Enix");
            ff7.SetTrans();

            //Parameterized user entered Constructor
            Console.WriteLine("Please enter in a game ID:");
            int paraId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in a game Title:");
            string paraTitle = Console.ReadLine();
            Console.WriteLine("Please enter in a game publisher:");
            string paraPublisher = Console.ReadLine();
            Game para = new Game(paraId, paraTitle, paraPublisher);
            para.SetTrans();
            Console.WriteLine();

            //Calling Objects
            Console.WriteLine();
            displayBooks(witcher);
            Console.WriteLine();
            displayBooks(user);
            Console.WriteLine();
            displayBooks(ff7);

            Console.WriteLine();
            displayBooks(para);
            Console.WriteLine();
            Console.WriteLine($"There is a total of {witcher.GetTrans()} transactions");
        }

        static void displayBooks(Game game)
        {
            Console.WriteLine("Here is your game:");
            Console.WriteLine($"Game ID: {game.GetId()}");
            Console.WriteLine($"Game Title: {game.GetTitle()}");
            Console.WriteLine($"Game Publisher: {game.GetPublisher()}");
        }
    }
}
