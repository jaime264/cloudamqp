using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using System.Configuration;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace CloudAMQP
{
    class Cloud
    {
        
        public ActionResult Publish()
        {
            ConnectionFactory factory = new ConnectionFactory();
            factory.Uri = new System.Uri("amqp://tdumtyjx:rDs1iz...@lion.rmq.cloudamqp.com/tdumtyjx");

            IConnection conn = factory.CreateConnection();

            // create a connection and open a channel, dispose them when done
            using (var channel = conn.CreateModel())
            {
                // The message we want to put on the queue
                var message = DateTime.Now.ToString("F");
                // the data put on the queue must be a byte array
                var data = Encoding.UTF8.GetBytes(message);
                // ensure that the queue exists before we publish to it
                var queueName = "queue1";
                bool durable = true;
                bool exclusive = false;
                bool autoDelete = false;
                channel.QueueDeclare(queueName, durable, exclusive, autoDelete, null);
                // publish to the "default exchange", with the queue name as the routing key
                var exchangeName = "";
                var routingKey = "queue1";
                channel.BasicPublish(exchangeName, routingKey, null, data);
            }
            return new EmptyResult();
        }

        //public ActionResult Get()
        //{
        //    ConnectionFactory factory = new ConnectionFactory();
        //    factory.Uri = new System.Uri("amqp://user:pass@hostName:port/vhost");

        //    IConnection conn = factory.CreateConnection();
        //    using (var channel = conn.CreateModel())
        //    {
        //        // ensure that the queue exists before we access it
        //        channel.QueueDeclare("queue1", false, false, false, null);
        //        var queueName = "queue1";
        //        // do a simple poll of the queue
        //        var data = channel.BasicGet(queueName, false);
        //        // the message is null if the queue was empty
        //        //if (data == null) return Json(null);
        //        // convert the message back from byte[] to a string
        //        var message = Encoding.UTF8.GetString(data.Body);
        //        // ack the message, ie. confirm that we have processed it
        //        // otherwise it will be requeued a bit later
        //        channel.BasicAck(data.DeliveryTag, false);
        //        //return Json(message);
        //    }
        //}


    }
}
