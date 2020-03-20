using System;

namespace Event_L1
{
    delegate void DelegatTratareEveniment();

    class Eveniment
    {
        public event DelegatTratareEveniment activat;
        public void Actiune()
        {
            if (activat != null)
                //lansam evenimentul
                activat();
        }
    }
    class Program
    {
        static void handler()
        {
            Console.WriteLine("Eveniment produs");
        }

        static void Main(string[] args)
        {
            Eveniment ev = new Eveniment();
            //adaugam handler-ul la lista de evenimente
            ev.activat += new DelegatTratareEveniment(handler);
            Console.WriteLine("Hello World!");
            ev.Actiune();
        }
    }
}
