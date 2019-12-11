using System;

namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            string url = Console.ReadLine();

            string protocol;
            string server;
            string resource;

            int q = url.IndexOf("://");
            if (q < 0)
            {
                protocol = "";
            }
            else
            {
                protocol = url.Substring(0, q);
                url = url.Substring(q + 3, url.Length - (q + 3));
            }
            q = url.IndexOf("/");
            if (q < 0)
            {
                server = url;
                resource = "";
            }
            else
            {
                server = url.Substring(0, q);
                resource = url.Substring(q + 1, url.Length - (q + 1));
            }

            Console.WriteLine($"[protocol]=\"{protocol}\"\n" +
                $"[server]=\"{server}\"\n" +
                $"[resource]=\"{resource}\" ");



        }
    }
}
