using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockeTerminal.Modules
{
    public class ReadCardListener
    {
        public ReadCardListener()
        {

        }

        #region Methods

        public void Listen(ReadCard readCard)
        {
            readCard.Read += OnReadCallThis;
        }

        private void OnReadCallThis(object sender, EventArgs e)
        {

            Console.WriteLine("Waiting for card");
        }

        #endregion
    }
}
