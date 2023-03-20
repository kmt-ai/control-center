using System.Net;
using System.Net.Sockets;
using System.Text;

class UDPServer
{
    private bool active;
    private Thread? ServerSend;

    private void Work()
    {
        while (active)
        {

        }
    }

    public void Start()
    {
        ServerSend = new Thread(Work);
    }

    public void Stop(CancellationToken cancel)
    {
        if (ServerSend != null && ServerSend.IsAlive)
        {

        }
    }
}

public class UDPClient
{
    private Thread? GetMessage;
    private IPAddress DeviceIP = new IPAddress(0x0100007F);
    private int Port;
    private Socket Connector = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

    public UDPClient(string ip, string port)
    {
        try
        {
            DeviceIP = IPAddress.Parse(ip);

        }
        catch
        {

        }

        try
        {
            Port = Convert.ToInt32(port);
        }
        catch
        {

        }
    }

    public async void Start()
    {
        IPEndPoint DeviceNetwork = new IPEndPoint(DeviceIP, Port);
        IPEndPoint test = new IPEndPoint(new IPAddress(0x0100007F), Port);
        Connector.Bind(test);

        byte[] Data = new byte[256];
        var result = await Connector.ReceiveFromAsync(Data, SocketFlags.ControlDataTruncated, DeviceNetwork);
        var message = Encoding.UTF8.GetString(Data, 0, result.ReceivedBytes);

        Console.WriteLine($"Получено {result.ReceivedBytes} байт");
        Console.WriteLine($"Удаленный адрес: {result.RemoteEndPoint}");
        Console.WriteLine(message);
    }
}