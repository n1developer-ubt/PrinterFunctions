using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterFunctions
{
    public partial class MainWindow : Form
    {
        private PrintServer _printServer;

        public MainWindow()
        {
            InitializeComponent();
            SetPosition();
            Configure();
            TopMost = true;
            TopLevel = true;
        }

        private void Configure()
        {

            cbQueue.Items.Clear();

            var x = new[]
                {EnumeratedPrintQueueTypes.Local ,
                    EnumeratedPrintQueueTypes.Shared ,
                    EnumeratedPrintQueueTypes.Connections ,
                    EnumeratedPrintQueueTypes.TerminalServer ,
                    EnumeratedPrintQueueTypes.Fax ,
                    EnumeratedPrintQueueTypes.KeepPrintedJobs ,
                    EnumeratedPrintQueueTypes.EnableBidi ,
                    EnumeratedPrintQueueTypes.RawOnly ,
                    EnumeratedPrintQueueTypes.WorkOffline ,
                    EnumeratedPrintQueueTypes.PublishedInDirectoryServices ,
                    EnumeratedPrintQueueTypes.DirectPrinting ,
                    EnumeratedPrintQueueTypes.Queued ,
                    EnumeratedPrintQueueTypes.PushedUserConnection ,
                    EnumeratedPrintQueueTypes.PushedMachineConnection ,
                    EnumeratedPrintQueueTypes.EnableDevQuery };


            _printServer = new PrintServer();

            EnumeratedPrintQueueTypes[] enumerationFlags = {EnumeratedPrintQueueTypes.Local};

            LocalPrintServer printServer = new LocalPrintServer();
            
            foreach (var queue in printServer.GetPrintQueues(enumerationFlags))
            {
                cbQueue.Items.Add(queue.FullName);
            }

            //foreach (var pq in ps.GetPrintQueues())
            //{
            //    foreach (var job in ps.GetPrintQueue(pq.Name).GetPrintJobInfoCollection())
            //    {
            //        MessageBox.Show(job.Name);
            //        job.Pause();
            //    }
            //}
        }

        private void SetPosition()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                workingArea.Bottom - Size.Height);
        }

        private void btnReloadQueues_Click(object sender, EventArgs e)
        {
            Configure();
        }

        private void PerformAction(ActionType action)
        {
            switch (action)
            {
                case ActionType.PauseAll:
                    foreach (var queue in _printServer.GetPrintQueues())
                    {
                        foreach (var jobs in _printServer.GetPrintQueue(queue.FullName).GetPrintJobInfoCollection())
                        {
                            jobs.Pause();
                        }
                    }
                    break;
                case ActionType.ResumeAll:
                    foreach (var queue in _printServer.GetPrintQueues())
                    {
                        foreach (var jobs in _printServer.GetPrintQueue(queue.FullName).GetPrintJobInfoCollection())
                        {
                            jobs.Resume();       
                        }
                    }
                    break;

                case ActionType.DeleteAll:
                    foreach (var queue in _printServer.GetPrintQueues())
                    {
                        foreach (var jobs in _printServer.GetPrintQueue(queue.FullName).GetPrintJobInfoCollection())
                        {
                            jobs.Cancel();
                        }
                    }
                    break;

                case ActionType.Pause:

                    if (cbQueue.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a queue");
                        break;
                    }

                    foreach (var jobs in _printServer.GetPrintQueue(cbQueue.SelectedItem.ToString()).GetPrintJobInfoCollection())
                    {
                        jobs.Pause();
                    }

                    break;

                case ActionType.Resume:

                    if (cbQueue.SelectedItem == null)
                    {
                        MessageBox.Show("Please select a queue");
                        break;
                    }

                    foreach (var jobs in _printServer.GetPrintQueue(cbQueue.SelectedItem.ToString()).GetPrintJobInfoCollection())
                    {
                        jobs.Resume();
                    }
                    break;
            }
        }

        private void btnResumeAll_Click(object sender, EventArgs e)
        {
            PerformAction(ActionType.Pause);
        }

        private void btnResumeSelected_Click(object sender, EventArgs e)
        {
            PerformAction(ActionType.Resume);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            PerformAction(ActionType.DeleteAll);
        }
    }

    enum ActionType
    {
        Pause,
        PauseAll,
        DeleteAll,
        Resume,
        ResumeAll
    }
}
