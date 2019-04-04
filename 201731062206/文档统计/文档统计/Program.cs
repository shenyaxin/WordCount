using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace 文档统计
{
    public class Word
    {
        public int Sign_number(string File_name)
        {
            int num = 0;
            string str = File.ReadAllText(File_name);
            num = Regex.Matches(str, @"\d").Count;
            num = num + Regex.Matches(str, @"\s").Count;//统计空白字符
            num = num + Regex.Matches(str, @"\w").Count;//统计任何单词字符
            Console.WriteLine("字符数为：" + num);
            return num;
        }
    }
    public class Shuchu
    {
        /*输出n个单词到文件o*/
        public static int Word_number(string File_name, int numer, string o)
        {
            string o1 = o;
            File.WriteAllText(o, string.Empty);
            int number1 = numer;
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
            for (int j = 0; j < number1; j++)
            {
                ss1[j] = Word1[j] + ":" + Word1_n[j];
                // Console.WriteLine( ss1[j] );
            }
            var queryResults = from n in ss1//字典序排序并输出
                               orderby n
                               select n;

            foreach (var item in queryResults)
            {

                Console.WriteLine(item);
                File.AppendAllText(o, item + "\r\n");
            }
            return num;
        }

    }
    public class Cizu
    {
        /*统计词组*/
        public static int Long_number(string File_name, int m)
        {
            int m1 = m;
            int num = 0;
            int last = 0;
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
            if (num > m1)
            {
                last = num - m1;
                Console.WriteLine("词组个数为：" + last);
            }
            else
            {
                Console.WriteLine("不存在这样的词组");
            }
            return last;
        }

    }


    public class Danci
    {
        /*输出n个单词*/
        public static int Word_number(string File_name, int numer)
        {
            int number1 = numer;
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
            return num;
        }

    }
    class Cipin
    {
        /*输出n个单词*/
        public static int Word_number(string File_name, int numer)
        {
            int number1 = numer;
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
            for (int j = 0; j < number1; j++)
            {
                ss1[j] = Word1[j] + ":" + Word1_n[j];
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

    }

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

        /*统计字符数*/

        /*主函数，功能入口*/
        static void Main(string[] args)
        {
            int m = 0, n = 0;
            string o = null;
            string File_name = null;
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-i")//输入文件名
                {
                    File_name = args[i + 1];
                }
            }//设置文件名

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-m")//输入词组长度
                {
                    m = int.Parse(args[i + 1]);
                }
                else if (args[i] == "-n")//输出n个单词
                {
                    n = int.Parse(args[i + 1]);

                }
                else if (args[i] == "-o")//输出文件
                {
                    o = args[i + 1];
                }
            }//设置m,n,o的值

            if (n != 0 & o != null)
            {
                Shuchu.Word_number(File_name, n, o);
            }
            if (n != 0)
            {
                Danci.Word_number(File_name, n);
            }

            if (m != 0)
            {
                Cizu.Long_number(File_name, m);
            }
            Console.ReadLine();
            Word word = new Word();
            word.Sign_number(File_name);
            Line_number(File_name);

        }

    }
}
