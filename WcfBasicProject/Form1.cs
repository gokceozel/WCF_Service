using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF_Service.Nrhwind;
using WcfBasicProject.UrunServiceReference;

namespace WcfBasicProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {

            ServiceRepositoryOf_ProductDTOClient client = new ServiceRepositoryOf_ProductDTOClient();
            var list = client.GetList();
        }
    }
}
