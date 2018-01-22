using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockeTerminal.Modules
{
    public class ReadCardEventArgs : EventArgs
    {
       
    }
    public class ReadCard
    {
        #region Events

        public EventHandler Read;

        #endregion

        #region Constructors

        public ReadCard(int intervalBetweenReads)
        {
            Interval = intervalBetweenReads;
        }

        #endregion

        #region Methods

        public void Begin()
        {
            if (Interval == 0)
            {
                Console.WriteLine("No card detected");
            }

            while (true)
            {
                System.Threading.Thread.Sleep(Interval);
                if (Read != null)
                {
                    Read(this, null);
                }

            }
        }

        #endregion

        #region Properties

        public int Interval { get; protected set; }

        #endregion
    }
}
