using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPortCommunicateToolApp
{
    public class KeyValueStopBits
    {
        public float key { get; set; }
        public StopBits value { get; set; }
    }

    public class KeyValueParity
    {
        public string key { get; set; }
        public Parity value { get; set; }
    }
}
