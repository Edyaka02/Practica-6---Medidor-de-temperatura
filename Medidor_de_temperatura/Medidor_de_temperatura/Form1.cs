using System;
using System.IO.Ports;
using System.Threading;


namespace Medidor_de_temperatura
{
    public partial class Form1 : Form
    {

        SerialPort sp = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void but_desconectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (sp.IsOpen)
                {
                    sp.Close();
                    MessageBox.Show("Desconectado del puerto " + sp.PortName);
                }
                else
                {
                    MessageBox.Show("El puerto ya está desconectado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desconectar: " + ex.Message);
            }
        }

        private void but_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                sp.PortName = this.cb_conexiones.Text;
                sp.BaudRate = 9600;
                sp.Open();
                sp.DataReceived += new SerialDataReceivedEventHandler(recibir_temperatura);
                MessageBox.Show("Conectado al puerto " + sp.PortName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar el puerto " + sp.PortName);
            }
        }

        private void but_actualizar_Click(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            this.cb_conexiones.DataSource = puertos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] puertos = SerialPort.GetPortNames();
            this.cb_conexiones.DataSource = puertos;
        }

        private void recibir_temperatura( object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort actualSP = (SerialPort)sender;
            string tmp = actualSP.ReadLine();
            this.lab_temperatura.Invoke(new MethodInvoker(delegate
            {
                this.lab_temperatura.Text = "" + tmp + " °C";
            }));
        }
    }
}
