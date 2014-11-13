using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisorSum
{
    public class DivisorThreadState
    {
        public DivisorState State { get; set; }
        public int Data { get; set; }

        public DivisorThreadState()
        {
            State = DivisorState.HIT_MILESTONE;
            Data = 0;
        }
    }

    public enum DivisorState
    {
        FOUND_NUMBER = 0,
        HIT_MILESTONE = 1
    }
}
