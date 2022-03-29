using System;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace ServerSocket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Устанавливаем для сокета локальную конечную точку
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);

            // Создаем сокет Tcp/Ip
            Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            sListener.Bind(ipEndPoint);
            // Начинаем слушать соединения
            sListener.Listen(10);

            // Назначаем сокет локальной конечной точке и слушаем входящие сокеты
            while (true)
            {
                // Программа приостанавливается, ожидая входящее соединение
                Socket handler = sListener.Accept();
                try
                {
                    Console.WriteLine("Ожидаем соединение через порт {0}", ipEndPoint);

                    
                    string data = null;

                    // Мы дождались клиента, пытающегося с нами соединиться

                    byte[] bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);

                    data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

                    // Показываем данные на консоли
                    Console.Write("Полученный текст: " + data + "\n\n");

                    // Отправляем ответ клиенту\
                    string reply = "Спасибо за запрос в " + data.Length.ToString()
                            + " символов";
                    byte[] msg = Encoding.UTF8.GetBytes(reply);
                    handler.Send(msg);



                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
        }
    }
}
