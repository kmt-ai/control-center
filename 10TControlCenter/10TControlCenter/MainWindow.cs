using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace _10TControlCenter
{
    public partial class MainWindow : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        string teamData;
        string bname;
        string[] timInfo = {""};
        
        void teamPic(string bname)
        {
            StreamReader st = new StreamReader(bname + ".txt");

            string? line = st.ReadLine();

            while (line != null)
            {
                int index = listBox1.Items.Add(line);
                line = st.ReadLine();
            }

            st.Close();
        }
        public MainWindow()
        {   
            InitializeComponent();
            AllocConsole();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bname = button1.Text;
            teamPic(bname);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bname = button2.Text;
            teamPic(bname);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1252, 583);
            this.Name = "MainWindow";
            this.ResumeLayout(false);

        }
    }
}
