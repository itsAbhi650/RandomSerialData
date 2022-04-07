using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RandomSerialData
{
    public partial class Form1 : Form
    {
        byte[] buffer = new byte[1024];
        CancellationTokenSource tokenSource;
        SerialPort Port;
        public Form1()
        {
            InitializeComponent();
            Port = new SerialPort("COM3", 9600)
            {
                StopBits = StopBits.Two,
                DataBits = 8,
                Parity = Parity.None,
                DiscardNull = true,
                WriteTimeout = 2000
            };
            Port.Open();
            Port.DataReceived += Port_DataReceived;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            textBox1.AppendText($"Data received{Environment.NewLine}");
        }

        async Task GenerateRandomAsync()
        {
            Random rand = new Random(255);
            while (!tokenSource.IsCancellationRequested)
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 1024; i++)
                    {
                        buffer[i] = (byte)rand.Next(0, 255);
                    }
                    try
                    {
                        Port.Write(buffer, 0, buffer.Length);
                        textBox1.AppendText($"buffer[1024] written at port {Port.PortName}.{Environment.NewLine}");
                    }
                    catch (TimeoutException ex)
                    {
                        textBox1.AppendText(ex.Message+Environment.NewLine);
                        textBox1.AppendText($"Make sure device is connected!{Environment.NewLine}");
                        tokenSource.Cancel();
                        button1.Text = "Start";
                    }
                    finally
                    {
                        textBox1.ScrollToCaret();
                    }
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "Start")
            {
                btn.Text = "Stop";
                textBox1.Clear();
                tokenSource = new CancellationTokenSource();
                GenerateRandomAsync();
            }
            else
            {
                tokenSource.Cancel();
                btn.Text = "Start";
            }
        }
    }
}
