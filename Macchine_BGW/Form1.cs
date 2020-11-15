using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Macchine_BGW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random rnd = new Random();

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            PictureBox Macchina = (PictureBox)e.Argument;

            while (MacchinaNera.Location.X < ptb3.Width - MacchinaNera.Width + ptb3.Location.X ||
                MacchinaRossa.Location.X < ptb3.Width - MacchinaRossa.Width + ptb3.Location.X)
            {
                if (!bgw.CancellationPending)
                {
                    Thread.Sleep(rnd.Next(0, 10));
                    int n = rnd.Next(0, 5);
                    bgw.ReportProgress(n, Macchina);
                }
            }

            if (!bgw.CancellationPending)
                e.Result = Macchina;

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PictureBox Macchina = (PictureBox)e.UserState;
            int x = Macchina.Location.X + e.ProgressPercentage;
            Macchina.Location = new Point(x, Macchina.Location.Y);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (MacchinaNera.Location.X == MacchinaRossa.Location.X)
                MessageBox.Show("Pareggio");
            else if (MacchinaNera.Location.X > MacchinaRossa.Location.X)
                MessageBox.Show("Macchina nera");
            else if (MacchinaRossa.Location.X > MacchinaNera.Location.X)
                MessageBox.Show("Macchina rossa");
        }


        private void RipristinaPosizioneMacchine()
        {
            MacchinaNera.Location = new Point(0, MacchinaNera.Location.Y);
            MacchinaRossa.Location = new Point(0, MacchinaRossa.Location.Y);
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(MacchinaNera);
            backgroundWorker2.RunWorkerAsync(MacchinaRossa);
        }

        private void btnRivincita_Click(object sender, EventArgs e)
        {
            RipristinaPosizioneMacchine();
            btnStart_Click(sender, e);
        }
    }
}
