using System;

namespace WarriorGame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var Warrior1 = new Warriors("Barbarian", 100, 10);
            var Warrior2 = new Warriors("Hunter", 100, 10);
            var Warrior3 = new Warriors("Paladin", 100, 10);
            var RandomMonster = 0;
            var hitWar = 0;
            var hitMons = 0;
            var blessed = 0;
            var score = 0;

            Console.WriteLine("Welcome to the Warrior game, let's enter in the dungeon");

            while (Warrior1.getPv() > 0 && Warrior2.getPv() > 0 && Warrior3.getPv() > 0) //Verify if all the warriors are alive
            {
                while (Warrior1.getPv() > 0) // Until the Barbarian is alive
                {
                    Console.WriteLine(Warrior1.getName()+" : "+ Warrior1.getPv() + " hp");

                    //Get a random Monster
                    Random random = new Random();
                    RandomMonster = random.Next(1, 3);

                    if (RandomMonster == 1)
                    {
                        var WeakMonster = new WeakMonster(50, 3, 10);

                        Console.WriteLine(" You meet a Gobelin,let's fight");
                        Console.ReadKey(true);


                        while(Warrior1.getPv() > 0 && WeakMonster.getPv() > 0)
                        {
                            Console.WriteLine(Warrior1.getName() + " : " + Warrior1.getPv() + " hp " + " Gobelin : " + WeakMonster.getPv() + " hp"  );
                            Random rand = new Random();
                            hitWar = random.Next(0, Warrior1.getDmg());
                            Console.WriteLine("Barbarian hit the Gobelin with " + hitWar + " dmg"); //Random dmg for the warrior
                            blessed=WeakMonster.getPv() - hitWar;
                            WeakMonster.setPv(blessed);
                            Console.ReadKey(true);
                            Random randi = new Random();
                            hitMons = random.Next(0, WeakMonster.getDmg());
                            Console.WriteLine("Gobelin hit the barbarian with " + hitMons + " dmg"); //Random dmg for the Monster
                            blessed = Warrior1.getPv() - hitMons;
                            Warrior1.setPv(blessed);
                            Console.ReadKey(true);

                        }
                        if( Warrior1.getPv() <= 0 )
                        {
                            Console.WriteLine("Your Barbarian is dead");
                            Console.ReadKey(true);
                        }else if (WeakMonster.getPv() <= 0)
                        {
                            Console.WriteLine("You defeated the Gobelin and earn 10 points");
                            score = score + 10;
                            Console.ReadKey(true);

                        }


                    }else if (RandomMonster == 2)
                    {
                        var MidMonster = new MidMonster(100, 5, 20);

                        Console.WriteLine(" You meet an Orc, let's fight");
                        Console.ReadKey(true);

                        while (Warrior1.getPv() > 0 && MidMonster.getPv() > 0)
                        {
                            Console.WriteLine(Warrior1.getName() + " : " + Warrior1.getPv() + " hp " + " Orc : " + MidMonster.getPv() + " hp");
                            Random rand = new Random();
                            hitWar = random.Next(0, Warrior1.getDmg());
                            Console.WriteLine("Barbarian hit the Orc with " + hitWar + " dmg"); //Random dmg for the warrior
                            blessed = MidMonster.getPv() - hitWar;
                            MidMonster.setPv(blessed);
                            Random randi = new Random();
                            Console.ReadKey(true);
                            hitMons = random.Next(0, MidMonster.getDmg());
                            Console.WriteLine("Orc hit the barbarian with " + hitMons + " dmg"); //Random dmg for the Monster
                            blessed = Warrior1.getPv() - hitMons;
                            Warrior1.setPv(blessed);
                            Console.ReadKey(true);

                        }
                        if (Warrior1.getPv() <= 0)
                        {
                            Console.WriteLine("Your Barbarian is dead");
                            Console.ReadKey(true);
                        }
                        else if(MidMonster.getPv() <= 0)
                        {
                            Console.WriteLine("You defeated the Orc and earn 20 points");
                            score = score + 20;
                            Console.WriteLine("You find a potion that recover 20 hp");
                            Warrior1.setPv(Warrior1.getPv() + 20);
                            Console.ReadKey(true);

                        }
                    }else if (RandomMonster == 3)
                    {
                        var Boss = new Boss(150, 7, 100);

                        Console.WriteLine(" You meet a Troll chief, let's fight");
                        Console.ReadKey(true);

                        while (Warrior1.getPv() > 0 && Boss.getPv() > 0)
                        {
                            Console.WriteLine(Warrior1.getName() + " : " + Warrior1.getPv() + " hp " + " Troll : " + Boss.getPv() + " hp");
                            Random rand = new Random();
                            hitWar = random.Next(0, Warrior1.getDmg());
                            Console.WriteLine("Barbarian hit the Troll with " + hitWar + " dmg"); //Random dmg for the warrior
                            blessed = Boss.getPv() - hitWar;
                            Boss.setPv(blessed);
                            Console.ReadKey(true);
                            Random randi = new Random();
                            hitMons = random.Next(0, Boss.getDmg());
                            Console.WriteLine("Troll hit the barbarian with " + hitMons + " dmg"); //Random dmg for the Monster
                            blessed = Warrior1.getPv() - hitMons;
                            Warrior1.setPv(blessed);
                            Console.ReadKey(true);

                        }
                        if (Warrior1.getPv() <= 0)
                        {
                            Console.WriteLine("Your Barbarian is dead");
                            Console.ReadKey(true);
                        }
                        else if (Boss.getPv() <= 0)
                        {
                            Console.WriteLine("You defeated the Troll chief and earn 100 points");
                            score = score + 100;
                            Console.WriteLine("You find two potions that recover 20 hp each");
                            Warrior1.setPv(Warrior1.getPv() + 40);
                            Console.ReadKey(true);

                        }
                    }


                }

                    while (Warrior2.getPv() > 0) // Until the Hunter is alive
                    {
                        Console.WriteLine(Warrior2.getName() + " - " + Warrior2.getPv());

                        //Get a random Monster
                        Random random = new Random();
                        RandomMonster = random.Next(1, 3);

                        if (RandomMonster == 1)
                        {
                            var WeakMonster = new WeakMonster(50, 3, 10);

                            Console.WriteLine(" You meet a Gobelin,let's fight");
                        Console.ReadKey(true);


                            while (Warrior2.getPv() > 0 && WeakMonster.getPv() > 0)
                            {
                                Console.WriteLine(Warrior2.getName() + " : " + Warrior2.getPv() + " hp " + " Gobelin : " + WeakMonster.getPv() + " hp");
                                Random rand = new Random();
                                hitWar = random.Next(0, Warrior2.getDmg());
                                Console.WriteLine("Hunter hit the Gobelin with " + hitWar + " dmg"); //Random dmg for the warrior
                                blessed = WeakMonster.getPv() - hitWar;
                                WeakMonster.setPv(blessed);
                                Console.ReadKey(true);
                                Random randi = new Random();
                                hitMons = random.Next(0, WeakMonster.getDmg());
                                Console.WriteLine("Gobelin hit the hunter with " + hitMons + " dmg"); //Random dmg for the Monster
                                blessed = Warrior2.getPv() - hitMons;
                                Warrior2.setPv(blessed);
                                Console.ReadKey(true);

                            }
                            if (Warrior2.getPv() <= 0)
                            {
                            Console.WriteLine("Your Hunter is dead");
                            Console.ReadKey(true);

                            }
                            else if (WeakMonster.getPv() <= 0)
                            {
                                Console.WriteLine("You defeated the Gobelin and earn 10 points");
                                score = score + 10;
                                Console.ReadKey(true);

                            }


                        }
                        else if (RandomMonster == 2)
                        {
                            var MidMonster = new MidMonster(100, 5, 20);

                            Console.WriteLine(" You meet an Orc, let's fight");
                        Console.ReadKey(true);

                            while (Warrior2.getPv() > 0 && MidMonster.getPv() > 0)
                            {
                                Console.WriteLine(Warrior2.getName() + " : " + Warrior2.getPv() + " hp " + " Gobelin : " + MidMonster.getPv() + " hp");
                                Random rand = new Random();
                                hitWar = random.Next(0, Warrior2.getDmg());
                                Console.WriteLine("Hunter hit the Orc with " + hitWar + " dmg"); //Random dmg for the warrior
                                blessed = MidMonster.getPv() - hitWar;
                                MidMonster.setPv(blessed);
                                Console.ReadKey(true);
                                Random randi = new Random();
                                hitMons = random.Next(0, MidMonster.getDmg());
                                Console.WriteLine("Orc hit the Hunter with " + hitMons + " dmg"); //Random dmg for the Monster
                                blessed = Warrior2.getPv() - hitMons;
                                Warrior2.setPv(blessed);
                                Console.ReadKey(true);
                            }
                            if (Warrior2.getPv() <= 0)
                            {
                            Console.WriteLine("Your Hunter is dead");
                            Console.ReadKey(true);

                            }
                            else if (MidMonster.getPv() <= 0)
                            {
                                Console.WriteLine("You defeated the Orc and earn 20 points");
                                score = score + 20;
                                Console.WriteLine("You find a potion that recover 20 hp");
                                Warrior2.setPv(Warrior2.getPv() + 20);
                                Console.ReadKey(true);

                            }
                        }
                        else if (RandomMonster == 3)
                        {
                            var Boss = new Boss(150, 7, 100);

                            Console.WriteLine(" You meet a Troll chief, let's fight");

                            while (Warrior2.getPv() > 0 && Boss.getPv() > 0)
                            {
                                Console.WriteLine(Warrior2.getName() + " : " + Warrior2.getPv() + " hp " + " Troll : " + Boss.getPv() + " hp");
                                Random rand = new Random();
                                hitWar = random.Next(0, Warrior2.getDmg());
                                Console.WriteLine("Hunter hit the Troll with " + hitWar + " dmg"); //Random dmg for the warrior
                                blessed = Boss.getPv() - hitWar;
                                Boss.setPv(blessed);
                                Console.ReadKey(true);
                                Random randi = new Random();
                                hitMons = random.Next(0, Boss.getDmg());
                                Console.WriteLine("Troll hit the Hunter with " + hitMons + " dmg"); //Random dmg for the Monster
                                blessed = Warrior2.getPv() - hitMons;
                                Warrior2.setPv(blessed);
                                Console.ReadKey(true);

                            }
                            if (Warrior2.getPv() <= 0)
                            {
                                Console.WriteLine("Your Hunter is dead");
                            Console.ReadKey(true);
                            }
                            else if (Boss.getPv() <= 0)
                            {
                                Console.WriteLine("You defeated the Troll and earn 100 points");
                                score = score + 100;
                                Console.WriteLine("You find two potions that recover 20 hp each");
                                Warrior2.setPv(Warrior2.getPv() + 40);
                                Console.ReadKey(true);

                            }
                        }


                    }

                while (Warrior3.getPv() > 0) // Until the Paladin is alive
                {
                    Console.WriteLine(Warrior3.getName() + " - " + Warrior3.getPv());

                    //Get a random Monster
                    Random random = new Random();
                    RandomMonster = random.Next(1, 3);

                    if (RandomMonster == 1)
                    {
                        var WeakMonster = new WeakMonster(50, 3, 10);

                        Console.WriteLine(" You meet a Gobelin,let's fight");
                        Console.ReadKey(true);


                        while (Warrior3.getPv() > 0 && WeakMonster.getPv() > 0)
                        {
                            Console.WriteLine(Warrior3.getName() + " : " + Warrior3.getPv() + " hp " + " Gobelin : " + WeakMonster.getPv() + " hp");
                            Random rand = new Random();
                            hitWar = random.Next(0, Warrior3.getDmg());
                            Console.WriteLine("Paladin hit the Gobelin with " + hitWar + " dmg"); //Random dmg for the warrior
                            blessed = WeakMonster.getPv() - hitWar;
                            WeakMonster.setPv(blessed);
                            Console.ReadKey(true);
                            Random randi = new Random();
                            hitMons = random.Next(0, WeakMonster.getDmg());
                            Console.WriteLine("Gobelin hit the Paladin with " + hitMons + " dmg"); //Random dmg for the Monster
                            blessed = Warrior3.getPv() - hitMons;
                            Warrior3.setPv(blessed);
                            Console.ReadKey(true);

                        }
                        if (Warrior3.getPv() <= 0)
                        {
                            Console.WriteLine("Your Paladin is dead");
                            Console.ReadKey(true);
                        }
                        else if (WeakMonster.getPv() <= 0)
                        {
                            Console.WriteLine("You defeated the Gobelin and earn 10 points");
                            score = score + 10;
                            Console.ReadKey(true);

                        }


                    }
                    else if (RandomMonster == 2)
                    {
                        var MidMonster = new MidMonster(100, 5, 20);

                        Console.WriteLine(" You meet an Orc, let's fight");
                        Console.ReadKey(true);

                        while (Warrior3.getPv() > 0 && MidMonster.getPv() > 0)
                        {
                            Console.WriteLine(Warrior3.getName() + " : " + Warrior3.getPv() + " hp " + " Gobelin : " + MidMonster.getPv() + " hp");
                            Random rand = new Random();
                            hitWar = random.Next(0, Warrior3.getDmg());
                            Console.WriteLine("Paladin hit the Orc with " + hitWar + " dmg"); //Random dmg for the warrior
                            blessed = MidMonster.getPv() - hitWar;
                            MidMonster.setPv(blessed);
                            Console.ReadKey(true);
                            Random randi = new Random();
                            hitMons = random.Next(0, MidMonster.getDmg());
                            Console.WriteLine("Orc hit the Paladin with " + hitMons + " dmg"); //Random dmg for the Monster
                            blessed = Warrior3.getPv() - hitMons;
                            Warrior1.setPv(blessed);
                            Console.ReadKey(true);

                        }
                        if (Warrior3.getPv() <= 0)
                        {
                            Console.WriteLine("Your Paladin is dead");
                            Console.ReadKey(true);
                        }
                        else if (MidMonster.getPv() <= 0)
                        {
                            Console.WriteLine("You defeated the Orc and earn 20 points");
                            score = score + 20;
                            Console.WriteLine("You find a potion that recover 20 hp");
                            Warrior3.setPv(Warrior3.getPv() + 20);
                            Console.ReadKey(true);

                        }
                    }
                    else if (RandomMonster == 3)
                    {
                        var Boss = new Boss(150, 7, 100);

                        Console.WriteLine(" You meet a Troll chief, let's fight");
                        Console.ReadKey(true);

                        while (Warrior3.getPv() > 0 && Boss.getPv() > 0)
                        {
                            Console.WriteLine(Warrior3.getName() + " : " + Warrior3.getPv() + " hp " + " Troll : " + Boss.getPv() + " hp");
                            Random rand = new Random();
                            hitWar = random.Next(0, Warrior3.getDmg());
                            Console.WriteLine("Paladin hit the Troll with " + hitWar + " dmg"); //Random dmg for the warrior
                            blessed = Boss.getPv() - hitWar;
                            Boss.setPv(blessed);
                            Console.ReadKey(true);
                            Random randi = new Random();
                            hitMons = random.Next(0, Boss.getDmg());
                            Console.WriteLine("Troll hit the Paladin with " + hitMons + " dmg"); //Random dmg for the Monster
                            blessed = Warrior1.getPv() - hitMons;
                            Warrior3.setPv(blessed);
                            Console.ReadKey(true);

                        }
                        if (Warrior3.getPv() <= 0)
                        {
                            Console.WriteLine("Your Paladin is dead");
                            Console.ReadKey(true);
                        }
                        else if (Boss.getPv() <= 0)
                        {
                            Console.WriteLine("You defeated the Troll Chief and earn 100 points");
                            score = score + 100;
                            Console.WriteLine("You find two potionsthat recover 20 hp each");
                            Warrior1.setPv(Warrior1.getPv() + 40);
                            Console.ReadKey(true);

                        }
                    }


                }

            }

            Console.WriteLine("GAME OVER");
            Console.WriteLine("SCORE : " + score);


        }

    }
    // Initialisation Class Warrior

    public class Warriors
    {
        private string name;
        private int pv;
        private int dmg;


        public Warriors(string name, int pv, int dmg)
        {
            this.name = name;
            this.pv = pv;
            this.dmg = dmg;

        }
        // Fonction class Warrior

        public string getName()
        {
            return this.name;
        }
        public int getPv()
        {
            return this.pv;
        }

        public void setPv(int pv)
        {
            this.pv = pv;
        }
        public int getDmg()
        {
            return this.dmg;
        }


    }
    //Initialisation Class WeakMonster

    public class WeakMonster
    {

        private int pv;
        private int dmg;
        private int point;

        public WeakMonster(int pv, int dmg, int point)
        {
            this.pv = pv;
            this.dmg = dmg;
            this.point = point;
        }
        // Fonction class WeakMonster

        public int getPv()
        {
            return this.pv;
        }

        public void setPv(int pv)
        {
            this.pv = pv;
        }
        public int getDmg()
        {
            return this.dmg;
        }
    }
    // Initialisation Class MidMonster

    public class MidMonster
    {

        private int pv;
        private int dmg;
        private int point;

        public MidMonster(int pv, int dmg, int point)
        {
            this.pv = pv;
            this.dmg = dmg;
            this.point = point;
        }
        //Fonction Class MidMonster
        public int getPv()
        {
            return this.pv;
        }

        public void setPv(int pv)
        {
            this.pv = pv;
        }
        public int getDmg()
        {
            return this.dmg;
        }
    }
        // Initialisation Class Boss

        public class Boss
        {

            private int pv;
            private int dmg;
            private int point;

            public Boss(int pv, int dmg, int point)
            {
                this.pv = pv;
                this.dmg = dmg;
                this.point = point;
            }
            //Fonction Class Boss

            public int getPv()
            {
                return this.pv;
            }

            public void setPv(int pv)
            {
                this.pv = pv;
            }
            public int getDmg()
            {
                return this.dmg;
            }
        }
    }
