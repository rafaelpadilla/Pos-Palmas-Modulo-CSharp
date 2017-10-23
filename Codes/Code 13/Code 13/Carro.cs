using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_13
{
    class Carro
    {
        public enum Cor { Branco, Preto, Azul, Amarelo, Vermelho, Cinza };
        public enum Marca { Volkswage, Fiat, Mercedes, Honda, Chevrolet, Ford };

        public List<Roda> Rodas { get; }
        public Cor CorCarro { get; set; } //Set pois pode ser alterada sempre
        public Marca MarcaCarro { get; }

        public Carro(Marca marca, Cor cor, int qteRodas, int tamanhoAro, bool possuiCalota)
        {
            //Define marca
            MarcaCarro = marca;
            //Define cor
            CorCarro = cor;
            //Instancia rodas
            Rodas = new List<Roda>();
            for (int i = 0; i < qteRodas; i++)
                Rodas.Add(new Roda(i, tamanhoAro, possuiCalota));
        }

        public void AlteraRodas(int idRoda, bool possuiCalota, int tamanhoAro)
        {
            //Roda só pode ter id 0, 1, 2 ou 3
            if (idRoda >= 0 && idRoda <= 3)
                //Altera informacoes da Roda (Obs: O id não é alterado)
                Rodas[idRoda] = new Roda(idRoda, tamanhoAro, possuiCalota);
            else
                throw new Exception(string.Format("Não existe roda com o id {0}", idRoda));
        }

        public void ImprimeInformacoesRodas()
        {
            System.Console.WriteLine("Informações da Roda:");
            foreach (Roda roda in Rodas)
            {
                System.Console.WriteLine("Id: {0}", roda.IdRoda);
                System.Console.WriteLine("PossuiCalota: {0}", roda.PossuiCalota);
                System.Console.WriteLine("TamanhoAro: {0}", roda.TamanhoAro);
            }
            System.Console.WriteLine("---------------------------");
        }
    }

    class Roda
    {
        public int IdRoda { get; set; }
        public int TamanhoAro { get; }
        public bool PossuiCalota { get; }

        public Roda(int idRoda, int tamanhoAro, bool possuiCalota)
        {
            IdRoda = idRoda;
            TamanhoAro = tamanhoAro;
            PossuiCalota = possuiCalota;
        }
    }
}
