/****************************** Code 05 ******************************
 Code 05  : Conversão de Variáveis
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;

namespace Code_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal meuAnimal = new Cachorro();
            Cachorro cachorrao = meuAnimal as Cachorro;

            #region Conversão explícita (cast) e Conversão implícita
            //Conversoes entre tipos
            double x = 1234.7;
            // Cast double to int: Desconsidera as casas decimais
            int a = (int)x;
            System.Console.WriteLine(a);
            //Exception é lancada quando não é possivel fazer a conversao
            object o = "Rafael";
            //x = (double)o;  //Erro em runtime: Não é possivel fazer a conversão

            #region  Conversões de variáveis
            byte myByte; //0 ~ 255
            sbyte mySbyte; //-128 ~ 127 
            short myShort; //-32768 ~ 32767
            ushort myUshort; //0 ~ 65535
            int myInt; //-2,147,483,648 ~ 2,147,483,647
            uint myUint; //0 ~ 4294967295
            long myLong; //-9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807
            ulong myUlong; //0 ~ 18,446,744,073,709,551,615
            float myFloat; //-3.402823e38 ~ 3.402823e38
            double myDouble; //-1.79769313486232e308 ~ 1.79769313486232e308
            decimal myDecimal; //-79228162514264337593543950335 ~ 79228162514264337593543950335
            char myChar; 
            
            //Conversões Implícitas: Só é permitido dentro do range (ex: range menor para um range maior)
            mySbyte = 127;
            //myByte = mySbyte; //Erro de compilação: Não permite pois o range de um Sbyte é menor que o range do byte
            myShort = mySbyte;
            myInt = mySbyte;
            myLong = mySbyte;
            myFloat = mySbyte;
            myDouble = mySbyte;
            myDecimal = mySbyte;
            //mySbyte = myByte; //Erro compilação. Não permite conversão implícita. É necessãrio conversão explícita (cast), atentando para os ranges min e máx.
            //myChar = myByte; //Erro compilação. Não permite conversão implícita. É necessãrio conversão explícita (cast), atentando para os ranges min e máx.

            //Conversões Explícitas (cast): Pode perder precisão ou resultar em exceptions
            //Ex: byte -> sbyte ou char
            myByte = 255;
            //myByte = (decimal)decimal.MaxValue; //Não permite compilar, pois os ranges são diferentes
            mySbyte = (sbyte)myByte; //Permite conversão, astribuindo -1! Pois os ranges são diferentes.
            myShort = (short)myByte;
            myUshort = (ushort)myByte;
            myInt = (int)myByte;
            myUint = (uint)myByte;
            myLong = (long)myByte;
            myUlong = (ulong)myByte;
            myFloat = (float)myByte;
            myDouble = (double)myByte;
            myChar = (char)myByte;

            //Conversão através da classe Covert
            //myInt = Convert.ToInt64(long.MaxValue); //Não permite converter um tipo long em um int. Motivo: Abrangência do long é maior que a do int
            myInt = (int)Convert.ToInt64(ushort.MaxValue); //Convert.ToInt64 retorna um long. É preciso fazer um cast -> Ok! Ushort está dentro do int
            myInt = (int)Convert.ToInt64(long.MaxValue); //Convert.ToInt64 retorna um long. É preciso fazer um cast -> Cast vai retornar -1, pois range do long é maior que o do int

            //Parse e TryParse: Permite converter strings em tipos primitivos
            //Dar sempre preferência ao TryParse
            myShort = short.Parse(sbyte.MaxValue.ToString()); //Ok, pois range do Sbyte é menor que o do Short
            //mySbyte = sbyte.Parse(short.MaxValue.ToString()); //Exception em runtime: Range do Sbyte é menor que o do Short
            //mySbyte = sbyte.Parse("128"); //Exception em runtime: 128 não está no range do sbyte
            mySbyte = sbyte.Parse("127"); //Ok, pois 127 está no range do sbyte

            sbyte.TryParse("128", out mySbyte); //Utilizando TryParse -> Embora 128 esteja fora do range do sbyte, não levanta exception. Valor do mySbyte obtido é o default 0
            sbyte.TryParse("127", out mySbyte); //Utilizando TryParse -> Valor alterado, pois está no range

            /*Conclusões:
             * (i) a conclusão mais importante é sempre testar os limites máximos e mínimos que as variáveis possivelmente terão
             * (ii) conversão explícita (cast) traz erro em runtime quando não é possivel fazer a conversão.
             * (iii) há casos que conversão explícita (cast) permite compilar mesmo quando a conversão não é possível.
             * (iv) há casos que a conversão explícita (cast) não permite compilar quando os ranges são diferentes
             * (v) conversões implícitas só são permitidas entre um range menor para um range maior
             * (vi) para coversões de string, prefira sempre o TryParse
             */
            #endregion

            //Conversões entre classes
            // Create a new derived type.
            Girafa g = new Girafa();
            g.Nome = "Girafa Chico";
            g.Altura = 5.5;
            g.Idade = 15;
            g.TamanhoPescoco = 3.2;
            //Atribuição para a classe pai
            Animal animal = g;
            //Conversão explícita (cast) é necessária para converter de volta para a classe filha
            //Atenção: Irá compilar, mas exception será lenaçada em runtime se o objeto animal não for do tipo Girafa
            Girafa g2 = (Girafa)animal;
            #endregion

            #region Operador As (Tenta converter, quando não é possível, objeto vira null)
            //Quando a conversão nao eh possivel, objeto vira null
            Cachorro cachorro = new Cachorro();
            cachorro.Nome = "Cachorro Luíz";
            cachorro.Altura = 0.30;
            cachorro.Idade = 5;
            cachorro.LateMuito = true;
            Animal novoAnimal = new Animal();
            novoAnimal.Nome = "Animal Dinossauro";
            novoAnimal.Altura = 18;
            novoAnimal.Idade = 200000000;
            Cachorro novoCachorro = novoAnimal as Cachorro; //Não é possivel fazer esta conversão, pois nem todo animal eh cachorro
            novoAnimal = cachorro as Animal; //Conversão é possível pois todo cachorro é um animal
            
            

            string nome = "Joao";
            double res = 12.12;
            //res = (nome as double); //Erro de compilação: Não pode, pois (res) double não eh nullable
            #endregion
        }

      
    }
}
