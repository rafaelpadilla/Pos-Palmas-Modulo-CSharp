/****************************** Code 24 ******************************
 Code 11  : Criando e Destruindo Objetos (instâncias)
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Code_24
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> minhaLista = new List<string>();

        }
    }
    //O GarbageCollector é muito eficiente para eliminar objetos GERENCIÁVEIS!
    //Objetos não gerenciáveis, como os das classes das dlls do Windows (/System32), recursos externos, como arquivos 
    // abertos, conexão com bancos de dados, etc. são objetos não gerenciaveis, e o 
    // GarbageCollector não é capaz de executar o "padrão de descarte" (dispose pattern) nestes objetos. Então se sua classe trabalha com
    // Objetos não gerenciáveis, é necessário implementar a interface IDisposable;

    //nós não conseguimos liberar memória deles explicitamente.Isso sempre será responsabilidade do GC, 
    // que fará isso na hora em que ele quiser.

    //Se você escolher implementar uma certa rotina de banco de dados em uma classe C#, e resolver fechar a conexão no 
    // finalizador da classe, a rotina será concluída, a variável que aponta para o objeto será liberada, 
    // mas ainda assim o objeto estará “vivo”, aguardando um GC chamar seu finalizador e liberá-lo. 
    // E isso irá manter a conexão com o banco aberta por um bom tempo.

    class MinhaClasse : IDisposable
    {
        //Vamos simular um objeto não gerenciável (embora o reader já tenha um Dispose (pois é uma classe do .NET), 
        //vamos fingir que ele não seja gerenciável)
        StreamReader reader;

        // Para objetos não gerenciados, o SafeHangle resolve o problema de não gerenciáveis pra gente
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        //Recursos já foram liberados? = Garbage Collector já foi alertado que tem que chamar o finalizador (~MinhaClasse)?
        bool recursosLiberados = false; //um nome melhor seria recursosSolicitadosParaLiberacao

        public MinhaClasse(string arquivo)
        {
            reader = new StreamReader(arquivo);
        }

        public string LeArquivo()
        {
            return reader.ReadToEnd();
        }

        //Finalizador:
        //Este metodo é o finalizador, que é invocado pelo GC para liberar os recursos.
        //Todo a liberacao implementada dentro dele só será executada quando o metodo for invocado pelo GC, porém não
        //conseguimos saber quando isto vai acontecer e recursos importantes podem ficar presos até que isto aconteça.
        ~MinhaClasse()
        {
            Dispose(false);
        }

        //Quando o Dispose é acionado, os recursos gerenciados e não gerenciados são liberados e ainda avisamos o GC
        //para nao acionar o finalizador pois ele já não é mais necessário
        public void Dispose() //Necessário pela IDisposable
        {
            Dispose(true);
            GC.SuppressFinalize(this); //Garbage Collector sabe agora que tem que chamar o nosso finalizador ~MinhaClasse
        }

        private void Dispose(bool liberaRecursos)
        {
            //Esse método já foi chamado antes solicitando a Liberação de Recursos?
            if (this.recursosLiberados)
                return;

            //Caso o objeto ainda não tenha sido destruído libera-se os recursos
            //Se é para liberar recursos libera-se os recurso gerenciados    
            if (liberaRecursos)
            {
                //Libera recursos gerenciados
                reader.Dispose(); //Pq o método já é gerenciado e já em o .Dispose()
                //Caso não tenha, uma maneira muito eficiente é chamar o handle.Dispose()
                handle.Dispose(); //-> Método muito potente que vai procurar liberar recursos não gerenciáveis
            }
            //Sempre libera-se os recursos não gerenciados, como utilizacao de ponteiros
            //em chamadas a API do Windows e já assume-se que os recursos foram liberados
            recursosLiberados = true;
        }
    }
}
