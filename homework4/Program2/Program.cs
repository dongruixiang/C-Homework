using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{


    class Order//订单类
    {
        public int Onum;
        public string Oname, Client;

    }

    class Ordermanage//订单管理类
    {

        public static List<Order> Orders;
        public static int Count
        {
            get
            {
                return Orders.Count;
            }
        }

        static Ordermanage()
        {
            Orders = new List<Order>();
        }

        public static Order Information()
        {
            Order myOrder = new Order();
            Console.WriteLine("请输入要添加的订单信息：");
            Console.WriteLine("\n请输入订单号：");
            myOrder.Onum = int.Parse(Console.ReadLine());
            Console.WriteLine("\n请输入商品名称：");
            myOrder.Oname = Console.ReadLine();
            Console.WriteLine("\n请输入客户名：");
            myOrder.Client = Console.ReadLine();


            return myOrder;

        }
        public void ShowOrderInfo(Order myOrder)
        {
            if (myOrder == null) return;
            Console.WriteLine("订单的信息是: ");
            Console.Write("订单号:{0}", myOrder.Onum);
            Console.Write("\n商品名: {0}", myOrder.Oname);
            Console.Write("\n客户: {0}", myOrder.Client);

            Console.WriteLine();
        }
        public Order Search(int Onum)
        {

            for (int i = 0; i < Orders.Count; i++)
            {
                if (Orders[i].Onum == Onum)
                {
                    return Orders[i];
                }

            } return null;

        }

        public void ADD(Order myOrder)
        {
            if (myOrder != null)
            {
                Orders.Add(myOrder);
                Console.WriteLine("我们现在有{0}个订单", Orders.Count);
            }
            else
                Console.WriteLine("你所输入的信息有误，请核对后重新输入！");

        }

        public void Delete(int Onum)
        {
            Order ord = Search(Onum);
            if (ord != null)
            {
                Orders.Remove(ord);
                Console.WriteLine("已经删除订单号为{0}的订单", Onum);
                Console.WriteLine("我们现在还有{0}个订单", Orders.Count);
            }
            else
                Console.WriteLine("未找到你要删除的订单，请核对后重新输入！");
        }

        public void Volume()
        {
            Console.WriteLine("查询到学生的总人数为{0}", Orders.Count);
        }

        public static Order[] Search(string Oname)
        {
            List<Order> ordList = new List<Order>();

            for (int i = 0; i < Orders.Count; i++)
            {
                if (Orders[i].Oname == Oname)
                {
                    ordList.Add(Orders[i]);
                }
            }

            return ordList.ToArray();
        }
    }
    class Operate//用户操作类
    {
        public void Check()
        {
            do
            {
                Console.WriteLine
                    ("请选择所要操作的种类：\n1、添加订单信息 \n2、删除订单信息 \n3、查询订单个数 \n4、查询订单信息（按订单号） \n5、查询订单信息（按商品名称）");
                int number = int.Parse(Console.ReadLine());
                if (number > 5 || number < 1)
                    Console.WriteLine("你的输入有误，请核对后重新输入");
                Ordermanage myOrdermanage = new Ordermanage();

                switch (number)
                {

                    case 1:
                        Order ord = Ordermanage.Information();
                        myOrdermanage.ADD(ord);
                        myOrdermanage.ShowOrderInfo(ord);
                        break;
                    case 2:
                        Console.WriteLine("请输入你要删除的订单信息：");
                        Console.WriteLine("请输入订单的订单号：");
                        int Onum = int.Parse(Console.ReadLine());
                        myOrdermanage.Search(Onum);
                        myOrdermanage.Delete(Onum);
                        break;
                    case 3:
                        myOrdermanage.Volume();
                        break;
                    case 4:
                        Console.WriteLine("请输入你要查询的订单信息：");
                        Console.WriteLine("请输入订单的订单号：");
                        Onum = int.Parse(Console.ReadLine());
                        myOrdermanage.Search(Onum);
                        ord = myOrdermanage.Search(Onum);
                        myOrdermanage.ShowOrderInfo(ord);
                        break;
                    case 5:
                        Console.WriteLine("请输入你要查询的订单信息：");
                        Console.WriteLine("请输入订单的商品名：");
                        string Oname = Console.ReadLine();
                        Order[] ordList = Ordermanage.Search(Oname);
                        for (int i = 0; i < ordList.Length; i++)
                        {
                            myOrdermanage.ShowOrderInfo(ordList[i]);
                        }
                        break;
                } Console.Write("Do you want to continue?(y/n)");
                if (Console.ReadLine() != "y")
                    break;

            } while (true);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Operate myOperate = new Operate();
            myOperate.Check();
        }
    }
}
