using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPM
{ 
    /**
     * Interfaces kann man sich als abstraket Klassen vorstellen die Signaturen von Methoden, Properties, Indexern
     * und Events enthalten, Sie dürfen keine Felder, Konstanten, Konstruktoren, Destruktoren und überladene Operatoren
     * aufweisen. Sie sind reine Sammlungen von Operationen. Sie erlauben es Typen die in keiner Vererbungsbeziehung stehen
     * gleichartig zu behandeln.
     * Methoden die Interfaces implementieren müssen public sein, brauchen nicht als override gekennzeichnet sein, aber als 
     * virtual falls sie in Unterklassen überschrieben werden sollen.
     * Wenn 2 Interfaces die selben Methodennamen verwenden, müssen sie in der Impl.klasse über den Namen des Interfaces 
     * qualifiziert werden.
     *
     **/

    interface IWriter
    {
        void Write(char ch);
    }

    class Textfield : IWriter
    {
        public void Write(char ch)
        {
            throw new NotImplementedException();
        }
    }

    struct Buffer : IWriter
    {
        //char[]buf = new char[128];

        public void Write(char ch)
        {
            throw new NotImplementedException();
        }
    }

    class Buf:IDisposable
    {
        System.IO.StreamWriter sw;
        public Buf()
        {
            sw = new System.IO.StreamWriter("exa.txt");
        }

        ~Buf()
        {
            Dispose();
        }

        public void Dispose()
        {
            if (sw!=null)
            {
                sw.Close();
                sw = null;
            }
        }
    }

    class Interface
    {
        static void Main(string[] args)
        {
            IWriter w = new Textfield();
            w.Write('x');
            w = new Buffer();
            w.Write('y');

            Textfield tf = new Textfield();
            IWriter wr = tf;
            tf = (Textfield)wr;
            tf = wr as Textfield;

            using(Buf b = new Buf() )
            {
                ;
            }

        }
    }
}
