using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demot
{
    class Ikkuna
    {
        //properties = ominaisuudet
        public float Leveys { get; set; }
        public float Korkeus { get; set; }
        public float Pintaala
        {
            get { return Leveys * Korkeus; }
        }
        public float Piiri
        {
            get { return 2 * (Leveys + Korkeus); }
        }
        //constructors = konstruktorit, 'rakentajat'
        public Ikkuna()
        {
            //tama on ns. oletuskonstruktori
        }
        public Ikkuna(float leveys, float korkeus)
        {
            Korkeus = korkeus;
            Leveys = leveys;
        }
        //methods = metodit
        public float LaskePintaala()
        {
            return Leveys * Korkeus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OOIkkunademo();
        }

        static void OOIkkunademo()
        {
            //ohjelma laskee ikkunan pinta-alan ja piirin
            float Leveys = 0;
            float Korkeus = 0;
            float Ala, Piiri = 0;
            //kysytään käyttäjältä mitat
            Console.WriteLine("Lasken ikkunan pinta-alan ja piirin, syota ikkunan leveys millimetreina");
            Leveys = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna korkeus millimetreina");
            Korkeus = float.Parse(Console.ReadLine());
            //lasketaan pinta-ala ja piiri ja ilmoitetaan ne kayttajalle
            Ala = Leveys * Korkeus;
            Piiri = 2 * (Leveys + Korkeus);
            Console.WriteLine("Ikkunan ala {0} ja piiri {1}", Ala, Piiri);
            //sama homma olion avulla
            Ikkuna ikkuna = new demot.Ikkuna();
            ikkuna.Leveys = Leveys;
            ikkuna.Korkeus = Korkeus;
            //Ala = ikkuna.LaskePintaala();
            Console.WriteLine("Olion avulla lasketun Ikkunan ala {0} ja piiri {1}", ikkuna.Pintaala, ikkuna.Piiri);
            //kokeillaan puolta pienemmalla ikkunalla toista konstruktoria
            Ikkuna ikkuna2 = new demot.Ikkuna(Leveys / 2, Korkeus / 2);
            Console.WriteLine("Olioikkuna2 ala {0} ja piiri {1}", ikkuna2.Pintaala, ikkuna2.Piiri);
        }
    }
}
