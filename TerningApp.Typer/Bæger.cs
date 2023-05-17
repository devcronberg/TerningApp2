using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningApp.Typer
{
    public class Bæger
    {
        private Terning[] terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }
        }

        public Bæger(params int[] værdier)
        {
            if (værdier.Length != 5) {
                throw new ApplicationException("Fejl");
            }
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning(værdier[i]);
            }
        }

        public bool ErYatzy() {
            var grupper = terninger.GroupBy(i => i.Værdi);
            return grupper.Count() == 1;
        }

        public bool ErFuldtHus()
        {
            var grupper = terninger.GroupBy(i => i.Værdi);
            return grupper.Count() == 2 && (grupper.First().Count()==2 || grupper.Last().Count() == 2) ;
        }

        public void Ryst() {
            for (int i = 0; i < 5; i++)
            {
                terninger[i].Ryst();
            }
        }

        public void Skriv() {
            for (int i = 0; i < 5; i++)
            {
                terninger[i].Skriv();
            }
        }

    }
}
