

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ШалаевИльяАлексеевич_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Puzzle p = new Puzzle("Mt. Lyell with Mt. Maclure in the foreground", 2016, "Flat Puzzles", "Normal", 88);
            p.Message();

            Shooter s = new Shooter("BattleField V", 2018, "FPS shooter", 64, "fighting game using WWII weapons");
            s.Message();

            MOBA m = new MOBA("League of Legends", 2009, "Two teams of players fight each other, controlling a character with unique characteristics", 10, "1,034,058");
            m.Message();

            RPG r = new RPG("Elden Ring", 2022, "The player controls one or more characters, each of which is described by a set of numerical characteristics, a list of abilities and skills", "RPG - sandbox", "TPP");
            r.Message();

            Strategy st = new Strategy("Hearts of Iron IV", 2016, "Focuses on World War II. The player can take under his rule any state on Earth that existed during one of the scenarios and lead it to victory or defeat in the war", "WWII", "1300rub");
            st.Message();
            Console.ReadLine();
            
        }


        public class Puzzle
        {
            private string Name;
            public int Year;
            public string TypeOfGame;
            public string Difficulty;
            public int CountsOfParts;

            public Puzzle(string name, int year, string typeOfGame, string difficulty, int countsofpart)
            {
                Name = name;
                Year = year;
                TypeOfGame = typeOfGame;
                Difficulty = difficulty;
                CountsOfParts = countsofpart;

            }
            public void Message()
            {
                Console.WriteLine("===============");
                Console.WriteLine("This genre of game — Puzzle");
                Console.WriteLine(Name);
                Console.WriteLine(Year);
                Console.WriteLine(TypeOfGame);
                Console.WriteLine(Difficulty);
                Console.WriteLine(CountsOfParts);
                Console.WriteLine("===============");
            }


        }

        public class Shooter
        {
            private string Name;
            public int Year;
            public string TypeOfGame;
            public int NumberOfPlayers;
            private int LivePlayerCount;
            public string Gameplay;


            public Shooter(string name, int year, string typeOfGame, int numberOfPlayers, string gameplay)
            {
                Name = name;
                Year = year;
                TypeOfGame = typeOfGame;
                NumberOfPlayers = numberOfPlayers;
                Gameplay = gameplay;


            }

            public void Message()
            {

                Console.WriteLine("This genre of game — Shooter");
                Console.WriteLine(Name);
                Console.WriteLine(Year);
                Console.WriteLine(TypeOfGame);
                Console.WriteLine(NumberOfPlayers);
                Console.WriteLine(Gameplay);
                Console.WriteLine("===============");
            }

        }

        public class MOBA
        {
            private string Name;
            public int Year;
            public string Gameplay;
            public int NumberOfPlayers;
            public string LivePlayerCount;




            public MOBA(string name, int year, string gameplay, int numbersOfPlayers, string livePlayerCount)
            {
                Name = name;
                Year = year;
                Gameplay = gameplay;
                NumberOfPlayers = numbersOfPlayers;
                LivePlayerCount = livePlayerCount;



            }

            public void Message()
            {

                Console.WriteLine("This genre of game — MOBA");
                Console.WriteLine(Name);
                Console.WriteLine(Year);
                Console.WriteLine(Gameplay);
                Console.WriteLine(NumberOfPlayers);
                Console.WriteLine(LivePlayerCount);
                Console.WriteLine("===============");


            }
        }
        public class RPG
        {
            private string Name;
            public int Year;
            public string Gameplay;
            public string Classification;
            public string PerspectiveOfTheGame;


            public RPG(string name, int year, string gamaplay, string classification, string perspectiveOfTheGame)
            {
                Name = name;
                Year = year;
                Gameplay = gamaplay;
                Classification = classification;
                PerspectiveOfTheGame = perspectiveOfTheGame;
            }
            public void Message()
            {

                Console.WriteLine("This genre of game — RPG");
                Console.WriteLine(Name);
                Console.WriteLine(Year);
                Console.WriteLine(Gameplay);
                Console.WriteLine(Classification);
                Console.WriteLine(PerspectiveOfTheGame);
                Console.WriteLine("===============");

            }
        }

        public class Strategy
        {
            private string Name;
            public int Year;
            public string Gameplay;
            public string History;
            public string Price;


            public Strategy(string name, int year, string gameplay, string history, string price)
            {
                Name = name;
                Year = year;
                Gameplay = gameplay;
                History = history;
                this.Price = price;
            }
        public void Message()
            {
                Console.WriteLine("This genre of game — Strategy");
                Console.WriteLine(Name);
                Console.WriteLine(Year);
                Console.WriteLine(Gameplay);
                Console.WriteLine(History);
                Console.WriteLine(Price);
                Console.WriteLine("===============");
                Console.WriteLine("Will 1PIOSP be able to make a game related to ranepa?....");
            }
        }
    }
}







