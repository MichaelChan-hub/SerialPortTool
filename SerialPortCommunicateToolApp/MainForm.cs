using Communication;
using Sunny.UI;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortCommunicateToolApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        SerialPort serialPort;
        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();//获取电脑上可用串口号
            SerialPort serialPort;
            #region 控件内容初始化
            combo_PortName.Items.AddRange(ports);//给comboBox1添加数据
            combo_PortName.SelectedIndex = combo_PortName.Items.Count > 0 ? 0 : -1;//如果里面有数据,显示第0个

            List<KeyValueStopBits> stopBitList = new List<KeyValueStopBits>();

            
            //初始化combostopbit
            stopBitList.Add(new KeyValueStopBits
            {
                key = 0,
                value = StopBits.None
            });
            stopBitList.Add(new KeyValueStopBits
            {
                key = 1,
                value = StopBits.One
            });
            stopBitList.Add(new KeyValueStopBits
            {
                key = 1.5f,
                value = StopBits.OnePointFive
            });
            combox_StopBits.DataSource = stopBitList;
            combox_StopBits.ValueMember = "value";
            combox_StopBits.DisplayMember = "key";

            List<KeyValueParity> parityList = new List<KeyValueParity>();
            parityList.Add(new KeyValueParity
            {
                key = "none",
                value = Parity.None
            });
            parityList.Add(new KeyValueParity
            {
                key = "odd",
                value = Parity.Odd
            });
            parityList.Add(new KeyValueParity
            {
                key = "even",
                value = Parity.Even
            });
            parityList.Add(new KeyValueParity
            {
                key = "mark",
                value = Parity.Mark
            });
            parityList.Add(new KeyValueParity
            {
                key = "space",
                value = Parity.Space
            });
            combox_Parity.DataSource = parityList;
            combox_Parity.ValueMember = "value";
            combox_Parity.DisplayMember = "key";

            txtBox_BaudRate.Text = "9600";/*默认波特率:115200*/
            combox_StopBits.Text = "1";/*默认停止位:1*/
            txtBox_DataBits.Text = "8";/*默认数据位:8*/
            #endregion

            
        }



        private void openBtn_Click(object sender, EventArgs e)
        {

            if (openBtn.Text == "打开串口")
            {
                int baudRate = int.Parse(txtBox_BaudRate.Text);
                int dataBits = int.Parse(txtBox_DataBits.Text);
                StopBits stopBits = (StopBits)combox_StopBits.SelectedValue;
                Parity parity = (Parity)combox_Parity.SelectedValue;
                serialPort=SerialPortUtils.OpenPort(this.combo_PortName.Text, baudRate, dataBits, stopBits, parity);
                serialPort.DataReceived += new SerialDataReceivedEventHandler(AppendMsg);
                openBtn.Text = "关闭串口";
            }
            else
            {
                serialPort.Close();
                openBtn.Text = "打开串口";
            }
        }

        private void AppendMsg(object sender, SerialDataReceivedEventArgs e)
        {
            
            SerialPort serialPort = (SerialPort)sender;
            int bytesToRead = serialPort.BytesToRead;
            byte[] receiveData = new byte[bytesToRead];
            serialPort.Read(receiveData, 0, bytesToRead);

            string str = BitConverter.ToString(receiveData);
            
            this.Invoke(() =>
            {
                string dateTime = DateTime.Now.ToString();
                this.textBox_Recieve.AppendText("[" + dateTime +"]:"+str+ "\r\n");
            });
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox_Recieve.Text = "";
            textBox_Send.Text = "";
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (this.serialPort!=null&&this.serialPort.IsOpen)
            {
                string text = textBox_Send.Text;
                if (text.Length > 0)
                {
                    SerialPortUtils.SendData(text);
                }
            }
            else
            {
                this.ShowErrorDialog("错误", "请先打开端口！");
            }
            
        }
    }
}
