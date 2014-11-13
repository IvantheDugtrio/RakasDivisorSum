using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivisorSum
{
    public partial class DivisorUI : Form
    {
        protected DivisorThread[] divisorThreads;
        protected int numThreads;
        protected int finishedThreads;
        protected int currentNumber;

        public DivisorUI()
        {
            InitializeComponent();
            
            divisorThreads = new DivisorThread[1];
            numThreads = 1;
            finishedThreads = 0;
            currentNumber = 0;

            threadBox.Text = (Environment.ProcessorCount - 1).ToString();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int iterate = 1;
            int testIterate = 1;
            int startNum = 1;
            int endNum = 1;

            finishedThreads = 0;
            currentNumber = 0;
            
            Int32.TryParse(numIterateBox.Text, out iterate);
            Int32.TryParse(numTestIterateBox.Text, out testIterate);
            Int32.TryParse(numStartBox.Text, out startNum);
            Int32.TryParse(numEndBox.Text, out endNum);
            Int32.TryParse(threadBox.Text, out numThreads);

            // Number of threads safety
            if(numThreads < 1)
            {
                numThreads = 1;
            }
            else if(numThreads > Environment.ProcessorCount - 1)
            {
                numThreads = Environment.ProcessorCount;
            }

            // Disable UI
            toggleUI(false);

            foundNumBox.Text = "";

            // Initialize thread data & start
            divisorThreads = new DivisorThread[numThreads];

            for (int x = 0; x < numThreads; x++)
            {
                DivisorThread thread = new DivisorThread();

                thread.Iterator = numThreads * iterate;
                thread.TestIterator = testIterate;
                thread.StartNumber = startNum + (iterate * x);
                thread.EndNumber = endNum;

                thread.Worker.ProgressChanged += progressChanged;
                thread.Worker.RunWorkerCompleted += threadFinish;

                divisorThreads[x] = thread;

                thread.run();
            }

            return;
        }

        private void threadReport(DivisorThreadState state)
        {
            if(state.State == DivisorState.FOUND_NUMBER)
            {
                foundNumBox.AppendText(state.Data + Environment.NewLine);
            }

            if(state.Data > currentNumber)
            {
                currentNumberBox.Text = state.Data.ToString();
            }

            return;
        }

        private void progressChanged(object sender, ProgressChangedEventArgs e)
        {
            threadReport((DivisorThreadState) e.UserState);

            return;
        }

        private void threadFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            finishedThreads++;

            if(finishedThreads == numThreads)
            {
                // Enable UI
                toggleUI(true);
            }

            return;
        }

        private void toggleUI(bool toggle)
        {
            numStartBox.Enabled = toggle;
            numEndBox.Enabled = toggle;
            numIterateBox.Enabled = toggle;
            numTestIterateBox.Enabled = toggle;
            threadBox.Enabled = toggle;
            startButton.Enabled = toggle;

            return;
        }

    }
}
