using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleWCFService; 

namespace WCFSelfHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceHost svhost;

        private void button1_Click(object sender, EventArgs e)
        {
            
            svhost = new ServiceHost(typeof(User));
            svhost.AddServiceEndpoint(typeof(IUserService),new BasicHttpBinding(), "http://localhost:20020/samplewcfservice"); 
            svhost.Open();
            MessageBox.Show("Service started");  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            svhost.Close(); 
        }
    }
}
