using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Communication
{   
    //串口工具类
    public static class SerialPortUtils
    {


        ////获取串口信息
        //public static string[] GetPortNames()
        //{
        //    return SerialPort.GetPortNames();
        //}


        private static SerialPort serialPort = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comName">串口名</param>
        /// <param name="baud">波特率</param>
        /// <param name="dataBits">数据位</param>
        /// <param name="stopBits"></param>
        /// <param name="parity"></param>
        /// <returns></returns>
        public static SerialPort OpenPort(string comName, int baud,int dataBits,StopBits stopBits,Parity parity)
        {                  
                serialPort = new SerialPort();
                //串口名称
                serialPort.PortName = comName;
                //波特率
                serialPort.BaudRate = baud;
                //数据位
                serialPort.DataBits = dataBits;
                //停止位
                serialPort.StopBits = StopBits.One;
                //校验位
                serialPort.Parity = Parity.None;
            try
            {
                //打开串口
                serialPort.Open();
                //串口数据接收事件实现
                //serialPort.DataReceived += new SerialDataReceivedEventHandler(ReceiveData);
                return serialPort;
            }
            catch
            {

                throw new Exception("该端口打开失败，该端口可能已被占用！"); ;
            }
            
        }


        public static void ClosePort()
        {        
            if(serialPort!=null)
                serialPort.Close();   
        }


        public static bool SendData(string data)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.Write(data);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
