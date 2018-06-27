using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using CGPACalculatorClass;

namespace CGPACalculatorServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(1234);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.RegisterWellKnownServiceType
            (typeof(CGPACalculatorClass.CgpaCalculator), "CgpaCalculator", WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Started");
            Console.ReadKey();
        }
    }
}
