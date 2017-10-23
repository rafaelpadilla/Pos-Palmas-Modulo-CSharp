using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Code_16
{
    public class Car
    {
        [System.Xml.Serialization.XmlElement("Codigo")]
        public int StockNumber { get; set; }

        [System.Xml.Serialization.XmlElement("Marca")]
        public string Brand { get; set; }

        [System.Xml.Serialization.XmlElement("Modelo")]
        public string Model { get; set; }

        [System.Xml.Serialization.XmlElement("Ano")]
        public string Year { get; set; }

        [System.Xml.Serialization.XmlElement("Preco")]
        public double Price { get; set; }
    }

    //É preciso identificar o elemento raiz!!!
    [System.Xml.Serialization.XmlRoot("ElementoRaiz")]
    public class Cars
    {
        //[System.Xml.Serialization.XmlElement("DataCriacao")]
        public string DataCriacao { get; set; }

        [XmlArray("Carros")] //É um array...
        [XmlArrayItem("Carro", typeof(Car))] //...de carros
        public List<Car> Carros { get; set; }
    }
}
