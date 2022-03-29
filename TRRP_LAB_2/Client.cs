using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using System.Net.Sockets;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Data.SQLite;
namespace TRRP_LAB_2
{
    class Client
    {
        

        static void SendMessageFromMQ()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "hello",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                string message = "Hello World!";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                             routingKey: "hello",
                                             basicProperties: null,
                                             body: body);
                Console.WriteLine(" [x] Sent {0}", message);
            }

            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }

        static void SendMessageFromSocket(string host, int port, string ms)
        {
            // Буфер для входящих данных
            byte[] bytes = new byte[1024];
            var param = JObject.Parse(File.ReadAllText("settings.json"));
            // Соединяемся с удаленным устройством

            // Устанавливаем удаленную точку для сокета
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(host), port);

            Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // Соединяем сокет с удаленной точкой
            sender.Connect(ipEndPoint);

            Console.WriteLine("Сокет соединяется с {0} ", sender.RemoteEndPoint.ToString());
            // Строку в байты
            byte[] msg = Encoding.UTF8.GetBytes(ms);

            // Отправляем данные через сокет
            int bytesSent = sender.Send(msg);

            // Получаем ответ от сервера
            int bytesRec = sender.Receive(bytes);

            Console.WriteLine("\nОтвет от сервера: {0}\n\n", Encoding.UTF8.GetString(bytes, 0, bytesRec));

            // Освобождаем сокет
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
    }
}