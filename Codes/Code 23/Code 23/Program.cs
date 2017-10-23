/****************************** Code 23 ******************************
 Code 23  : Interfaces
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_23
{
    delegate void MeuDelegate();
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IMinhaInterface_1
    {
        //!!! Não existe public ou private na declaração de membros (métodos, propriedades ou eventos) para interface!!!
        //Embora o padrão do C# diz que métodos são private por default, em interfaces os membros serão implementados como public
        //nas classes que os consumirem
        int Propriedade_I1 { get; set; }
        event MeuDelegate MeuEvento_I1;
        void MeuMetodo_I1();
    }

    interface IMinhaInterface_2
    {
        void MeuMetodo_I2();
        int Propriedade_I2 { get; set; }
        event MeuDelegate MeuEvento_I2;
    }

    class MinhaClasse : IMinhaInterface_1, IMinhaInterface_2
    {
        //IMinhaInterface_1 me obriga a implementar estes membros
        public int Propriedade_I1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public event MeuDelegate MeuEvento_I1;
        public void MeuMetodo_I1()
        {
            throw new NotImplementedException();
        }

        //IMinhaInterface_1 me obriga a implementar estes membros
        public int Propriedade_I2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public event MeuDelegate MeuEvento_I2;
        public void MeuMetodo_I2()
        {
            throw new NotImplementedException();
        }
    }
}
