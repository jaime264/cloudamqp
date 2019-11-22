using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAhorrar_Click(object sender, EventArgs e)
        {
            var factory = new ConnectionFactory();
            factory.Uri = new System.Uri("amqp://tdumtyjx:rDs1izvNvJFESxqc-PzHNeXMX14SjexW@lion.rmq.cloudamqp.com/tdumtyjx");
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    String cola = "Ahorrar";
                    channel.QueueDeclare(cola, false, false, false, null);
                    String message = txtAhorrar.Text; ;
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish("", cola, null, body);
                }
            }
        }

        private void btnVerSaldo_Click(object sender, EventArgs e)
        {
            var factory = new ConnectionFactory();
            factory.Uri = new System.Uri("amqp://tdumtyjx:rDs1izvNvJFESxqc-PzHNeXMX14SjexW@lion.rmq.cloudamqp.com/tdumtyjx");
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    //channel.QueueDeclare(cola, false, false, false, null);
                    var consumer = new QueueingBasicConsumer(channel);
                    channel.BasicConsume("VerSaldo", true, consumer);

                    var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                    var body = ea.Body;
                    var message = Encoding.UTF8.GetString(body);
                    txtVerSaldo.Text = message;
                }
            }


        }
    }
}
