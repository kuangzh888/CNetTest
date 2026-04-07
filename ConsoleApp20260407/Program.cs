using System.Reflection.Metadata.Ecma335;




namespace ConsoleApp20260407
{
    internal class Program
    {

        int total = 0;

        static void Main(string[] args)
        {
            //using StreamWriter sw = new StreamWriter("d:/abc.txt", true);
            //sw.WriteLine("Hello");
            //sw.WriteLine("Kitty");
            //Console.WriteLine("写入完成"); 
            // 加using不需要调用 sw.Close(); using的作用域是{}结束
            // sw.Close();

            //using StreamReader sr = new StreamReader("abc.txt");
            //string line = sr.ReadLine();
            //while (line != null)
            //{
            //    Console.WriteLine(line);
            //    line = sr.ReadLine();
            //}

            // 文件复制操作
            //string srcPath = "a.mp4";
            //string targetPath = "b.mp4";

            //using FileStream fsRead = new FileStream(srcPath, FileMode.Open, FileAccess.Read);
            //using FileStream fsWrite = new FileStream(targetPath, FileMode.Create, FileAccess.Write);

            //byte[] buffer = new byte[1024 * 4];
            //int byteRead = fsRead.Read(buffer, 0, buffer.Length);

            //while (byteRead > 0)
            //{
            //    fsWrite.Write(buffer, 0, byteRead);
            //    byteRead = fsRead.Read(buffer, 0, buffer.Length);
            //}


            // 文件夹
            // D:\C#Test\ConsoleApp20260407
            //DirectoryInfo directory = new DirectoryInfo("D:\\C#Test\\ConsoleApp20260407");
            //FileInfo[] info = directory.GetFiles();
            //foreach (FileInfo file in info)
            //{
            //    Console.WriteLine(file.FullName);
            //    Console.WriteLine(file.Length);
            //}

            //DirectoryInfo[] dirs = directory.GetDirectories(); 
            //foreach (var file in dirs)
            //{
            //    Console.WriteLine($"{file.FullName}");
            //}


            Console.WriteLine(GetDirectorysByte("D:\\C#Test\\ConsoleApp20260407"));
            Console.WriteLine("目录下txt文件数量：" + CountTxtFiles("D:\\C#Test\\ConsoleApp20260407"));

            FileInfo? file = GetLargestFile("D:\\C#Test\\ConsoleApp20260407");
            if (file != null)
            {
                Console.WriteLine($"最大文件：{file.FullName}");
                Console.WriteLine($"大小：{file.Length}");
            }
            else
            {
                Console.WriteLine("没有文件");
            }
        }


        static long GetDirectorysByte(string path)
        {
            long total = 0;
            DirectoryInfo directory = new DirectoryInfo(path);

            FileInfo[] info = directory.GetFiles();
            foreach (FileInfo file in info)
            {
                Console.WriteLine(file.FullName);
                total += file.Length;
            }

            DirectoryInfo[] dirs = directory.GetDirectories();
            foreach (DirectoryInfo subDict in dirs)
            {
                total += GetDirectorysByte(subDict.FullName);
            }
            return total;
        }

        static int CountTxtFiles(string path)
        {
            int count = 0;
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] info = directory.GetFiles();
            foreach (FileInfo file in info)
            {
                if (file.Extension.Equals(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            DirectoryInfo[] dirs = directory.GetDirectories();
            foreach (DirectoryInfo subDict in dirs)
            {
                count += CountTxtFiles(subDict.FullName);
            }
            return count;
        }


        static FileInfo? GetLargestFile(string path)
        {
            return null;
        }
    }
}
