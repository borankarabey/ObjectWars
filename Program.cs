using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace LordoftheRings
{
    public class Player
    {
        public class WhiteTeam
        {
            public int Health { get; set; }
            public int Power { get; set; }
            public int Strategy { get; set; }
            public int Magic { get; set; }

            public Hobbits(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 40;
                Power = power;
                power = 60;
                Strategy = strategy;
                strategy = 90;
                Magic = magic;
                magic = 0;
            }

            public Elves(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 80;
                Power = power;
                power = 90;
                Strategy = strategy;
                strategy = 80;
                Magic = magic;
                magic = 20;
            }

            public Humans(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 70;
                Power = power;
                power = 80;
                Strategy = strategy;
                strategy = 80;
                Magic = magic;
                magic = 0;
            }

            public Midgets(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 60;
                Power = power;
                power = 90;
                Strategy = strategy;
                strategy = 40;
                Magic = magic;
                magic = 0;
            }
        }


        public class BlackTeam
        {
            public int Health { get; set; }
            public int Power { get; set; }
            public int Strategy { get; set; }
            public int Magic { get; set; }

            public Orgs(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 70;
                Power = power;
                power = 85;
                Strategy = strategy;
                strategy = 40;
                Magic = magic;
                magic = 0;
            }

            public Goblins(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 40;
                Power = power;
                power = 50;
                Strategy = strategy;
                strategy = 20;
                Magic = magic;
                magic = 0;
            }

            public BlackGhosts(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 70;
                Power = power;
                power = 90;
                Strategy = strategy;
                strategy = 30;
                Magic = magic;
                magic = 30;
            }
        }


        public class Magicians
        {
            public int Health { get; set; }
            public int Power { get; set; }
            public int Strategy { get; set; }
            public int Magic { get; set; }

            public Gandalf(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 40;
                Power = power;
                power = 60;
                Strategy = strategy;
                strategy = 95;
                Magic = magic;
                magic = 95;
            }

            public Saruman(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 40;
                Power = power;
                power = 60;
                Strategy = strategy;
                strategy = 90;
                Magic = magic;
                magic = 1000;
            }

            public Groot(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 50;
                Power = power;
                power = 50;
                Strategy = strategy;
                strategy = 85;
                Magic = magic;
                magic = 80;
            }

            public Dragon(int health, int power, int strategy, int magic)
            {
                Health = health;
                health = 70;
                Power = power;
                power = 50;
                Strategy = strategy;
                strategy = 25;
                Magic = magic;
                magic = 80;
            }
        }
    }

public void TeamSelection()
{
    selection = Console.WriteLine(" Please select your team.\n");
    Console.ReadLine(selection);

    if (selection = "1")
    {
        Console.WriteLine(" Now you are in the Brotherhood of the Ring.");
        WhiteTeamMenu();
    }
    else if (selection = "2")
    {
        Console.WriteLine(" Now you are in the Army of the Eye.");
        BlackTeamMenu();
    }
    else if (selection = "3")
    {
        Console.WriteLine(" Now you are in the Mighty Five Magicians.");
        MagiciansTeamMenu();
    }
    else
    {
        Console.WriteLine(" Error occured, please try again.");
        FirstMenu();
    }
}

public void PlayerSelectionWhiteTeam()
{
    int selection = Console.WriteLine(" Please select a race.\n");
    Console.ReadLine(selection);

    if (selection = "1")
    {
        Console.WriteLine(" Your character is Frodo. Wait for your enemy.\n");
        selection = WhiteTeam.Hobbits;
        ThirdMenu();
    }
    else if (selection = "2")
    {
        Console.WriteLine(" Your character is Legolas. Wait for your enemy.\n");
        selection = WhiteTeam.Elves;
        ThirdMenu();
    }
    else if (selection = "3")
    {
        Console.WriteLine(" Your character is Aragon. Wait for your enemy.\n");
        selection = WhiteTeam.Humans;
        ThirdMenu();
    }
    else if (selection = "4")
    {
        Console.WriteLine(" Your character is Ronin. Wait for your enemy.\n");
        selection = WhiteTeam.Midgets;
        ThirdMenu();
    }
    else
    {
        Console.WriteLine(" Error accured, please try again.");
        WhiteTeamMenu();
    }
}

public void PlayerSelectionBlackTeam()
{
    selection = Console.WriteLine(" Please select a race.\n");
    Console.ReadLine(selection);

    if (selection == "1")
    {
        Console.WriteLine(" Your character is Org Commander. Wait for your enemy.\n");
        selection = BlackTeam.Orgs;
        FourthMenu();
    }
    else if (selection == "2")
    {
        Console.WriteLine(" Your character is Fat Goblin King. Wait for your enemy.\n");
        selection = BlackTeam.Goblins;
        FourthMenu();
    }
    else if (selection == "3")
    {
        Console.WriteLine(" Your character is Nightcrawler. Wait for your enemy.\n");
        selection = BlackTeam.BlackGhosts;
        FourthMenu();
    }
    else
    {
        Console.WriteLine(" Error accured, please try again.");
        BlackTeamMenu();
    }
}

public void PlayerSelectionMagicians()
{
    selection = Console.WriteLine(" Please select a race.\n");
    Console.ReadLine(selection);

    if (selection == "1")
    {
        Console.WriteLine(" Your character is Gandalf the Gray. Wait for your enemy.\n");
        selection = Magicians.Gandalf;
        FourthMenu();
    }
    else if (selection == "2")
    {
        Console.WriteLine(" Your character is Saruman the White. Wait for your enemy.\n");
        selection = Magicians.Saruman;
        FourthMenu();
    }
    else if (selection == "3")
    {
        Console.WriteLine(" Your character is Groot the Green. Wait for your enemy.\n");
        selection = Magicians.Groot;
        FourthMenu();
    }
    else if (selection == "4")
    {
        Console.WriteLine(" Your character is Dragon the Red. Wait for your enemy.\n");
        selection = Magicians.Dragon;
        FourthMenu();
    }
    else
    {
        Console.WriteLine(" Error accured, please try again.");
        MagiciansTeamMenu();
    }
}

public void Enemy()
{
    int selection = Console.WriteLine(" Please select a number.\n");
    Console.ReadLine(selection);

    if (selection = 1)
    {
        Console.WriteLine(" Your enemy is from the dark side.\n He is -->");
        enemy = (Random.(BlackTeam) || Saruman || Dragon);
        Console.WriteLine(enemy);
        FourthMenu();
    }
    else if (selection = 2)
    {
        Console.WriteLine(" Your enemy is from the good side.\n He is -->");
        enemy = (Random.(WhiteTeam) || Gandalf || Groot);
        Console.WriteLine(enemy);
        FourthMenu();
    }
    else if (selection = 3)
    {
        if (PlayerSelectionMagicians = 2)
        {
            Console.WriteLine(" Your enemy is from the light.\n He is -->");
            enemy = (Gandalf | Groot);
            Console.WriteLine(enemy);
            FourthMenu();
        }
        else
        {
            Console.WriteLine(" Your enemy is from the eye.\n He is -->");
            enemy = (Saruman | Dragon);
            Console.WriteLine(enemy);
            FourthMenu();
        }
    }
    else
    {
        Console.WriteLine(" Error accured, please try again.")
        FirstMenu();
    }
}

public void TacticSelection1()
{
    selection = Console.WriteLine(" Please select a way to attack.\n");
    Console.ReadLine(selection);

    if (selection == "1")
    {
        Console.WriteLine(" Attacked with your power.");
        if (Player.Power > Enemy.Power)
        {
            Enemy.Health = (Enemy.Health - 40);
                Console.WriteLine(Enemy.Health);
            CheckHealth();
        }
        else
        {
            Player.Health = (Player.Health - 40);
                Console.WriteLine(Player.Health);
            CheckHealth();
        }
    }
    else if (selection == "2")
    {
        Console.WriteLine(" Attacked with your strategy.");
        if (Player.Strategy > Enemy.Strategy)
        {
            Enemy.Health = (Enemy.Health - 40);
                Console.WriteLine(Enemy.Health);
            CheckHealth();
        }
        else
        {
            Player.Health = (Player.Health - 40);
                Console.WriteLine(Player.Health);
            CheckHealth();
        }
    }
    else if (selection == "3")
    {
        Console.WriteLine(" Attacked with your magic.");
        if (Player.Magic > Enemy.Magic)
        {
            Enemy.Health = (Enemy.Health - 40);
                Console.WriteLine(Enemy.Health);
            CheckHealth();
        }
        else
        {
            Player.Health = (Player.Health - 40);
                Console.WriteLine(Player.Health);
            CheckHealth();
        }
    }
    else
    {
        Console.WriteLine(" Error accured, please try again.");
        FourthMenu();
    }
}

public void TacticSelection2()
{
    selection = Console.WriteLine(" Please select a way to attack again.\n");
    Console.ReadLine(selection);

    if (selection == "1")
    {
        Console.WriteLine(" Attacked with your power one more time.");
        if (Player.Power > Enemy.Power)
        {
            Enemy.Health = (Enemy.Health - 40);
                Console.WriteLine(Enemy.Health);
            CheckHealth2();
        }
        else
        {
            Player.Health = (Player.Health - 40);
                Console.WriteLine(Player.Health);
            CheckHealth2();
        }
    }
    else if (selection == "2")
    {
        Console.WriteLine(" Attacked with your strategy one more time.");
        if (Player.Strategy > Enemy.Strategy)
        {
            Enemy.Health = (Enemy.Health - 40);
                Console.WriteLine(Enemy.Health);
            CheckHealth2();
        }
        else
        {
            Player.Strategy = (Player.Health - 40);
                Console.WriteLine(Player.Health);
            CheckHealth2();
        }
    }
    else if (selection == "3")
    {
        Console.WriteLine(" Attacked with your magic one more time.");
        if (Player.Magic > Enemy.Magic)
        {
            Enemy.Health = (Enemy.Health - 40);
                Console.WriteLine(Enemy.Health);
            CheckHealth2();
        }
        else
        {
            Player.Health = (Player.Health - 40);
                Console.WriteLine(Player.Health);
            CheckHealth2();
        }
    }
    else
    {
        Console.WriteLine(" Error accured, please try again.");
        FifthMenu();
    }
}

public void CheckHealth()
{
    if (Player.Health = 0)
    {
        GameOverMenu();
    }
    else if (Enemy.Health = 0)
    {
        TacticSelection2();
    }
}

public void CheckHealth2()
{
    if (Player.Health = 0)
    {
        GameOverMenu();
    }
    else if (Enemy.Health = 0)
    {
        WinnerMenu();
    }
}

public void ToMainMenu()
{
    Console.WriteLine("If you want to play again press any key.");
    Console.ReadLine();
    if
    {
        FirstMenu();
    }
    else
    {
        return 0;
    }
}

public void FirstMenu()
{
        Console.WriteLine("1: WhiteTeam \n");
        Console.ReadLine(TeamSelection.selection1);
        Console.WriteLine("2: BlackTeam \n");
        Console.ReadLine(TeamSelection.selection2);
        Console.WriteLine("3: Magicians \n");
        Console.ReadLine(TeamSelection.selection3);

        TeamSelection();
}

public void WhiteTeamMenu()
{
    second1menu = "
 " __________________________
 "| 1: Hobbits               |
 "| 2: Elves                 |
 "| 3: Humans                |
 "| 4: Midgets               |
 " --------------------------
  "
        Console.WriteLine(second1menu);

    PlayerSelectionWhiteTeam();
}

public void BlackTeamMenu()
{
    second2menu = "
 " __________________________
 "| 1: Orgs                  |
 "| 2: Goblins               |
 "| 3: Black Ghosts          |
 " --------------------------
  "
        Console.WriteLine(second2menu);

    PlayerSelectionBlackTeam();
}

public void MagiciansTeamMenu()
{
    second3menu = "
 " __________________________
 "| 1: Gandalf               |
 "| 2: Saruman               |
 "| 3: Groot                 |
 " --------------------------
  "
        Console.WriteLine(second3menu);

    PlayerSelectionMagicians();
}

public void ThirdMenu()
{
    thirdmenu = "
 " ___________________________
 "| 1: ?????                  |
 "| 2 : ?????                 |
 "| 3 : ?????                 |
 " ---------------------------
  "
        Console.WriteLine(thirdmenu);

    Enemy();
}

public void FourthMenu()
{
    fourthmenu = "
 " ___________________________
 "| 1: Cut his head off       |
 "| 2: Stab him from behind   |
 "| 3: Stop his heart         |
 " ---------------------------
  "
        Console.Writeline(fourthmenu);

    TacticSelection1();
}

public void FifthMenu()
{
    fifthmenu = "
  "___________________________
 "| 1: Blow his eyes off      |
 "| 2: Tie him up in the trap |
 "| 3: Make him burned        |
 " ---------------------------
  "
        Console.WriteLine(fifthmenu);

    TacticSelection2();
}

public void GameOverMenu()
{
    Console.WriteLine(" Game Over \n")

    ToMainMenu()
}

public void WinnerMenu()
{
    Console.WriteLine(" Congrulations You Won the Game!\n");

    ToMainMenu();
}

}


/*

1. 2 tane class (character ve game)
2. character classi oyundaki tum karakterlerin ve playerin bilgilerini icerecek 
    2.1 irk, guc, can, strateji, buyu, anlik can, kazanma sayisi ve bunlari degistiren ve kiyaslayan fonskiyonlar 
3. game class oyun surecini yonetecek
    3.1 character classindaki fonklari kullanarak flowcharti uygulama

*/

/* 

irk haric hepsi bildigimiz gibi ---- irklar enum olacak ya da list olabilir



*/