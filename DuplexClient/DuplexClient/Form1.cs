using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using DuplexClient.ProcessService;

namespace DuplexClient
{
    //public delegate void mydel(int code);

    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class Form1 : Form, ProcessService.IProcess1Callback
    {
        
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            InstanceContext cntx = new InstanceContext(this);
            Process1Client pc = new Process1Client(cntx);
            pc.TaskProcess();
        }

        void IProcess1Callback.TaskProcessStatus(int percentCode)
        {
            ProgressBar.CheckForIllegalCrossThreadCalls = false;
            progressBar1.Value = percentCode;
            //progressBar1.Invoke(new Action(() => progressBar1.Value = percentCode));
            //mydel m = new mydel(setprogress);
            //m(percentCode);
            
        }

        public void setprogress(int code)
        {
            
        }
    }
}
