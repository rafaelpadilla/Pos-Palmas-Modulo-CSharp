/****************************** Code 22 ******************************
 Code 22  : XXXXXXXXXXX
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_22
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Testando acesso de variáveis, métodos e propriedades */

            //De classe pública
            ClassePrivada classePublica = new ClassePrivada();
            //Metodos
            classePublica.MetodoPublico();
            ClassePrivada.MetodoEstaticoPublico();
            //Propriedades
            object teste1 = classePublica.PropriedadePublica;
            //Variáveis
            object teste2 = classePublica.variavelPublica;
            //Static
            object teste3 = ClassePublica.PropriedadeEstaticaPublica;
            object teste4 = ClassePublica.variavelEstaticaPublica;


            ////De classe privada
            //ClassePrivada classePrivada = new ClassePrivada();
            ////Metodos
            //classePrivada.MetodoPublico();
            //ClassePrivada.MetodoEstaticoPublico();
            ////Propriedades
            //object teste1 = classePrivada.PropriedadePublica;
            ////Variáveis
            //object teste2 = classePrivada.variavelPublica;
            ////Static
            //object teste3 = ClassePrivada.PropriedadeEstaticaPublica;
            //object teste4 = ClassePrivada.variavelEstaticaPublica;

        }
    }

    //não posso ter classe privada dentro do namespace
    //As classes e structs que são declarados dentro de um namespace (em outras palavras, que não estão aninhadas dentro de outras 
    //classes ou structs) podem ser públicos ou internos.Interno é o padrão se nenhum modificador de acesso for especificado.
    //Referência : https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    class ClassePrivada //interna por default
    {
        //Propriedades
        private int PropriedadePrivada { get; set; }
        public int PropriedadePublica { get; set; }
        //Propriedades Estáticas
        private static int PropriedadeEstaticaPrivada { get; set; }
        public static int PropriedadeEstaticaPublica { get; set; }

        //Variáveis
        private int variavelPrivada;
        public int variavelPublica;
        //Variáveis Estáticas
        private static int variavelEstaticaPrivada;
        public static int variavelEstaticaPublica;

        //Métodos
        private void MetodoPrivado()
        { }
        public void MetodoPublico()
        { }
        //Métodos Estáticos
        private static void MetodoEstaticoPrivado()
        { }
        public static void MetodoEstaticoPublico()
        { }
    }

    public class ClassePublica
    {
        //Propriedades
        private int PropriedadePrivada { get; set; }
        public int PropriedadePublica { get; set; }
        //Propriedades Estáticas
        private static int PropriedadeEstaticaPrivada { get; set; }
        public static int PropriedadeEstaticaPublica { get; set; }

        //Variáveis
        private int variavelPrivada;
        public int variavelPublica;
        //Variáveis Estáticas
        private static int variavelEstaticaPrivada;
        public static int variavelEstaticaPublica;

        //Métodos
        private void MetodoPrivado()
        { }
        public void MetodoPublico()
        { }
        //Métodos Estáticos
        private static void MetodoEstaticoPrivado()
        { }
        public static void MetodoEstaticoPublico()
        { }
    }
}
