using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NewsClient
{
    public static class ClientRequest
    {
        private const int port = 8888;
        private const string server = "127.0.0.1";

        public static bool ValidationCheck(string login, string password)
        {
            bool result = false;
            
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                NetworkStream stream = client.GetStream();

                // сообщение для отправки серверу
                string sendLogPass = "SIGNIN" + "#" + login + "#" + password;
                // преобразуем сообщение в массив байтов
                byte[] sendData = Encoding.UTF8.GetBytes(sendLogPass);

                // отправка сообщения
                stream.Write(sendData, 0, sendData.Length);

                byte[] data = new byte[256];
                StringBuilder response = new StringBuilder();
                
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable); // пока данные есть в потоке

                if(response.ToString().ToLower() == "true")
                {
                    result = true;
                }

                // Закрываем потоки
                stream.Close();
                client.Close();
            }
            catch (SocketException e) {}
            catch (Exception e) {}

            return result;
        }

        public static bool RegisterAccount(string login, string password)
        {
            bool result = false;
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                NetworkStream stream = client.GetStream();

                // сообщение для отправки серверу
                string sendLogPass = "SIGNUP" + "#" + login + "#" + password;
                // преобразуем сообщение в массив байтов
                byte[] sendData = Encoding.UTF8.GetBytes(sendLogPass);

                // отправка сообщения
                stream.Write(sendData, 0, sendData.Length);

                byte[] data = new byte[256];
                StringBuilder response = new StringBuilder();

                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable); // пока данные есть в потоке

                if (response.ToString().ToLower() == "true")
                {
                    result = true;
                }

                // Закрываем потоки
                stream.Close();
                client.Close();
            }
            catch (SocketException e) { }
            catch (Exception e) { }

            return result;
        }

        public static string GetNews(string login, string password)
        {
            string news = "";
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                NetworkStream stream = client.GetStream();

                // сообщение для отправки серверу
                string sendLogPass = "GETNEWS" + "#" + login + "#" + password;
                // преобразуем сообщение в массив байтов
                byte[] sendData = Encoding.UTF8.GetBytes(sendLogPass);

                // отправка сообщения
                stream.Write(sendData, 0, sendData.Length);

                //ПОЛУЧЕНИЕ СООБЩЕНИЯ
                byte[] data = new byte[8096];
                StringBuilder response = new StringBuilder();

                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    response.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable); // пока данные есть в потоке

                if (response.ToString().ToLower() != "notAct")
                {
                    news = response.ToString();
                }

                // Закрываем потоки
                stream.Close();
                client.Close();
            }
            catch (SocketException e) { }
            catch (Exception e) { }

            return news;
        }

        public static void SendNews(string login, string password, string msg)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(server, port);
                NetworkStream stream = client.GetStream();

                // сообщение для отправки серверу
                string sendLogPass = "OFFERNEWS" + "#" + msg;
                // преобразуем сообщение в массив байтов
                byte[] sendData = Encoding.UTF8.GetBytes(sendLogPass);

                // отправка сообщения
                stream.Write(sendData, 0, sendData.Length);

                // Закрываем потоки
                stream.Close();
                client.Close();
            }
            catch (SocketException e) { }
            catch (Exception e) { }
        }
    }
}
