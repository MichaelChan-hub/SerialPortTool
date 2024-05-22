namespace SerialPortCommunicateToolApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_Recieve = new Sunny.UI.UITextBox();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            combox_Parity = new Sunny.UI.UIComboBox();
            combox_StopBits = new Sunny.UI.UIComboBox();
            txtBox_DataBits = new Sunny.UI.UITextBox();
            txtBox_BaudRate = new Sunny.UI.UITextBox();
            resetBtn = new Sunny.UI.UIButton();
            openBtn = new Sunny.UI.UIButton();
            uiLabel5 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            combo_PortName = new Sunny.UI.UIComboBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            clearBtn = new Sunny.UI.UIButton();
            sendBtn = new Sunny.UI.UIButton();
            textBox_Send = new Sunny.UI.UITextBox();
            uiGroupBox3 = new Sunny.UI.UIGroupBox();
            uiGroupBox1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            uiGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Recieve
            // 
            textBox_Recieve.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Recieve.Location = new Point(4, 37);
            textBox_Recieve.Margin = new Padding(4, 5, 4, 5);
            textBox_Recieve.MinimumSize = new Size(1, 16);
            textBox_Recieve.Multiline = true;
            textBox_Recieve.Name = "textBox_Recieve";
            textBox_Recieve.Padding = new Padding(5);
            textBox_Recieve.ReadOnly = true;
            textBox_Recieve.ShowText = false;
            textBox_Recieve.Size = new Size(564, 206);
            textBox_Recieve.TabIndex = 2;
            textBox_Recieve.TextAlignment = ContentAlignment.TopLeft;
            textBox_Recieve.Watermark = "";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(combox_Parity);
            uiGroupBox1.Controls.Add(combox_StopBits);
            uiGroupBox1.Controls.Add(txtBox_DataBits);
            uiGroupBox1.Controls.Add(txtBox_BaudRate);
            uiGroupBox1.Controls.Add(resetBtn);
            uiGroupBox1.Controls.Add(openBtn);
            uiGroupBox1.Controls.Add(uiLabel5);
            uiGroupBox1.Controls.Add(uiLabel4);
            uiGroupBox1.Controls.Add(uiLabel3);
            uiGroupBox1.Controls.Add(uiLabel2);
            uiGroupBox1.Controls.Add(combo_PortName);
            uiGroupBox1.Controls.Add(uiLabel1);
            uiGroupBox1.FillColorGradient = true;
            uiGroupBox1.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.Location = new Point(6, 1);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(5, 32, 5, 5);
            uiGroupBox1.Size = new Size(227, 446);
            uiGroupBox1.TabIndex = 4;
            uiGroupBox1.Text = "串口设置";
            uiGroupBox1.TextAlignment = ContentAlignment.TopLeft;
            // 
            // combox_Parity
            // 
            combox_Parity.DataSource = null;
            combox_Parity.FillColor = Color.White;
            combox_Parity.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            combox_Parity.ItemHoverColor = Color.FromArgb(155, 200, 255);
            combox_Parity.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            combox_Parity.Location = new Point(87, 281);
            combox_Parity.Margin = new Padding(4, 5, 4, 5);
            combox_Parity.MinimumSize = new Size(63, 0);
            combox_Parity.Name = "combox_Parity";
            combox_Parity.Padding = new Padding(0, 0, 30, 2);
            combox_Parity.Size = new Size(131, 36);
            combox_Parity.SymbolSize = 24;
            combox_Parity.TabIndex = 15;
            combox_Parity.TextAlignment = ContentAlignment.MiddleLeft;
            combox_Parity.Watermark = "";
            // 
            // combox_StopBits
            // 
            combox_StopBits.DataSource = null;
            combox_StopBits.FillColor = Color.White;
            combox_StopBits.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            combox_StopBits.ItemHoverColor = Color.FromArgb(155, 200, 255);
            combox_StopBits.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            combox_StopBits.Location = new Point(87, 220);
            combox_StopBits.Margin = new Padding(4, 5, 4, 5);
            combox_StopBits.MinimumSize = new Size(63, 0);
            combox_StopBits.Name = "combox_StopBits";
            combox_StopBits.Padding = new Padding(0, 0, 30, 2);
            combox_StopBits.Size = new Size(131, 36);
            combox_StopBits.SymbolSize = 24;
            combox_StopBits.TabIndex = 14;
            combox_StopBits.TextAlignment = ContentAlignment.MiddleLeft;
            combox_StopBits.Watermark = "";
            // 
            // txtBox_DataBits
            // 
            txtBox_DataBits.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_DataBits.Location = new Point(87, 161);
            txtBox_DataBits.Margin = new Padding(4, 5, 4, 5);
            txtBox_DataBits.MinimumSize = new Size(1, 16);
            txtBox_DataBits.Name = "txtBox_DataBits";
            txtBox_DataBits.Padding = new Padding(5);
            txtBox_DataBits.ShowText = false;
            txtBox_DataBits.Size = new Size(131, 36);
            txtBox_DataBits.TabIndex = 13;
            txtBox_DataBits.TextAlignment = ContentAlignment.MiddleLeft;
            txtBox_DataBits.Watermark = "";
            // 
            // txtBox_BaudRate
            // 
            txtBox_BaudRate.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_BaudRate.Location = new Point(87, 104);
            txtBox_BaudRate.Margin = new Padding(4, 5, 4, 5);
            txtBox_BaudRate.MinimumSize = new Size(1, 16);
            txtBox_BaudRate.Name = "txtBox_BaudRate";
            txtBox_BaudRate.Padding = new Padding(5);
            txtBox_BaudRate.ShowText = false;
            txtBox_BaudRate.Size = new Size(131, 36);
            txtBox_BaudRate.TabIndex = 12;
            txtBox_BaudRate.TextAlignment = ContentAlignment.MiddleLeft;
            txtBox_BaudRate.Watermark = "";
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resetBtn.Location = new Point(44, 394);
            resetBtn.MinimumSize = new Size(1, 1);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(125, 44);
            resetBtn.TabIndex = 11;
            resetBtn.Text = "重置";
            // 
            // openBtn
            // 
            openBtn.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            openBtn.Location = new Point(44, 335);
            openBtn.MinimumSize = new Size(1, 1);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(125, 44);
            openBtn.TabIndex = 10;
            openBtn.Text = "打开串口";
            openBtn.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            openBtn.Click += openBtn_Click;
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(8, 280);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(80, 37);
            uiLabel5.TabIndex = 8;
            uiLabel5.Text = "校验位：";
            uiLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(8, 219);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(80, 37);
            uiLabel4.TabIndex = 6;
            uiLabel4.Text = "停止位：";
            uiLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(8, 160);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(80, 37);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "数据位：";
            uiLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(8, 104);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(80, 37);
            uiLabel2.TabIndex = 2;
            uiLabel2.Text = "波特率：";
            uiLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // combo_PortName
            // 
            combo_PortName.DataSource = null;
            combo_PortName.FillColor = Color.White;
            combo_PortName.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            combo_PortName.ItemHoverColor = Color.FromArgb(155, 200, 255);
            combo_PortName.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            combo_PortName.Location = new Point(87, 49);
            combo_PortName.Margin = new Padding(4, 5, 4, 5);
            combo_PortName.MinimumSize = new Size(63, 0);
            combo_PortName.Name = "combo_PortName";
            combo_PortName.Padding = new Padding(0, 0, 30, 2);
            combo_PortName.Size = new Size(131, 36);
            combo_PortName.SymbolSize = 24;
            combo_PortName.TabIndex = 1;
            combo_PortName.TextAlignment = ContentAlignment.MiddleLeft;
            combo_PortName.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 10F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(8, 49);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(80, 37);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "端口号：";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(clearBtn);
            uiGroupBox2.Controls.Add(sendBtn);
            uiGroupBox2.Controls.Add(textBox_Send);
            uiGroupBox2.FillColorGradient = true;
            uiGroupBox2.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.Location = new Point(240, 259);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(576, 188);
            uiGroupBox2.TabIndex = 5;
            uiGroupBox2.Text = "数据发送";
            uiGroupBox2.TextAlignment = ContentAlignment.TopLeft;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.Location = new Point(474, 136);
            clearBtn.MinimumSize = new Size(1, 1);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(95, 44);
            clearBtn.TabIndex = 12;
            clearBtn.Text = "清除消息";
            clearBtn.Click += clearBtn_Click;
            // 
            // sendBtn
            // 
            sendBtn.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sendBtn.Location = new Point(474, 86);
            sendBtn.MinimumSize = new Size(1, 1);
            sendBtn.Name = "sendBtn";
            sendBtn.Size = new Size(95, 44);
            sendBtn.TabIndex = 11;
            sendBtn.Text = "发送";
            sendBtn.Click += sendBtn_Click;
            // 
            // textBox_Send
            // 
            textBox_Send.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Send.Location = new Point(4, 37);
            textBox_Send.Margin = new Padding(4, 5, 4, 5);
            textBox_Send.MinimumSize = new Size(1, 16);
            textBox_Send.Multiline = true;
            textBox_Send.Name = "textBox_Send";
            textBox_Send.Padding = new Padding(5);
            textBox_Send.ShowText = false;
            textBox_Send.Size = new Size(463, 143);
            textBox_Send.TabIndex = 0;
            textBox_Send.TextAlignment = ContentAlignment.TopLeft;
            textBox_Send.Watermark = "";
            // 
            // uiGroupBox3
            // 
            uiGroupBox3.Controls.Add(textBox_Recieve);
            uiGroupBox3.FillColorGradient = true;
            uiGroupBox3.Font = new Font("宋体", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox3.Location = new Point(244, 1);
            uiGroupBox3.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox3.MinimumSize = new Size(1, 1);
            uiGroupBox3.Name = "uiGroupBox3";
            uiGroupBox3.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox3.Size = new Size(576, 256);
            uiGroupBox3.TabIndex = 6;
            uiGroupBox3.Text = "接收";
            uiGroupBox3.TextAlignment = ContentAlignment.TopLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 459);
            Controls.Add(uiGroupBox2);
            Controls.Add(uiGroupBox3);
            Controls.Add(uiGroupBox1);
            Name = "MainForm";
            Text = "串口通讯助手";
            Load += MainForm_Load;
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            uiGroupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UITextBox textBox_Recieve;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox combo_PortName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton resetBtn;
        private Sunny.UI.UIButton openBtn;
        private Sunny.UI.UIButton clearBtn;
        private Sunny.UI.UIButton sendBtn;
        private Sunny.UI.UITextBox textBox_Send;
        private Sunny.UI.UITextBox txtBox_DataBits;
        private Sunny.UI.UITextBox txtBox_BaudRate;
        private Sunny.UI.UIComboBox combox_Parity;
        private Sunny.UI.UIComboBox combox_StopBits;
        private Sunny.UI.UIGroupBox uiGroupBox3;
    }
}
