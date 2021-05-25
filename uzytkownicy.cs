using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s4lab5
{
    class Uzytkownicy
    {
        public static List<Uzytkownicy> ListaOsob = new List<Uzytkownicy>();
        public string Login { get; set; }
        public string Haslo { get; set; }
        
        public Uzytkownicy(string login, String haslo)
        {
            this.Login = login;
            this.Haslo = haslo;
        }
        public static void DodajDoListy(Uzytkownicy uzytkownicy)
        {
            ListaOsob.Add(uzytkownicy);
        }
        public static void Zaloguj(Uzytkownicy uzytkownicy)
        {
            ListaOsob.Equals(uzytkownicy);
      
        }
    }
}
