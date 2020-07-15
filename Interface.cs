using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPM
{

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

    class Interface
    {
        static void Main(string[] args)
        {
            IWriter w = new Textfield();
            w.Write('x');
            w = new Buffer();
            w.Write('y');
        }
    }
}
