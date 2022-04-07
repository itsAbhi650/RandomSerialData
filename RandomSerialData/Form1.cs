﻿using System;
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
            CmbBx_Port.DataSource = SerialPort.GetPortNames();
            CmbBx_Parity.DataSource = Enum.GetValues(typeof(Parity));
            Array StopBitArray = Enum.GetValues(typeof(StopBits));
            List<StopBits> StopBitList = new List<StopBits>();
            for (int i = 1; i < StopBitArray.Length; i++)
            {
                StopBitList.Add((StopBits)StopBitArray.GetValue(i));
            }
            CmbBx_StpBit.DataSource = StopBitList;
            CmbBx_Baud.SelectedIndex = 0;
            CmbBx_DatBit.SelectedIndex = 0;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            textBox1.AppendText($"Data received{Environment.NewLine}");
            Bitmap bm = new Bitmap(1024,1);
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
                        textBox1.AppendText(ex.Message + Environment.NewLine);
                        textBox1.AppendText($"Make sure device is connected!{Environment.NewLine}");
                        tokenSource.Cancel();
                        Btn_Start.Text = "Start";
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

        private void Btn_Connect_Click(object sender, EventArgs e)
        {
            if (Btn_Connect.Text == "Connect")
            {
                Port = new SerialPort(CmbBx_Port.SelectedItem.ToString(), int.Parse(CmbBx_Baud.SelectedItem.ToString()))
                {
                    DataBits = int.Parse(CmbBx_DatBit.SelectedItem.ToString()),
                    Parity = (Parity)CmbBx_Parity.SelectedIndex,
                    WriteTimeout = (int)NUD_Timeout.Value,
                };
                if (CmbBx_StpBit.SelectedIndex>0)
                {
                    Port.StopBits = (StopBits)CmbBx_StpBit.SelectedIndex;
                }
                Port.DataReceived += Port_DataReceived;
                Port.Open();
                Btn_Connect.Text = "Disconnect";
                textBox1.AppendText($"Connected to {Port.PortName}" + Environment.NewLine);
                Btn_Start.Enabled = true;
                Pnl_PortControl.Enabled = false;
            }
            else
            {
                tokenSource?.Cancel();
                Btn_Start.Text = "Start";
                Port.Close();
                Port.Dispose();
                Btn_Connect.Text = "Connect";
                textBox1.AppendText($"Disconnected" + Environment.NewLine);
                Btn_Start.Enabled = false;
                Pnl_PortControl.Enabled = true;
            }
        }
    }
}
