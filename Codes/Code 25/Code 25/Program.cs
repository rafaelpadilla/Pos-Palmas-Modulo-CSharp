/****************************** Code 25 ******************************
 Code 11  : Lambda e LINQ
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Code_25
{
    class Program
    {
        static string pasta = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        static string arquivoProprietarios = pasta + "//XML_Proprietarios.xml";
        static string arquivoResidencias = pasta + "//XML_Residencias.xml";
        static string arquivoProprietariosResidencias = pasta + "//XML_Proprietarios_Residencias.xml";
        
        static void Main(string[] args)
        {
            DeserializaArquivo();
        }

        private static void DeserializaArquivo()
        {
            //Deserializa Proprietarios
            Proprietarios proprietarios = new Proprietarios();
            XmlSerializer serializer = new XmlSerializer(typeof(Proprietarios));
            StreamReader reader = new StreamReader(arquivoProprietarios);
            proprietarios = (Proprietarios)serializer.Deserialize(reader);
            reader.Close();

            //Deserializa Residencias
            Residencias residencias = new Residencias();
            serializer = new XmlSerializer(typeof(Residencias));
            reader = new StreamReader(arquivoResidencias);
            residencias = (Residencias)serializer.Deserialize(reader);
            reader.Close();

            //Deserializa Proprietarios Residencias
            Proprietarios_Residencias proprietariosResidencias = new Proprietarios_Residencias();
            serializer = new XmlSerializer(typeof(Proprietarios_Residencias));
            reader = new StreamReader(arquivoProprietariosResidencias);
            proprietariosResidencias = (Proprietarios_Residencias)serializer.Deserialize(reader);
            reader.Close();

            //Somente aqueles proprietários com Residência!
            Binding_Proprietario_Residencias bpr = new Binding_Proprietario_Residencias(proprietariosResidencias, proprietarios, residencias);

            //Usando LAMBDA para pegar todos os clientes que tenham nome que começam com a letra "D"
            List<Proprietario> proprietariosComLetra_D = proprietarios.TodosProprietarios.FindAll(p => p.Nome.ToUpper().StartsWith("D"));
            List<Proprietario> proprietariosTerminamLetra_O = proprietarios.TodosProprietarios.FindAll(p => p.NomeCompleto.ToUpper().EndsWith("O"));
            
            //Residencias e Precos
            List<Residencia> residenciasEmManaus = residencias.TodasResidencias.FindAll(r => r.Cidade.ToUpper() == "MANAUS");
            List<Residencia> residenciasEmManaus_PrecoAcima50k = residencias.TodasResidencias.FindAll(r => (r.Cidade.ToUpper() == "MANAUS") && (r.Preco > 50000));
            Residencia primeiraResidenciasEmManaus_PrecoAcima50k = residencias.TodasResidencias.Find(r => (r.Cidade.ToUpper() == "MANAUS") && (r.Preco > 50000));
            Residencia ultimaResidenciasEmManaus_PrecoAcima50k = residencias.TodasResidencias.FindLast(r => (r.Cidade.ToUpper() == "MANAUS") && (r.Preco > 50000));

            //Donos com mais de uma residencia
            List<Proprietario_Residencias> propMaisDeUmaResidencia = bpr.TodosProprietariosResidencias.FindAll(r => r.ResidenciasObj.TodasResidencias.Count > 1);

            //Proprietarios sem residencia
            // Percorre agora os proprietarios (tp), e verifica se existe algum que não esteja (!) na lista daqueles que possuem com residencia
            List <Proprietario> poprietariosSemResidencia = proprietarios.TodosProprietarios.Where(tp => !bpr.TodosProprietariosResidencias.Any(pr => pr.Codigo_Proprietario == tp.Codigo)).ToList();

            //Residencias sem proprietarios
            List<Residencia> residenciasSemProprietarios = residencias.TodasResidencias.Where(r => !bpr.TodosProprietariosResidencias.Any(pr => pr.ResidenciasObj.TodasResidencias.Exists(rr => rr.Codigo == r.Codigo))).ToList();

            //Residencias que possuem mais de um proprietário
            //Desafio!!!! Melhor fazer com LINQ!!!




            //Refazendo tudo com linq
            //LINQ: Pegando todos os clientes que tenham nome que começam com a letra "D"
            var linq_proprietariosComLetra_D =  //Eh um enumerable
                   from p in proprietarios.TodosProprietarios
                    where p.Nome.ToUpper().StartsWith("D")
                    select p;
            //Imprimir
            foreach (var a in linq_proprietariosComLetra_D)
                Console.WriteLine(a.Nome);
            //ou
            List<Proprietario> linq_List_proprietariosComLetra_D = linq_proprietariosComLetra_D.ToList();

            //LINQ: Pegando todos os clientes que tenham sobrenome que terminem com a letra "O"
            var linq_proprietariosTerminamLetra_O =  
                  from p in proprietarios.TodosProprietarios
                  where p.NomeCompleto.ToUpper().EndsWith("O")
                  select p;

            var linq_residenciasEmManaus =
                from r in residencias.TodasResidencias
                where r.Cidade.ToUpper() == "MANAUS"
                select r;
                
            var linq_residenciasEmManaus_PrecoAcima50k =
                 from r in residencias.TodasResidencias
                 where r.Cidade.ToUpper() == "MANAUS"
                 where r.Preco > 50000
                 select r;

            var linq_primeiraResidenciasEmManaus_PrecoAcima50k =
                 (from r in residencias.TodasResidencias
                 where r.Cidade.ToUpper() == "MANAUS"
                 where r.Preco > 50000
                 select r).FirstOrDefault(); //colocar FirstOrDefault() pois se não encontrar, retorna null !!! ;) Pode testar

            var linq_ultimaResidenciasEmManaus_PrecoAcima50k = 
                (from r in residencias.TodasResidencias
                where r.Cidade.ToUpper() == "MANAUS"
                where r.Preco > 50000
                select r).LastOrDefault();  //colocar LastOrDefault() pois se não encontrar, retorna null !!! ;)

            //Donos com mais de uma residencia
            var linq_propMaisDeUmaResidencia =
                from r in bpr.TodosProprietariosResidencias //Percorre todos proprietarios que possuem residencias
                where r.ResidenciasObj.TodasResidencias.Count > 1 //Verifica aquele que possui mais de uma
                select r;

            //Proprietarios sem residencia 
            var linq_poprietariosSemResidencia =
                (from tp in proprietarios.TodosProprietarios //Percorre todos os proprietarios
                 select tp).Except(from tp in bpr.TodosProprietariosResidencias select tp.ProprietarioObj); //Exceto aqueles que estão na bpr.TodosProprietariosResidencias
            //Proprietarios sem residencia (dá pra fazer com join)
            //Ex:
            //var linq_poprietariosSemResidencia_2 =
            //   from tp in proprietarios.TodosProprietarios //Percorre todos os proprietarios
            //    join pr in bpr.TodosProprietariosResidencias on tp.Codigo equals pr.Codigo_Proprietario
            //    select tb; //Não sei fazer com join pq join não tem "not equals"

            //Residencias sem proprietarios
            //Desafio para fazer

            //Residencias que possuem mais de um proprietário
            //Desafio para fazer

            //Fica o desafio para fazer com LINQ o casamento dos proprietariso (classe Proprietarios) com as residencias (classe Residencias)
            // objetivo é criar uma lista casando as residencias que tem ou nao usuarios
            // referencia para usarem: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/join-clause#left-outer-join
            //Desafio para fazer
        }


















    }
}
