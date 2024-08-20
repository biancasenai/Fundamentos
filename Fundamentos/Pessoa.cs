using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Idade { get; set; }

        public void Envelhecer(int anos);
        
            this.Idade += anos;
            Console.WriteLine("Sua idade agora é:" +this.Idade);

          public void ApresentarSe()
        { Console.WriteLine("Ola, meu nome é:" + this.Nome + ", tenho" + " + 

            this.Idade + "Sou" + this.Cargo + " e meu salario é R$ " + this.Salario);


        }
    }

