/****************************** Code 14  ******************************
 Code 11  : Web com Windows Forms
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Code_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            wbrBrowser.ScriptErrorsSuppressed = true;

            wbrBrowser.DocumentCompleted += WbrBrowser_DocumentCompleted;
        }

        private void WbrBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url != wbrBrowser.Url)
                return;

            if (wbrBrowser.ReadyState == WebBrowserReadyState.Complete)
            {
                //Console.WriteLine(wbrBrowser.DocumentText);
                lblStatus.Text = "Terminou";
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            wbrBrowser.Navigate(txbEndereco.Text);
            lblStatus.Text = "Abrindo a página...";
        }
    }
}
