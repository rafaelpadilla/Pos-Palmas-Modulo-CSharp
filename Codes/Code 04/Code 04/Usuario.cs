using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_04
{
    class Usuario
    {
        public int Idade { get; set; }
        public string Name { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public Usuario Pai { get; set; }

        public void Metodo1()
        {
        }

        public void Metodo2()
        {
            System.Console.WriteLine("Este é um olá vindo do Metodo2().");
        }
    }
}
