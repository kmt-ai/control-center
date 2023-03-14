using System.IO;
namespace _10TControlCenter
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\Александр\Desktop\test\Team1.txt";
        public Form1()
        {   
            InitializeComponent();
            StreamReader st = new StreamReader(path);
            
           // button1.Text= st.ReadLine();
            
            
        }

        
    }
}
