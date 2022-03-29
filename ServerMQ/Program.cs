using RabbitMQ.Client;
using System;
using System.Security.Cryptography;
using RabbitMQ.Client.Events;
using System.Text;

namespace ServerMQ
{

    class RabbitMQ
    {

         
        public RabbitMQ()
        {

        }
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                 var body = ea.Body.ToArray();
                 var message = Encoding.UTF8.GetString(body);
                 Console.WriteLine("Добавили запись", message);
            };
            channel.BasicConsume(queue: "db_row",autoAck: true,consumer: consumer);
            
        }
    }
}
