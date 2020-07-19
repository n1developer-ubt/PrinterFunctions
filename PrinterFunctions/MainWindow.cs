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
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace PrinterFunctions
{
    public partial class MainWindow : Form
    {
        private PrintServer _printers;
        private PrintServer _printServer;

        public MainWindow()
        {
            InitializeComponent();
            SetPosition();
            Configure();
            TopMost = true;
            TopLevel = true;

            CheckForIllegalCrossThreadCalls = false;

            Timer t = new Timer(2000);
            t.Enabled = true;
            t.Start();

            t.Elapsed += TOnElapsed;
        }

        private void TOnElapsed(object sender, ElapsedEventArgs e)
        {
            PrinterStateChanged();
        }

        private void Configure()
        {
            cbQueue.Items.Clear();

            _printers = new PrintServer();
            _printServer = new PrintServer(@"\\pharmacy02");

            EnumeratedPrintQueueTypes[] enumerationFlags = {EnumeratedPrintQueueTypes.Shared};

            var items = new List<string>();

            foreach (var queue in _printers.GetPrintQueues(enumerationFlags))
            {
                items.Add(queue.FullName);
            }

            foreach (var queue in _printServer.GetPrintQueues())
            {
                items.Add(queue.FullName);
            }

            cbQueue.Items.AddRange(items.ToArray<string>());
        }

        private void SetPosition()
        {
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                workingArea.Bottom - Size.Height);
        }

        private void PerformAction(ActionType action)
        {
            if (cbQueue.SelectedItem == null)
            {
                MessageBox.Show("Please select a queue");
            }

            var printerName = cbQueue.SelectedItem.ToString();

            var printers = printerName.StartsWith(@"\\") ? _printServer : _printers;

            switch (action)
            {
                case ActionType.DeleteAll:
                    foreach (var jobs in printers.GetPrintQueue(printerName).GetPrintJobInfoCollection())
                    {
                        jobs.Cancel();
                    }
                    break;

                case ActionType.Pause:
                    using (PrintQueue pq = new PrintQueue(printers, printerName,
                        PrintSystemDesiredAccess.AdministratePrinter))
                    {
                        pq.Pause();
                    }
                    break;

                case ActionType.Resume:
                    using (PrintQueue pq = new PrintQueue(printers, printerName,
                        PrintSystemDesiredAccess.AdministratePrinter))
                    {
                        pq.Resume();
                    }
                    break;
            }

            PrinterStateChanged();
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

        private void cbQueue_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrinterStateChanged();
        }

        private void PrinterStateChanged()
        {
            if (cbQueue.SelectedItem == null)
                return;
            
            var printerName = cbQueue.SelectedItem.ToString();

            var printers = printerName.StartsWith(@"\\") ? _printServer : _printers;

            btnDeleteAll.Text = "Delete All [" + printers.GetPrintQueue(printerName).GetPrintJobInfoCollection().Count() + "]";

            var isPause = printers.GetPrintQueue(printerName).IsPaused;

            btnPauseSelected.Enabled = !isPause;
            btnResumeSelected.Enabled = isPause;
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
