using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ControlCenter
{
    public partial class MainWindow : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public MainWindow()
        {
            InitializeComponent();
            AllocConsole();
            UDPClient client = new UDPClient("192.168.10.209", "8888");
            client.Start();
        }
        void teamPic(string bname)
        {
            StreamReader st = new StreamReader(bname + ".txt");

            string? line = st.ReadLine();

            while (line != null)
            {
                line = st.ReadLine();
            }

            st.Close();
        }
    }
}