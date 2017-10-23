/****************************** Code 20 ******************************
 Code 20  : Classes sealed (lacradas)
 Autor    : Rafael Padilla
 Data     : 21 de outubro de 2017
 Versão   : 1.0
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!! Sealed = Quebrar a herança

            //Exemplo 1:
            //Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dela

            //Exemplo 2:
            //Podemos usar sealed em propriedades ou métodos VIRTUAIS que estejam SENDO SOBRESCRITOS!!!Assim, você 
            //permite que classes sejam derivadas de sua classe e impede que estas substituam métodos ou propriedades 
            //virtuais.
            //É como se você quebrasse a herança de métodos virtuais, impedindo que estes sejam passados para outras
            //gerações.
        }
    }

    #region Exemplo 1
    class A
    { }
    //Nenhuma classe pode herdar de B, pois esta é sealed
    sealed class B : A
    { }
    //class C : B { } //Erro: Não é possível herdar do tipo sealed
    #endregion

    #region Exemplo 2
    class X
    {
        public X()
        {
            //Podemos acessar protected da mesma classe pois é da mesma classe.
            My_Protected_Virtual();
            //Podemos acessar public da mesma classe (trivial).
            My_Public_Virtual();
        }

        //Não permite! Pois se é virtual, é para ser sobrescrito nas classes filhos -> Virtual tem que ser public sempre!!!
        //private virtual void My_Private_Virtual() { }

        //Membros ou tipos protected podem ser acessados na mesma classe ou em uma classe derivada desta classe. (proteção dos filhos).
        //Virtual permite que seja feito um override neste método em uma classe derivada.
        protected virtual void My_Protected_Virtual()
        {
            Console.WriteLine("X.My_Protected_Virtual");
        }
        //Virtual permite que seja feito um override neste método em uma classe derivada.
        public virtual void My_Public_Virtual()
        {
            Console.WriteLine("X.My_Public_Virtual");
        }
    }
    class Y : X
    {
        public Y()
        {
            //Podemos acessar protected pois é um método da classe pai.
            My_Protected_Virtual();
            //Podemos acessar método public (pois é da classe pai)
            My_Public_Virtual();
        }

        //Podemos fazer um override em métodos virtuais.
        //Temos acesso aos métodos protected da classe pai, pois estamos no escopo da classe X que herda de Y, ou seja, está no sangue.
        //Fazemos ele ser SEALED impedindo que classes filhas da classe que estamos (Y) sobrescrevam este método (QUEBRA A HERANÇA DO MÉTODO DE SER SOBRESCRITO)
        sealed protected override void My_Protected_Virtual()
        {
            Console.WriteLine("Y.My_Protected_Virtual");
        }
        //Podemos fazer um override em métodos virtuais.
        //Temos acesso aos métodos public da classe pai.
        public override void My_Public_Virtual()
        {
            Console.WriteLine("Y.My_Public_Virtual");
        }
    }
    class Z : Y
    {
        //Ao tentar fazer override de My_Protected_Virtual da classe pai (Y), temos um erro de compilação.
        //Pois estamos tentando acessar um método que foi sealed
        //Se não tivesse sido sealed, poderíamos sobrescrevê-lo
        //protected override void My_Protected_Virtual() { Console.WriteLine("Z.My_Protected_Virtual"); }

        // Podemos fazer um override de My_Public_Virtual, pois ele não foi sealed
        public override void My_Public_Virtual() { Console.WriteLine("Z.My_Public_Virtual"); }
        //Atenção: Erro surge se eu tentar sobrescrever método "public void" alterando para "protected void" Não pode! para sobrescrever um método, temos que manter o acesso (assinatura) dele
        //protected override void My_Public_Virtual() { Console.WriteLine("Z.My_Public_Virtual"); }

    }
    #endregion
}
