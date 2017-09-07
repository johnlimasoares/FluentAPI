using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleEstoque.Utils
{
    public class Worker : BackgroundWorker
    {
        public Action DoWorkDelegate { get; set; }
        public Action WorkerCompletedDelegate { get; set; }
        private ProgressBar progressBar;
        public Worker()
        {
            progressBar = new ProgressBar();
            progressBar.Location = new System.Drawing.Point(86, 101);
            progressBar.MarqueeAnimationSpeed = 300;
            progressBar.Maximum = 300;
            progressBar.Name = "progressBar1";
            progressBar.Size = new System.Drawing.Size(100, 23);
            progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            progressBar.TabIndex = 0;
            progressBar.Show();

        }

        protected override void OnDoWork(DoWorkEventArgs e)
        {
            base.OnDoWork(e);
            Thread.Sleep(5000);
        }

        protected override void OnRunWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
            base.OnRunWorkerCompleted(e);

            progressBar.Dispose();
        }
    }
}
