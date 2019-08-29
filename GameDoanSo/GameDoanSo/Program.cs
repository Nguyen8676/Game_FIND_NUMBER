using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDoanSo
{
    class Program
    {
        
        static void Play_Game()
        {
            //RANDOM 1 số nào đấy
            int x;
            Random rd = new Random();
            x = rd.Next(1, 501);
            Console.WriteLine("{0}", x);
           
           // Console.ReadLine();


            // So sánh rồi xuất kết quả
            int a;
            int dem=0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập 1 số bất kỳ nào ahihi");
            do
            {
                //Console.WriteLine("nhập 1 số bất kỳ nào ahihi");
                a = int.Parse(Console.ReadLine());
                dem++;
                Console.WriteLine("BẠN ĐÃ ĐOÁN LẦN THỨ {0}",dem);
                if (a < x)
                {
                    Console.WriteLine("bé hơn x nè");
                }
                if(a>x)
                {
                    Console.WriteLine("lớn hơn x nè");
                }
                if (a == x)
                {
                    Console.WriteLine("CHÍNH XÁC");
                    break;
                }
                if(dem==7)
                {
                    Console.WriteLine("LOSER");
                }

            } while (dem < 7);
       
            
        }
        static void Main(string[] args)
        {
            while(true){
                Play_Game();
                Console.WriteLine("chơi nữa ko[Y OR N]");
                string s = Console.ReadLine();
                if (s == "N")
                {
                    Console.WriteLine("BYE");
                    break;
                }
            }
            
            Console.ReadLine();
        }
    }
}
