/****************************** Code 16 ******************************
 Code 16  : Deserialização (XML)
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Code_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaminhoXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Blablabla (.aaa)|*.xml|All Files (*.*)|*.*";
            fd.CheckFileExists = true;
            fd.ShowDialog();

            if (File.Exists(fd.FileName))
                txbCaminhoXML.Text = fd.FileName;
        }

        private void btnDeserializar_Click(object sender, EventArgs e)
        {
            Cars cars = null;
            XmlSerializer serializer = new XmlSerializer(typeof(Cars));

            StreamReader reader = new StreamReader(txbCaminhoXML.Text);
            cars = (Cars)serializer.Deserialize(reader);
            reader.Close();
        }
    }
}
