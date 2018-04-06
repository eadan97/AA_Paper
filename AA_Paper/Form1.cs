using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using AA_Paper.Classes;

namespace AA_Paper
{
    public partial class Form1 : Form

    {
        private readonly Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            btnGo.Enabled = false;
            lstPermutaciones.Items.Clear();
            bgwGo.RunWorkerAsync();
        }

        private void bgwGo_DoWork(object sender, DoWorkEventArgs e)
        {
            //Begin startup
            stopwatch.Restart();
            //int cantElements = (int) spnElements.Value;
            Population population = new Population((int) spnElements.Value);
            //stopwatch.Stop();
            bgwGo.ReportProgress(0, new ReportData(1, stopwatch.ElapsedMilliseconds, null));
            //stopwatch.Restart();
            do
            {
                //bgwGo.ReportProgress(90, new ReportData(2, stopwatch.ElapsedMilliseconds, population.ToString()));
            } while (population.doMagicStuff());

            stopwatch.Stop();
            bgwGo.ReportProgress(90, new ReportData(2, stopwatch.ElapsedMilliseconds, null));
        }

        private void bgwGo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (((ReportData) e.UserState).type)
            {
                case 1:
                    lblTiempoStartup.Text = ((ReportData) e.UserState).elapsedMilliseconds.ToString();
                    break;
                case 2:
                    lblTiempoPermutaciones.Text = ((ReportData) e.UserState).elapsedMilliseconds.ToString();
                    break;
            }

            if (((ReportData) e.UserState).permutation != null)
            {
                lstPermutaciones.Items.Add(((ReportData) e.UserState).permutation);
            }
        }

        private void bgwGo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblTiempoTotal.Text =
                (Int32.Parse(lblTiempoStartup.Text) + Int32.Parse(lblTiempoPermutaciones.Text)).ToString();
            btnGo.Enabled = true;
        }
    }

    internal class ReportData
    {
        public int type; //1 initial //2 permutation
        public long elapsedMilliseconds;
        public string permutation;

        public ReportData(int type, long elapsedMilliseconds, string permutation)
        {
            this.type = type;
            this.elapsedMilliseconds = elapsedMilliseconds;
            this.permutation = permutation;
        }
    }
}