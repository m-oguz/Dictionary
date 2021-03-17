using System;


namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, string> sozluk = new MyDictionary<string, string>();
            sozluk.Add("key", "avain");
            sozluk.Add("door", "ovi");
            sozluk.Add("wall", "seinä");
            sozluk.Add("book", "kirja");
            sozluk.Add("computer", "tietokone");
            sozluk.Add("home", "koti");
            sozluk.Add("phone", "puhelin");
            sozluk.Add("bed", "sänky");
            sozluk.Add("info", "tieto");
            sozluk.Add("school", "koulu");
            sozluk.Add("hand", "käsi");
            sozluk.Add("car", "auto");
            sozluk.Add("carpet", "matto");
            sozluk.Add("water", "vesi");
            sozluk.Add("room", "huone");



            sozluk.listTheKeys();

            while (true)
            {
                Console.WriteLine("Type the word to translate");


                string input = Console.ReadLine();
                Console.WriteLine("\""+ input + "\" means \"" + sozluk.Get(input) + "\"."); 
            }

        }
    }
}
