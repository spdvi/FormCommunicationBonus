using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormUI
{
    public class MessageModelEventArgs : EventArgs
    {
        public MessageModel message { get; set; }
    }
}
