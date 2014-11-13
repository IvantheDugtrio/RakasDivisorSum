using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorSum
{
    public class DivisorThread
    {
        public const int COMPUTE_CHUNKSIZE = 10000;

        public BackgroundWorker Worker { get; set; }

        public bool Running { get; set; }
        public int Iterator { get; set; }
        public int TestIterator { get; set; }
        public int StartNumber { get; set; }
        public int EndNumber { get; set; }

        public DivisorThread()
        {
            Worker = new BackgroundWorker();

            Running = false;
            Iterator = 1;
            TestIterator = 1;
            StartNumber = 1;
            EndNumber = 1;
            
            Worker.DoWork += think;
            Worker.WorkerReportsProgress = true;
        }

        public void run()
        {
            if(!Running)
            {
                Running = true;

                Worker.RunWorkerAsync();
            }

            return;
        }

        protected void think(object sender, DoWorkEventArgs e)
        {
            while (!isFinished())
            {
                DivisorThreadState state = new DivisorThreadState();

                state.Data = compute(COMPUTE_CHUNKSIZE);

                if (state.Data != 0)
                {
                    state.State = DivisorState.FOUND_NUMBER;
                }
                else
                {
                    state.State = DivisorState.HIT_MILESTONE;

                    state.Data = StartNumber;
                }

                Worker.ReportProgress((StartNumber * 100 / EndNumber), state);
            }

            return;
        }

        protected int compute(int searches)
        {
            int foundNumber = 0;
            int currentNumber = StartNumber;
            int endNum = (currentNumber + searches >= EndNumber) ? EndNumber : currentNumber + searches;

            while(foundNumber == 0 && currentNumber <= endNum)
            {
                int maxNum = (currentNumber / 2) + 1;
                int sum = 0;

                for (int x = 1; x <= maxNum; x += TestIterator)
                {
                    if (currentNumber % x == 0)
                    {
                        sum += x;
                    }
                }

                if(sum == currentNumber)
                {
                    foundNumber = currentNumber;
                }

                currentNumber += Iterator;
            }

            StartNumber = currentNumber;

            return foundNumber;
        }

        public bool isFinished()
        {
            return StartNumber >= EndNumber;
        }
    }
}
