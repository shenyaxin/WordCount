using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace 文档统计
{
    class Program
    {

        /*统计文件行数*/
        public static int Line_number(string File_name)
        {
            int num = 0;//统计行数
            StreamReader ss = new StreamReader(File_name, Encoding.Default);
            while (ss.ReadLine() != null)
            {
                num++;
            }
            ss.Close();
            Console.WriteLine("该文件行数为：" + num);
            return num;//文件行数
        }

        /*1.统计单词总数
         2.输出出现次数最多的10个单词*/
        public static int Word_number(string File_name)
        {
            int num = 0;
            Dictionary<string, int> ss = new Dictionary<string, int>();
            StreamReader reader = new StreamReader(File_name, Encoding.Default);
            String path = null;
            string si = null;
            while ((path = reader.ReadLine()) != null)
            {
                si += (path + "\n");
            }

            string[] words = Regex.Split(si, @"\W+");
            foreach (string word in words)
            {
                if (ss.ContainsKey(word))
                {
                    ss[word]++;
                    num++;
                }
                else
                {
                    ss[word] = 1;
                    num++;
                }
            }
            Console.WriteLine("单词数为：" + num);
            string[] Word1 = new string[num];
            int[] Word1_n = new int[num];
            int i = 0;
            foreach (KeyValuePair<string, int> entry in ss)//统计单词总量
            {


                Word1[i] = entry.Key;
                Word1_n[i] = entry.Value;
                i++;
            }
            for (int j = 0; j < i; j++)//排序
            {
                for (int x = j + 1; x < i; x++)
                {
                    if (Word1_n[j] < Word1_n[x])
                    {
                        int sx = 0;
                        sx = Word1_n[j];
                        Word1_n[j] = Word1_n[x];
                        Word1_n[x] = sx;
                        string se = null;
                        se = Word1[j];
                        Word1[j] = Word1[x];
                        Word1[x] = se;
                    }
                }
            }
            string[] ss1 = new string[10];
            for (int j = 0; j < 10; j++)
            {
                ss1[j] = Word1[j] + ":" + Word1_n[j] ;
               // Console.WriteLine( ss1[j] );
            }
            var queryResults = from n in ss1//字典序排序并输出
                orderby n
                select n;

            foreach (var item in queryResults)
            {
                
                Console.WriteLine(item);
            }
            return num;
        }

        /*统计字符数*/
        public static int Sign_number(string File_name)
        {
            int num = 0;
            string str = File.ReadAllText(File_name);

            num = Regex.Matches(str, @"\d").Count;//统计数字
            num = num + Regex.Matches(str, @"\s").Count;//统计空白字符
            num = num + Regex.Matches(str, @"\w").Count;//统计任何单词字符
            Console.WriteLine("字符数为：" + num);
            return num;
        }

        /*主函数，功能入口*/
        static void Main(string[] args)
        {
            string File_name = args[0];
            Sign_number(File_name);
            Word_number(File_name);
            Line_number(File_name);

            Console.WriteLine("parameter count = {0}", args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
            Console.ReadLine();

        }
    }
}
