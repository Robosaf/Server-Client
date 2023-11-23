using System;
using System.Net.Sockets;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    class Program
    {

        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<Socket> clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 69;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];
        private static Student firstStudent, secondStudent, thirdStudent, fourthStudent, fifthStudent;
        private static List<Student> studentsList;

        static void Main(string[] args)
        {
            Console.Title = "Server";
            StartServer();
            Console.ReadKey();
            CloseSockets();
        }

        private static void StartServer() 
        {
            Console.WriteLine("Starting server...");
            InitializeStudents();
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(5);
            serverSocket.BeginAccept(AcceptCallback, null);
            Console.WriteLine("Starting server was completed successfully");
        }
        private static void InitializeStudents()
        {
            studentsList = new List<Student>();
            firstStudent = new Student("Dariia Ilchuk", 5, 3, 4, 5, 4);
            secondStudent = new Student("Vasyl Moseichuk", 5, 2, 3, 4, 5);
            thirdStudent = new Student("Olesya Bila", 4, 5, 4, 5, 5);
            fourthStudent = new Student("Ira Chornobryva", 3, 4, 3, 3, 4);
            fifthStudent = new Student("Tosia Ilchuk", 4, 4, 5, 5, 5);
            studentsList.Add(firstStudent);
            studentsList.Add(secondStudent);
            studentsList.Add(thirdStudent);
            studentsList.Add(fourthStudent);
            studentsList.Add(fifthStudent);
        }
        private static void CloseSockets()
        {
            foreach (Socket socket in clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            serverSocket.Close();
        }



        

        private static void AcceptCallback(IAsyncResult asyncResult) 
        {
            Socket socket;
            try
            {
                socket = serverSocket.EndAccept(asyncResult);
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            clientSockets.Add(socket);
            socket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, socket);
            Console.WriteLine("Client connected. Waiting for request...");
            serverSocket.BeginAccept(AcceptCallback, null);
        }
        private static void ReceiveCallback(IAsyncResult asyncResult)
        {
            Socket currentSocket = (Socket)asyncResult.AsyncState;
            int received;

            try
            {
                received = currentSocket.EndReceive(asyncResult);
            }
            catch (SocketException)
            {
                Console.WriteLine("Client disconnected");
                 
                currentSocket.Close();
                clientSockets.Remove(currentSocket);
                return;
            }

            byte[] Buff = new byte[received];
            Array.Copy(buffer, Buff, received);
            string text = Encoding.ASCII.GetString(Buff);
            Console.WriteLine("Received Text: " + text);
             
            Random rnd = new Random();
            int quantityOfPeople = rnd.Next(0, studentsList.Count);


            if (text.ToLower() == "exit") 
            {
                currentSocket.Shutdown(SocketShutdown.Both);
                currentSocket.Close();
                clientSockets.Remove(currentSocket);
                Console.WriteLine("Client disconnected");
                return;
            }
            else if (text == "receiveAll")
            {
                ShowToClient(currentSocket);
            }
            else if(text == "History")
            {

                for (int i = 0; i < quantityOfPeople; i++)
                {
                    int rndChoose = rnd.Next(0, studentsList.Count);
                    if (studentsList[rndChoose].History != 5)
                    {
                        studentsList[rndChoose].History++;
                    }
                }
                ShowToClient(currentSocket);
            }
            else if (text == "Math")
            {

                for (int i = 0; i < quantityOfPeople; i++)
                {
                    int rndChoose = rnd.Next(0, studentsList.Count);
                    if (studentsList[rndChoose].Math != 5)
                    {
                        studentsList[rndChoose].Math++;
                    }
                }
                ShowToClient(currentSocket);
            }
            else if (text == "English")
            {

                for (int i = 0; i < quantityOfPeople; i++)
                {
                    int rndChoose = rnd.Next(0, studentsList.Count);
                    if (studentsList[rndChoose].English != 5)
                    {
                        studentsList[rndChoose].English++;
                    }
                }
                ShowToClient(currentSocket);
            }
            else if (text == "Physics")
            {

                for (int i = 0; i < quantityOfPeople; i++)
                {
                    int rndChoose = rnd.Next(0, studentsList.Count);
                    if (studentsList[rndChoose].Physics != 5)
                    {
                        studentsList[rndChoose].Physics++;
                    }
                }
                ShowToClient(currentSocket);
            }
            else if (text == "Biology")
            {
                for (int i = 0; i < quantityOfPeople; i++)
                {
                    int rndChoose = rnd.Next(0, studentsList.Count);
                    if (studentsList[rndChoose].Biology != 5)
                    {
                        studentsList[rndChoose].Biology++;
                    }
                }
                ShowToClient(currentSocket);
            }


            currentSocket.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, currentSocket);
        }

        private static void ShowToClient(Socket currentSocket)
        {
            string[] allstu = new string[studentsList.Count];
            for (int i = 0; i < studentsList.Count; i++)
            {
                allstu[i] += studentsList[i].ToString();
            }
            byte[] data = Encoding.ASCII.GetBytes(String.Join(' ', allstu));
            currentSocket.Send(data);
        }
    }
}
