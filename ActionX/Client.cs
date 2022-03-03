using System;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ActionX
{
	public class Client
	{
		private TcpClient? connection;
		private NetworkStream? stream;

		public Client(TcpClient connection, NetworkStream stream)
		{
			this.connection = connection;
			this.stream = stream;
            ListenMessageAndDisconnection();
		}

		private async void ListenMessageAndDisconnection()
		{
			try
			{
				byte[]? bytes = new byte[256];
				string data;
				do
				{
					int num = await stream.ReadAsync(bytes);
					int i;
					if ((i = num) == 0)
					{
						break;
					}
					data = Encoding.ASCII.GetString(bytes, 0, i);
					ActionX.Instance.AddLog(" - Received: " + data);
				}
				while (!(data == "disconnect"));
				CloseConnection();
				bytes = null;
			}
			catch (Exception ex)
			{
				CloseConnection();
				if (ex.Message.StartsWith("Unable to read data from the transport connection: An existing connection was forcibly closed by the remote host."))
				{
					ActionX.Instance.AddLog("A Connection Was Forcibly Closed");
				}
				else
				{
					ActionX.Instance.AddLog(string.Format("Error (listenMessageAndDisconnection): {0}", ex));
				}
			}
		}

		public async Task SendMessage(string text)
		{
			try
			{
				if (connection != null)
				{
					byte[]? msg = Encoding.ASCII.GetBytes(text);
                    await stream.WriteAsync(msg);
					ActionX.Instance.AddLog(" - Sent: " + text);
				}
			}
			catch (Exception ex)
			{
				ActionX.Instance.AddLog(string.Format("Error (sendMessage): {0}", ex));
			}
		}

		public void CloseConnection()
		{
			if (connection != null)
			{
				connection.Close();
				connection = null;
				stream = null;
				ActionX.Instance.Clients.Remove(this);
				ActionX.Instance.AddLog("A Client Connection Closed");
			}
		}
	}
}
