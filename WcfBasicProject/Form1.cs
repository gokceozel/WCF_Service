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
using WcfBasicProject.KategoriServiceReference;

namespace WcfBasicProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            
            ServiceRepositoryOf_CategoryDTOClient client = new ServiceRepositoryOf_CategoryDTOClient();
            dataGridView1.DataSource = client.GetList();
            client.Close();
        }
    }
}
