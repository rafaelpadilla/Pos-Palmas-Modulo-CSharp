/****************************** Code 16 ******************************
 Code 16         : Deserialização JSON
 Autor           : Rafael Padilla
 Data            : 07 de outubro de 2017
 Versão          : 1.0
****************************************************************************/

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Code_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaminhoJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Arquivos JSON (.json)|*.json|All Files (*.*)|*.*";
            fd.CheckFileExists = true;
            fd.ShowDialog();

            if (File.Exists(fd.FileName))
                txbCaminhoJSON.Text = fd.FileName;
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            //Lendo arquivo local .json
            StreamReader reader = new StreamReader(txbCaminhoJSON.Text);
            string json = reader.ReadToEnd();
            //Instalar via Nuget Newtonsoft.Json
            Rootobject myObject = JsonConvert.DeserializeObject<Rootobject>(json);
        }
    }

    //Editar -> Colar Especial -> Criar JSON como classes
    public class Rootobject
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string nextPageToken { get; set; }
        public string regionCode { get; set; }
        public Pageinfo pageInfo { get; set; }
        public Item[] items { get; set; }
    }

    public class Pageinfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }

    public class Item
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public Id id { get; set; }
    }

    public class Id
    {
        public string kind { get; set; }
        public string channelId { get; set; }
        public string videoId { get; set; }
    }

}
