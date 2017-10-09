/****************************** Code 04 ******************************
 Code 04  : Object vs. Var vs. Dynamic
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/


using System;

namespace Code_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Criação dos usuarios
            Usuario usuario1 = new Usuario()
            {
                Endereco = "Av. Paulista, 1130",
                Idade = 13,
                Name = "Amarildo",
                Pai = null,
                Sobrenome = "Silva"
            };
            Usuario usuario2 = new Usuario()
            {
                Endereco = "Rua Santo Amaro, 22",
                Idade = 23,
                Name = "Bernardo",
                Pai = null,
                Sobrenome = "Cardoso"
            };
            Usuario usuario3 = new Usuario()
            {
                Endereco = "Av. Djalma Batista, 20",
                Idade = 53,
                Name = "Carlos",
                Pai = null,
                Sobrenome = "Ferreira"
            };
            Usuario usuario4 = new Usuario()
            {
                Endereco = "Av. Constantino Nery, 1001",
                Idade = 20,
                Name = "Diogo",
                Pai = usuario3,
                Sobrenome = "Palhares"
            };
            #endregion

            #region Object
            Usuario usuario = usuario1; //É possível atribuir um objeto do tipo Usuario para outro do tipo Usuario
            object usuarioObj = usuario1; //Da mesma forma que é possível atribuir um objeto do tipo Usuario para um object
            //Para atribuir um objeto do tipo object para outro do tipo Usuario, é necessário fazer um cast
            //Usuario novoUsuario = usuarioObj; //Erro de compilação! pois é necessário uma conversão
            Usuario novoUsuario = (Usuario)usuarioObj;
            
            usuarioObj = 32; //Object permite eu mudar o "tipo" do dado
            usuarioObj = "Rafael"; //Object permite eu mudar o "tipo" do dado

            //novoUsuario = 32; //Erro: Já um tipo Usuario (objeto explícito) não permite alterar o "tipo" do dado

            /* Conclusões: 
            (i) é possível atribuir um Usuario para outro Usuario
            (ii) é possível atribuir um Usuario para um object
            (iii) é possível CONVERTER um object em um Usuario
            (iv) é possível alterar o tipo de dado de um object
            (v) não é possível aterar o tipo de dado de um Usuario */
            #endregion

            #region Var (Adicionada no C# 3.0)
            //Var é uma atribuição implícita de um tipo. Fica a cargo do compilador determinar o tipo
            //var teste; //Erro: É necessário inicializar atribuindo um valor à variável senão o compilador não tem como saber o tipo

            var var1 = 4.3;
            Console.WriteLine(var1.GetType().FullName);
            var var2 = "Rafael";
            Console.WriteLine(var2.GetType().FullName);

            //var1 = var2; //Erro: Não permite, pois a var1 já foi definida como double e a var2 como string

            var usuarioVar = usuario1; //Tenho acesso aos metodos da classe Usuario

            /* Conclusões: 
           (i) Var é um tipo implícito Ex: "int a = 3 <=> var a = 3"
           (ii) O compilador determina o tipo da variável/objeto
           (iii) Não é permitido atribuir uma variável/objeto para uma var cujos tipos são diferentes */
            #endregion

            #region Dynamics (Adicionada no C# 4.0)
            //A atribuição do tipo para uma variável/objeto dynamic é feita em runtime.
            dynamic variavelDynamic; //Permite criação de uma dynamic sem inicializá-la
            variavelDynamic = usuario1;
            //Não existe 'code complete' para uma variavelDynamic, permitindo qualquer chamada de método, atributo ou propriedade, mesmo que eles não existam
            //variavelDynamic.Metodo1(); //Erro em runtime: Variavel dynamic agora é um tipo int - Não existe Metodo1()
            //variavelDynamic.Metodo1("asd"); //Erro em runtime: Variavel dynamic agora é um tipo int - Não existe Metodo1()
            //variavelDynamic.MetodoNaoExistente(); //Erro em runtime: Variavel dynamic agora é um tipo int - Não existe MetodoNaoExistente()
            System.Console.WriteLine(variavelDynamic.Name); //Existe uma propriedade Name
            variavelDynamic.Metodo2(); //Existe um método Metodo2()
            //Atribuo outro tipo para uma variável dynamic
            variavelDynamic = 123;
            Console.WriteLine(variavelDynamic.GetType().FullName);

            /* Conclusões: 
            (i) Atribuição do tipo para uma variável/objeto dynamic é feita em runtime (tempo de execução)
            (ii) Não existe code complete para uma variável Dynamic, por isso devemos ter cuidado.
            (iii) É possível atribuir uma variável/objeto para uma dynamic com tipo diferente */
#endregion
        }
    }
}
