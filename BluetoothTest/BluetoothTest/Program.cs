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
            Console.WriteLine("Connection...1");
            SerialPort serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM8"; // 송신
            Console.WriteLine("Connection...2");
            serialPort.Open();
            Console.WriteLine("Connected!");
            serialPort.Write("Connected!");
            String response = null;
            while (serialPort.IsOpen)
            {
                response = null;
                // WRITE THE INCOMING BUFFER TO CONSOLE
                while (serialPort.BytesToRead > 0)
                {
                    
                    response += Convert.ToChar(serialPort.ReadChar());
                }
                // SEND
                Console.WriteLine(response);
                serialPort.Write("ddaa + " + response);
                Thread.Sleep(500);
            }
        }
    }
}
