using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Code_25
{
    #region Deserializacao
    public class Residencia
    {
        [System.Xml.Serialization.XmlElement("Codigo")]
        public int Codigo { get; set; }
        [System.Xml.Serialization.XmlElement("Endereco")]
        public string Endereco { get; set; }
        [System.Xml.Serialization.XmlElement("Cidade")]
        public string Cidade { get; set; }
        [System.Xml.Serialization.XmlElement("UF")]
        public string UF { get; set; }
        [System.Xml.Serialization.XmlElement("M2")]
        public float Tamanho_M2 { get; set; }
        [System.Xml.Serialization.XmlElement("Preco")]
        public float Preco { get; set; }
    }

    [System.Xml.Serialization.XmlRoot("ElementoRaiz")]
    public class Residencias
    {
        [XmlArray("Residencias")] //É um array...
        [XmlArrayItem("Residencia", typeof(Residencia))] //"... de Residencia
        public List<Residencia> TodasResidencias { get; set; }
    }

    public class Proprietario
    {
        [System.Xml.Serialization.XmlElement("Codigo")]
        public int Codigo { get; set; }
        [System.Xml.Serialization.XmlElement("Nome")]
        public string Nome { get; set; }
        [System.Xml.Serialization.XmlElement("Sobrenome")]
        public string Sobrenome { get; set; }

        public string NomeCompleto { get { return Nome + " " + Sobrenome; } }
    }

    [System.Xml.Serialization.XmlRoot("ElementoRaiz")]
    public class Proprietarios
    {
        [XmlArray("Proprietarios")] //É um array...
        [XmlArrayItem("Proprietario", typeof(Proprietario))] //"... de proprietarios
        public List<Proprietario> TodosProprietarios { get; set; }
    }

    [System.Xml.Serialization.XmlRoot("ElementoRaiz")]
    public class Proprietarios_Residencias
    {
        //Propriedades para Deserializacao
        [XmlArray("Proprietarios_Residencias")] //É um array...
        [XmlArrayItem("Proprietario_Residencia", typeof(Proprietario_Residencias))] //"... de proprietarios
        public List<Proprietario_Residencias> CodResidencias { get; set; }
    }

    //Um proprietario tem varias residencias!!! Eh assim que modelamos o XML
    public class Proprietario_Residencias
    {
        //Propriedades para Deserializacao
        [System.Xml.Serialization.XmlElement("Codigo_Proprietario")]
        public int Codigo_Proprietario { get; set; }
        [XmlArray("Residencias")] //É um array...
        [XmlArrayItem("Codigo_Residencia", typeof(int))] //"... de inteiros
        public List<int> Codigo_Residencias { get; set; }

        //Metodos que irao ser usados para preencher os objetos de proprietario e residencia
        public Proprietario ProprietarioObj { get; set; } //Um proprietario proprietarios
        public Residencias ResidenciasObj { get; set; } //Varias residencias
    }

    #endregion

    //!!Temos 1 proprietario e varias residencias vinculadas a ele => Assim foi nossa modelagem

    //Esta classe faz o binding de objetos Residencia e Proprietarios
    public class Binding_Proprietario_Residencias
    {
        public List<Proprietario_Residencias> TodosProprietariosResidencias{ get; set; }

        public Binding_Proprietario_Residencias(Proprietarios_Residencias prop_residencias, Proprietarios proprietarios, Residencias residencias)
        {
            //Faz o binding daqueles proprietarios que POSSUEM residência
            TodosProprietariosResidencias = new List<Proprietario_Residencias>();
            foreach (var p in prop_residencias.CodResidencias)
            {
                //Define objeto para ser inserido na lista
                Proprietario_Residencias pr = new Proprietario_Residencias();
                pr.ProprietarioObj = new Proprietario(); //Inicia objeto de proprietario
                pr.ResidenciasObj = new Residencias(); //Inicia objeto de residencias

                /*Proprietario*/
                //Define código do proprietario
                pr.Codigo_Proprietario = p.Codigo_Proprietario;
                //Procura na lista de proprietarios (proprietarios) as informações do proprietario e o adicionamos na lista
                pr.ProprietarioObj = proprietarios.TodosProprietarios.Find(a => a.Codigo == p.Codigo_Proprietario);

                /*Residencias*/
                //Define codigo das residencias
                pr.Codigo_Residencias = p.Codigo_Residencias;
                //Procura na lista de residencias (residencias) as informações das residencias do proprietario
                pr.ResidenciasObj.TodasResidencias = residencias.TodasResidencias.FindAll(a => p.Codigo_Residencias.Contains(a.Codigo));

                //Adiciona na lista
                TodosProprietariosResidencias.Add(pr);
            }
        }
    }
    

}
