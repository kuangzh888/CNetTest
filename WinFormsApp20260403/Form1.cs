
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace WinFormsApp20260403
{
    public partial class Form1 : Form
    {
        int count = 0;
        string str = "hello world!";

        public Form1()
        {
            InitializeComponent();
        }

        private async Task button1_Click(object sender, EventArgs e)
        {
            //// cpu密集型 io密集型
            //Task.Run(() =>
            //{
            //    HashSet<string> strSets = new HashSet<string>();
            //    for (int i = 0; i < 10000000; i++)
            //    {
            //        Guid guid = Guid.NewGuid();
            //        strSets.Add(guid.ToString());
            //    }
            //    MessageBox.Show($"HashSet<string> contains {strSets.Count} items.");
            //});

            // https://httpbin.org/delay/3
            HttpClient httpClient = new HttpClient();
            string url = "https://httpbin.org/delay/3";
            PrintTask();
            
            string result = await httpClient.GetStringAsync(url);
            Debug.WriteLine($"{result}");
            MessageBox.Show($"{result}");
            PrintTask();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = $"{count++}";
            PrintTask();
        }

        static void PrintTask(string info = "")
        {
            Debug.WriteLine($"线程id: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
