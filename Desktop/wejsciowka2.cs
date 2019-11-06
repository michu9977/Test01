using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Postac Mirek = new Wojownik("mirek",10,20,30,30,40,"miecz");
            Mirek.PrzedstawSie();
            Mirek.WypiszHP();
            Mirek.SilaAtaku();
            Postac Adam = new Lucznik("adam", 5, 10, 5, 40, 10, "luk");
            Adam.PrzedstawSie();
            Adam.WypiszHP();
            Adam.SilaAtaku();


        }
    }
    class Postac
    {
        enum Rasa { człowiek, krasnolud, elf };
        char imie;
        int hp;
        int max_hp;
        int sila;
        int zrecznosc;
        int inteligencja;

        public Postac(char imie, int hp, int max_hp, int sila, int zrecznosc, int inteligencja)
        {
            this.imie = imie;
            this.hp = hp;
            this.max_hp = max_hp;
            this.sila = sila;
            this.zrecznosc = zrecznosc;
            this.inteligencja = inteligencja;
        }

        public int SilaAtaku()
        {
            int silaAtaku = 0;
            silaAtaku = (sila * zrecznosc) * (hp / max_hp);
            return silaAtaku;
        }
        public void WypiszHP()
        {
            Console.WriteLine(imie + "posiada" + hp + "/" + max_hp);
        }
        public abstract void PrzedstawSie()
        {

        }
    }

    class Wojownik : Postac
        {
            string bron = "miecz";

            public Wojownik(char imie, int hp, int max_hp, int sila, int zrecznosc, int inteligencja, string bron) : base(imie, hp, max_hp, sila, zrecznosc, inteligencja)
            {
                this.bron = bron;
            }
            public void PrzedstawSie()
            {
                Console.WriteLine(imie + " " + Rasa + " " + bron);
            }
        }
    class Lucznik : Postac
        {
            string bron = "luk";

            public Lucznik(char imie, int hp, int max_hp, int sila, int zrecznosc, int inteligencja,string bron) : base(imie, hp, max_hp, sila, zrecznosc, inteligencja)
            {
                this.bron = bron;
            }
            public void PrzedstawSie()
            {
                Console.WriteLine(imie + " " + Rasa + " " + bron);
            }
        }
    class Zlodziej :Postac
        {
            string bron = "sztylet";

            public Zlodziej(char imie, int hp, int max_hp, int sila, int zrecznosc, int inteligencja, string bron) : base(imie, hp, max_hp, sila, zrecznosc, inteligencja)
            {
                this.bron = bron;
            }
            public void PrzedstawSie()
            {
                Console.WriteLine(imie + " " + Rasa + " " + bron);
            }
        }
    }


