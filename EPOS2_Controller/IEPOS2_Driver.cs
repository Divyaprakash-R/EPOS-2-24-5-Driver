using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOS2_Controller
{
    internal interface IEPOS2_Driver
    {
        bool Connect(string Portname, uint BaudRate, uint TImeout, ushort NodeId);

        bool Enable();

        void Start(int RPM);

        void Stop();

        bool Disable();

        bool DisConnect();

        long GetActualVelocity();
    }
}
