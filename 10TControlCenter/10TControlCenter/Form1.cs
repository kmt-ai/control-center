using System.IO;
using System.Windows.Forms;

namespace _10TControlCenter
{
    public partial class Form1 : Form
    {
        string bname = "";
        string path = @"C:\Users\Александр\Desktop\test\";
        string[] timInfo = {""};
        void teamPic(string bname, string path)
        {
            path = path + bname + ".txt";
            StreamReader st = new StreamReader(path);
            timInfo[0] = st.ReadToEnd();
            listBox1.Items.AddRange(timInfo);
            st.Close();
        }
        public Form1()
        {   
            InitializeComponent();
            
            
           
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bname = button1.Text;
            teamPic(bname, path);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bname = button2.Text;
            teamPic(bname, path);
        }
    }
}
