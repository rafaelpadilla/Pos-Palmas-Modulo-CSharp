/****************************** Code 10 ******************************
 Code 10  : Encapsulamento
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;

using System;

namespace Code_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação do Cliente 1
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Antenor";
            cliente1.Sobrenome = "Silva";
            cliente1.SexoCliente = Cliente.Sexo.Masculino;
            cliente1.CPF = "123.456.789-01";
            //Criação do Cliente 2
            Cliente cliente2 = new Cliente();
            cliente2.Nome = "Mariana";
            cliente2.Sobrenome = "Coelho";
            cliente2.SexoCliente = Cliente.Sexo.Feminino;
            cliente2.CPF = "222.3X3.444-55";

        }
    }
}
