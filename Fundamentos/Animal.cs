using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public abstract class Animal
    {
        //declaração de atributo
        public string Especie {  get; set; }
        public string Nome { get; set; }
        //declaração de um método

        public void emitirSom()
        {
            Console.WriteLine("Emitiu um Som");
        }
    }
}
