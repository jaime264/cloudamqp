using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudAMQP
{
    public partial class Banco : Form
    {
        static double suma;
        public Banco()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            var factory = new ConnectionFactory();
            factory.Uri = new System.Uri("amqp://tdumtyjx:rDs1izvNvJFESxqc-PzHNeXMX14SjexW@lion.rmq.cloudamqp.com/tdumtyjx");

            double valor = 0.0;


            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    //channel.QueueDeclare(cola, false, false, false, null);
                    var consumer = new QueueingBasicConsumer(channel);
                    channel.BasicConsume("Ahorrar", true, consumer);

                    var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    valor = Double.Parse(message);

                }
            }

            suma = suma + valor;

            txtProcesar.Text = suma.ToString();

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    String cola = "VerSaldo";
                    channel.QueueDeclare(cola, false, false, false, null);
                    String message = suma.ToString();
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish("", cola, null, body);
                }
            }

        }



    }
}

