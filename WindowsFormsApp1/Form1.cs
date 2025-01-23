using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace TelemetryGroundStation
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private StreamWriter logFile;
        private bool isLogging = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Configuração da porta serial
                serialPort = new SerialPort("COM3", 9600);
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();

                txtLog.AppendText("Conexão com o módulo HC-12 estabelecida.\r\n");
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"Erro ao conectar ao módulo HC-12: {ex.Message}\r\n");
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine();

                Invoke(new Action(() =>
                {
                    txtLog.AppendText($"{DateTime.Now}: {data}\r\n");

                    if (isLogging && logFile != null)
                    {
                        logFile.WriteLine($"{DateTime.Now}, {data}");
                    }
                }));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    txtLog.AppendText($"Erro ao receber dados: {ex.Message}\r\n");
                }));
            }
        }

        private void btnStartLogging_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isLogging)
                {
                    logFile = new StreamWriter($"TelemetryLog_{DateTime.Now:yyyyMMdd_HHmmss}.csv");
                    logFile.WriteLine("Timestamp, Data");

                    isLogging = true;
                    txtLog.AppendText("Iniciando o log de telemetria...\r\n");
                }
                else
                {
                    txtLog.AppendText("O log já está em andamento.\r\n");
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"Erro ao iniciar o log: {ex.Message}\r\n");
            }
        }

        private void btnStopLogging_Click(object sender, EventArgs e)
        {
            try
            {
                if (isLogging)
                {
                    isLogging = false;

                    if (logFile != null)
                    {
                        logFile.Close();
                        logFile = null;
                    }

                    txtLog.AppendText("Log de telemetria encerrado.\r\n");
                }
                else
                {
                    txtLog.AppendText("Nenhum log está em andamento.\r\n");
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"Erro ao encerrar o log: {ex.Message}\r\n");
            }
        }

        private void btnIgnite_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.WriteLine("IGNITE");
                    txtLog.AppendText("Comando de ignição enviado ao foguete.\r\n");
                }
                else
                {
                    txtLog.AppendText("Porta serial não está aberta. Comando de ignição não enviado.\r\n");
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"Erro ao enviar comando de ignição: {ex.Message}\r\n");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                }

                if (logFile != null)
                {
                    logFile.Close();
                }
            }
            catch (Exception ex)
            {
                txtLog.AppendText($"Erro ao fechar recursos: {ex.Message}\r\n");
            }
        }
    }
}
