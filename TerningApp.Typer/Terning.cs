using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TerningApp.Typer
{
    public class Terning
    {
        public int Værdi { get; private set; }
        public void Ryst() { 
            this.Værdi = new Random().Next(1,7);
        }
        public void Skriv() {
            Console.WriteLine($"[ {this.Værdi} ]");
        }
        public Terning()
        {
            this.Ryst();
        }

        public Terning(int værdi)
        {
            if (værdi < 1 || værdi > 6) {
                throw new ApplicationException("Fejl");
            }
            this.Værdi = værdi;
        }
    }
}
