using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//kommer använda sockets
using System.Net.Sockets;

namespace dickcord10.Net
{
    internal class Server
    {

        TcpClient _client;
            //construktooorr 
       public Server()
        {
            _client = new TcpClient();
         }

        public void ConnectToServer()
        {
            if (!_client.Connected)
            {
                _client.Connect("127.0.0.1", 7891);

            }
        }














    }

}
