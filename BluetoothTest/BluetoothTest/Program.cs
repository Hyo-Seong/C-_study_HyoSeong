using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BluetoothTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM8"; // 송신
            serialPort.Open();
            int counter = 0;
            while (serialPort.IsOpen)
            {
                // WRITE THE INCOMING BUFFER TO CONSOLE
                while (serialPort.BytesToRead > 0)
                {
                    Console.Write(Convert.ToChar(serialPort.ReadChar()));
                }
                // SEND
                serialPort.Write("aa");
                Console.WriteLine("PC counter: " + (counter++));
                Thread.Sleep(500);
            }
        }
    }
}
