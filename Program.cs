using System;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Teur
{
    internal class Program
       
    {

        static void Main(string[] args)
        {
            int käimasolevAasta = 2025;
            int OlenNiiVana = 16;
            int tehteTulemus = käimasolevAasta + OlenNiiVana;

            Console.WriteLine(tehteTulemus);

            //float pikkus = 2.5f;

            string sõnum = "Teie vanus on:6 ";

            //bool miskion = false;

            Console.WriteLine(sõnum + tehteTulemus);
            Console.WriteLine("aaaaaaaaaaaaa");
            Console.WriteLine("aaaaaaaaaaaaaaa");
            Console.WriteLine("sõnum");

            //int liidetav1 = 0;
            //int liidetav2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene liidetav: ");
            //liidetav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta esimene liidetav: ");
            //liidetav2 = int.Parse(Console.ReadLine());
            //int liitmine = liidetav1 + liidetav2;
            //Console.WriteLine($"Tehte tulemus: {liitmine}");
            //Console.WriteLine("tehte Tulemus:"+liitmine);

            //int lahutamine1 = 0;
            //int lahutamine2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene lahutatav: ");
            //lahutamine1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta esimene lahutatav: ");
            //lahutamine2 = int.Parse(Console.ReadLine());
            //int lahutamine = lahutamine1 / lahutamine2;
            //Console.WriteLine($"Tehte tuleus: {lahutamine}");
            //Console.WriteLine("tehte Tulemus:"+lahutamine);

            //int korrutamine1 = 0;
            //int korrutamine2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene korrutatav: ");
            //korrutamine1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta esimene korrutatav: ");
            //korrutamine2 = int.Parse(Console.ReadLine());
            //int korrutamine = korrutamine1 * korrutamine2;
            //Console.WriteLine($"Tehte tuleus: {korrutamine}");
            //Console.WriteLine("tehte Tulemus:" + korrutamine);
            //  int arv1 = 0;
            // int arv2 = 0;
            //  Console.WriteLine("Tere , palun sisesta esimene arv");
            //  arv1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Tere, palun sisesta teine arv: ");
            // arv2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
            //string tehtetüüp = Console.ReadLine();
            //int tehe = 0;

            // if (tehtetüüp == "+"  /*tingimus siia*/)
            // {
            //     tehe = arv1 + arv2;
            // }
            //
            //  if (tehtetüüp == "-"  /*tingimus siia*/)
            // {

            //     tehe = arv1 + arv2;
            //}


            // if (tehtetüüp == "/"  /*tingimus siia*/)
            // {
            //     tehe = arv1 + arv2;
            // }


            // if (tehtetüüp == "*"  /*tingimus siia*/)
            //{
            //     tehe = arv1 + arv2;
            //}
            //int arv1 = 0;
            // int arv2 = 0;
            // Console.WriteLine("Tere, palun sisesta esimene astendatav: ");
            // arv1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("Tere, palun sisesta teine astendatav: ");
            // arv2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: ^ ");
            // string tehtetüüp = Console.ReadLine();

            // int tehe = 0;
            //int tulemus = (int)Math.Pow(arv1, arv2);
            // Console.WriteLine("tulemus on: " + tulemus);
            string lemmikpuuvili = "";
            bool milline = false;
            string lemmikjuurvili;
            Console.WriteLine("Kas sulle meeldivad puuviljad või juurviljad,kirjuta juurviljad kui meldivad juurviljad, aga jäta tühjaks kui meeldivad puuviljad");
            milline = bool.Parse(Console.ReadLine());
            if (milline == false)
            {
                if (lemmikpuuvili == "maaiskas")
                {
                    Console.WriteLine("Maasiaks ei ole puuvili");
                }
                else if (lemmikpuuvili == "pirn")
                {
                    Console.WriteLine("Kas hapu pirn või magus pirn,mõlemad on head");
                }
                else if (lemmikpuuvili == "pirn")
                {
                    Console.WriteLine("see ei kasva isegi mitte puu otsas");
                }
                else
                {
                    Console.WriteLine("Ei tunne seda puuvilja");
                }
            }

            String Lemmikjuurvili;
            if (milline == true)


            {
                Console.WriteLine("Sisesta oma lemmikjuurvili");
                Lemmikjuurvili = Console.ReadLine();

                if (Lemmikjuurvili == "porgand")
                {
                    Console.WriteLine("Porgand on tervislik");
                }
                else if (Lemmikjuurvili == "Kartul")
                {
                    Console.WriteLine("Kartul on Äge");
                }
                else if (Lemmikjuurvili == "Kapsas")
                {
                    Console.WriteLine("Kapsas on roheline");
                }
                else
                {
                    Console.WriteLine("Ei tunne seda puuvilja");
                }
            }























































        }
    }
}
