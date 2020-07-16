using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methoden
{
    /**
   * Methoden sin Operationen die zu einer Klasse gehören. Methoden können Prozeduren oder Funktionen sein. Funktionen liefern
   * ein Rückgabeergebnis, Prozeduren nicht.
   * Statische Methoden sind auf Klassen anwendbar und werden benutzt um statische Felder zu initialisieren.
   * 
   * Parameter:
   * Wertparameter-Eingangsparameter; call-by-value; kann in Methode geändert werden ist aber nach Methodenende wieder auf dem U
   * Ursprungswert
   * Ref-Parameter-Übergangsparameter; call-by-reference;  kann in der Methode geändert werden;muss initialisiert sein
   * Out-Parameter-call-by-reference;  kann in der Methode geändert werden;muss nicht initialisiert sein
   * 
   * Variable Anzahl von Parametern:
   * Der letzte Parameter beim Methodenaufruf darf als Array deklariert werden. Beim Aufruf wird dann eine Folge von Einzelwerten
   * übergeben. Der Paramter muss mit params bezeichnet werden. Params darf nicht mit ref oder out kombiniert werden
   *
   * Überladen von Methoden:
   *   untersch. Anzahl von Parametern
   *   untersch. Typen von Parametern
   *   untersch. Arten von Parametern (value,ref,out)
   *
   * Optionale Parameter:
   *    verpflichtende Parameter - unbenannt/benannt ohne Wertangabe
   *    optionale Parameter - benannt mit Wertangabe
   *    
   *    Vereinfachen den Aufruf und erhöhen die Lesbarkeit bei vielen Parametern
   *    
   *Benannte Parameter:
   *   Positionsparameter
   *   benannt Parameter
   *   
   * Formale Parameter : Methodendeklaration
   * Aktuellen Parameter: Methodenaufruf
    **/


    class Methods
    {
        class Counter
        {
            static int instances;

            int testvalue = 10;

            int sum = 0, n = 0;

            public void Add(int x)      //Prozedur
            {
                sum = sum + x;n++;
            }

            public float Mean()         //Funktion
            {
                return (float)sum / n;
            }

            public static void InitClass()
            {
                instances++;
            }

            public void CallbyValue(int a)
            {
                a++;
            }

            public void CallbyRef(ref int a)
            {
                a++;
            }

            public void CallbyOut(out int a)
            {
                //a++;
                a = 1;
            }

            public void Add(out int sum, params int[]val)
            {
                sum = 0;
                foreach(int i in val)
                {
                    sum = sum + i;
                }
            }



        }
        static void Main(string[] args)
        {
            int a = 1;
            int b;

            Counter counter = new Counter();
            counter.Add(3);
            float m = counter.Mean();
                        
            Counter.InitClass();

            Console.WriteLine(a);
            counter.CallbyValue(a);
            Console.WriteLine(a);
            counter.CallbyRef(ref a);
            Console.WriteLine(a);
            counter.CallbyOut(out a);
            Console.WriteLine(a);

            counter.Add(out b, 1, 2, 3, 4, 5);
            Console.WriteLine(b);


        }
    }
}
