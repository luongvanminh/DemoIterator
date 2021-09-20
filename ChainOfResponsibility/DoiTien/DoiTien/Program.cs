using System;

namespace DoiTien
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Khoi lenh nhap so tien N
            //Console.WriteLine("Nhap so tien N:");
            //int N = Convert.ToInt32(Console.ReadLine());

            /*
            // Dinh nghia cac bien la so to tien
            int soto100;
            int soto50;
            int soto20;
            int soto10;
            int soto5;
            int soto2;
            int soto1;

            // 
            soto100 = N / 100;

            Console.WriteLine("So to 100 la: {0}", soto100);

            //
            N = N % 100;

            Console.WriteLine("So tien con lai la: {0}", N);

            //
            soto50 = N / 50;

            Console.WriteLine("So to 50 la: {0}", soto50);

            //
            N = N % 50;

            Console.WriteLine("So tien con lai la: {0}", N);

            //
            soto20 = N / 20;

            Console.WriteLine("So to 20 la: {0}", soto20);

            //
            N = N % 20;

            Console.WriteLine("So tien con lai la: {0}", N);

            //
            soto10 = N / 10;

            Console.WriteLine("So to 10 la: {0}", soto10);

            //
            N = N % 10;

            Console.WriteLine("So tien con lai la: {0}", N);

            //
            soto5 = N / 5;

            Console.WriteLine("So to 5 la: {0}", soto5);

            //
            N = N % 5;

            Console.WriteLine("So tien con lai la: {0}", N);

            //
            soto2 = N / 2;

            Console.WriteLine("So to 2 la: {0}", soto2);

            //
            N = N % 2;

            Console.WriteLine("So tien con lai la: {0}", N);

            //
            soto1 = N / 1;

            Console.WriteLine("So to 1 la: {0}", soto1);
            */

            MoneyReceiver c100 = new Dollar100();
            MoneyReceiver c50 = new Dollar50();
            MoneyReceiver c20 = new Dollar20();
            MoneyReceiver c10 = new Dollar10();
            MoneyReceiver c5 = new Dollar5();
            MoneyReceiver c2 = new Dollar2();
            MoneyReceiver c1 = new Dollar1();

            c100.NextReceiver(c50);
            c50.NextReceiver(c20);
            c20.NextReceiver(c5);
            c5.NextReceiver(c10);
            c10.NextReceiver(c10);
            c2.NextReceiver(c1);

            // Khoi lenh nhap so tien N
            Console.WriteLine("Nhap so tien N:");
            int n = Convert.ToInt32(Console.ReadLine());

            c100.HandleMoney(n);
        }
    }

    abstract public class MoneyReceiver
    {
        protected MoneyReceiver nextReceiveer;

        public void NextReceiver(MoneyReceiver next)
        {
            this.nextReceiveer = next;
        }

        public abstract void HandleMoney(int n);
    }

    public class Dollar100 : MoneyReceiver
    {
        const int max = 3;
        public override void HandleMoney(int n)
        {
            if (n > 100)
            {
                int num = n / 100;
                Console.WriteLine($"So to 100 la: {num}");
                int remain = n % 100;
                if (remain != 0)
                {
                    this.nextReceiveer.HandleMoney(remain);
                }
            } else
            {
                if (nextReceiveer != null) nextReceiveer.HandleMoney(n);
            }
            return;
        }
    }

    public class Dollar50 : MoneyReceiver
    {
        public override void HandleMoney(int n)
        {
            if (n > 50)
            {
                int num = n / 50;
                Console.WriteLine($"So to 50 la: {num}");
                int remain = n % 50;
                if (remain != 0)
                {
                    this.nextReceiveer.HandleMoney(remain);
                }
            }
            else
            {
                if (nextReceiveer != null) nextReceiveer.HandleMoney(n);
            }
            return;
        }
    }

    public class Dollar20 : MoneyReceiver
    {
        public override void HandleMoney(int n)
        {
            if (n > 20)
            {
                int num = n / 20;
                Console.WriteLine($"So to 20 la: {num}");
                int remain = n % 20;
                if (remain != 0)
                {
                    this.nextReceiveer.HandleMoney(remain);
                }
            }
            else
            {
                if (nextReceiveer != null) nextReceiveer.HandleMoney(n);
            }
            return;
        }
    }

    public class Dollar10 : MoneyReceiver
    {
        public override void HandleMoney(int n)
        {
            if (n > 10)
            {
                int num = n / 10;
                Console.WriteLine($"So to 10 la: {num}");
                int remain = n % 10;
                if (remain != 0)
                {
                    this.nextReceiveer.HandleMoney(remain);
                }
            }
            else
            {
                if (nextReceiveer != null) nextReceiveer.HandleMoney(n);
            }
            return;
        }
    }

    public class Dollar5 : MoneyReceiver
    {
        public override void HandleMoney(int n)
        {
            if (n > 5)
            {
                int num = n / 5;
                Console.WriteLine($"So to 5 la: {num}");
                int remain = n % 5;
                if (remain != 0)
                {
                    this.nextReceiveer.HandleMoney(remain);
                }
            }
            else
            {
                if (nextReceiveer != null) nextReceiveer.HandleMoney(n);
            }
            return;
        }
    }

    public class Dollar2 : MoneyReceiver
    {
        public override void HandleMoney(int n)
        {
            if (n > 2)
            {
                int num = n / 2;
                Console.WriteLine($"So to 2 la: {num}");
                int remain = n % 2;
                if (remain != 0)
                {
                    this.nextReceiveer.HandleMoney(remain);
                }
            }
            else
            {
                if (nextReceiveer != null) nextReceiveer.HandleMoney(n);
            }
            return;
        }
    }

    public class Dollar1 : MoneyReceiver
    {
        public override void HandleMoney(int n)
        {
            if (n >= 1)
            {
                int num = n / 1;
                Console.WriteLine($"So to 1 la: {num}");
                int remain = n % 1;
                if (remain != 0)
                {
                    this.nextReceiveer.HandleMoney(remain);
                }
            }
            else
            {
                if (nextReceiveer != null) nextReceiveer.HandleMoney(n);
            }
            return;
        }
    }
}
