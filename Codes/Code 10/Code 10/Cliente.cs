using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_10
{
    class Cliente
    {
        public enum Sexo { Masculino, Feminino };

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public Sexo SexoCliente { get; set; }

        //É necessário uma validação, para isso usamos o conceito de Encapsulamento
        //Encapsulamento é a técnica que faz com que detalhes internos do funcionamento dos métodos de uma classe permaneçam ocultos para os objetos.
        private string _cpf;
        public string CPF
        {
            get { return _cpf; }
            set
            {
                //Retira pontos e traços
                value = value.Replace(".", "").Replace("-","");
                //Antes de atribuir o valor à variável, fazemos uma verificação
                int digito = 0;
                for (int i = 0; i<value.Length; i++)
                {
                    //Se não consegue fazer um parse para int
                    if (!int.TryParse(value[i].ToString(), out digito))
                    {
                        _cpf = null;
                        return;
                    }
                }
                _cpf = value;
            }
        }
    }
}
