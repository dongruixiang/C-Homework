using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;




namespace ConsoleApp1
{
	class MyException : ApplicationException
	{
		public MyException(string message) : base(message)
		{

		}
	}
	[Serializable]
	public class OrderService
	{
		public List<Order> list = new List<Order>();
		public List<Order> list1 = new List<Order>();
		OrderDetails orderDetails = new OrderDetails();

		public string friutss, costumer, num, nummm, change;
		public int sum, Amount, x1;

		public OrderService()
		{
			Order order01 = new Order("01", "小张", "香蕉", 60);
			Order order02 = new Order("02", "小王", "苹果", 30);
			list.Add(order01);
			list.Add(order02);
		}


		public Order find()
		{
			Console.WriteLine("请按照提示开始添加订单：");
			Console.Write("输入商品名：");
			friutss = Convert.ToString(Console.ReadLine());
			Console.Write("输入客户名：");
			costumer = Convert.ToString(Console.ReadLine());
			Console.Write("输入数量:");
			Amount = Convert.ToInt32(Console.ReadLine());
			sum = orderDetails.Wholeprize(friutss, Amount);
			Order orderx = new Order("0" + (list.Count + 1), costumer, friutss, sum);
			return orderx;
		}
		//添加订单
		public void InsertOrder(Order orderxx)
		{
			list.Add(orderxx);
			Console.WriteLine("添加成功！");
		}


		//查找订单
		public void FindOrder(int x, string names)
		{

			switch (x)
			{
				case 1:
					foreach (Order s in list)
					{
						if (s.card.Contains(names))
						{
							Console.WriteLine(s.card + " " + s.name + " " + s.series + " " + s.prize);
							list1.Add(s);
						}
					}
					break;
				case 2:
					foreach (Order s in list)
					{
						if (s.name.Contains(names))
						{
							Console.WriteLine(s.card + " " + s.name + " " + s.series + " " + s.prize);
							list1.Add(s);
						}
					}
					break;
				case 3:
					foreach (Order s in list)
					{
						if (s.series.Contains(names))
						{
							Console.WriteLine(s.card + " " + s.name + " " + s.series + " " + s.prize);
							list1.Add(s);
						}
					}
					break;
			}
		}

		//使用LINQ语句实现查询订单
		public void FindOrder1()
		{
			Console.Write("请输入查询方式（按订单号输入1、客户名2、商品名3、按金额4）：");
			int x = 0;
			x = Convert.ToInt32(Console.ReadLine());

			switch (x)
			{
				case 3:
					Console.Write("请输入查询的商品名：");
					string names = Convert.ToString(Console.ReadLine());
					var forder = from n in list
								 where n.series == names
								 select n;
					foreach (Order s in forder)
						Console.WriteLine(s.card + " " + s.name + " " + s.series + " " + s.prize);


					break;
				case 1:
					Console.Write("请输入查询的订单号：");
					string names1 = Convert.ToString(Console.ReadLine());
					var forder1 = from n in list
								  where n.card == names1
								  select n;
					foreach (Order s in forder1)
						Console.WriteLine(s.card + " " + s.name + " " + s.series + " " + s.prize);
					break;

				case 2:
					Console.Write("请输入查询的客户名：");
					string names2 = Convert.ToString(Console.ReadLine());
					var forder2 = from n in list
								  where n.name == names2
								  select n;
					foreach (Order s in forder2)
						Console.WriteLine(s.card + " " + s.name + " " + s.series + " " + s.prize);
					break;
				case 4:
					Console.Write("请输入想要查询的订单金额的最小值：");
					int nn = Convert.ToInt32(Console.ReadLine());
					var forder3 = from n in list
								  where n.prize >= nn
								  select n;
					foreach (Order s in forder3)
						Console.WriteLine(s.card + " " + s.name + " " + s.series + " " + s.prize);

					break;
			}
		}

		public string write()
		{
			Console.Write("请输入订单号：");
			num = Convert.ToString(Console.ReadLine());
			return num;
		}
		//删除订单
		public void DelOrder(string numm)
		{

			bool num1 = false;
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].card == numm)
					num1 = true;
			}

			if (num1 == false)
				throw new MyException("订单号不存在或者输入内容有误，请重新输入：");


			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].card.Contains(numm))
				{
					Console.WriteLine("删除的订单是：" + list[i].card + " " + list[i].name + " " +
						list[i].series + " " + list[i].prize);
					list.Remove(list[i]);

					Console.WriteLine("删除成功！！");


				}
			}

		}

		public string write1()
		{
			Console.Write("请输入订单号：");
			nummm = Convert.ToString(Console.ReadLine());
			return nummm;
		}
		public int write2()
		{
			Console.Write("请输入要修改的地方（修改订单号输入1、客户名2、商品名3）：");
			x1 = Convert.ToInt32(Console.ReadLine());
			return x1;
		}
		public string write3()
		{
			Console.Write("请输入更改后的值：");
			change = Convert.ToString(Console.ReadLine());
			return change;
		}
		//修改订单
		public void ChangeOrder(string nummm, int x1, string change1)
		{
			if (x1 > 3 || x1 < 1)
			{
				throw new MyException("输入不合理！输入的值必须是1、2、3，需要重新输入：");
			}


			switch (x1)
			{
				case 1:
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].card.Contains(nummm))
						{
							list1.Add(list[i]);
							list[i].card = change1;
							Console.WriteLine("修改成功！");
						}
					}
					break;
				case 2:
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].card.Contains(nummm))
						{
							list1.Add(list[i]);
							list[i].name = change1;
							Console.WriteLine("修改成功！");
						}
					}
					break;
				case 3:
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].card.Contains(nummm))
						{
							list1.Add(list[i]);
							list[i].series = change1;
							Console.WriteLine("修改成功！");
							//Console.WriteLine(list[i].card + " " + list[i].name + " " + list[i].series);
						}
					}
					break;

				default:
					Console.WriteLine("修改失败！");
					break;
			}


		}


	}


	public class OrderDetails
	{
		public int pgprize = 10;//苹果价格
		public int xjprize = 15;//香蕉价格

		//总价
		public int Wholeprize(string species, int n)
		{
			if (species == "苹果")
			{
				return (pgprize * n);
			}
			else if (species == "香蕉")
			{
				return (xjprize * n);
			}
			else
			{
				return 0;
			}
		}
	}


	public class Order
	{
		public string card;
		public string name;
		public string series;
		public int prize;
		public Order() { }
		public Order(string c, string n, string s, int sum)
		{
			this.card = c;
			this.name = n;
			this.series = s;
			this.prize = sum;
		}
		//序列化
		public static void XmlSerialize(XmlSerializer ser, object obj)
		{
			FileStream fs = new FileStream("Order.xml", FileMode.Create);
			ser.Serialize(fs, obj);
			fs.Close();
		}
		//反序列化
		public static object XmlDeserialize(XmlSerializer ser)
		{
			FileStream fs = new FileStream("Order.xml", FileMode.Open);
			object obj = ser.Deserialize(fs);
			fs.Close();
			return obj;
		}
		static void Main(string[] args)
		{

			OrderService orderService = new OrderService();
			OrderDetails orderDetails = new OrderDetails();

			//序列化为xml操作
			XmlSerializer xmlSer = new XmlSerializer(typeof(List<Order>));
			XmlSerialize(xmlSer, orderService.list);
			string xml = File.ReadAllText("Order.xml");
			Console.WriteLine(xml);

			//反序列化
			List<Order> order = XmlDeserialize(xmlSer) as List<Order>;
			foreach (Order m in order)
				Console.WriteLine(m.card + " " + m.name + " " + m.series + " " + m.prize);



			//添加订单
			orderService.InsertOrder(orderService.find());

			//查找订单
			Console.Write("请输入查询方式（按订单号输入1、客户名2、商品名3）：");
			int x = 0;
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("请输入查询关键字：");
			string names = Convert.ToString(Console.ReadLine());
			orderService.FindOrder(x, names);

			//linq查找
			//orderService.FindOrder1();

			//移除订单
			try
			{
				orderService.DelOrder(orderService.write());
			}
			catch (MyException e)
			{
				Console.WriteLine("MyException:{0}", e.Message);
				orderService.DelOrder(orderService.write());
			}

			//修改订单
			try
			{
				orderService.ChangeOrder(orderService.write1(), orderService.write2(), orderService.write3());
			}
			catch (MyException e)
			{
				Console.WriteLine("MyException:{0}", e.Message);
				orderService.ChangeOrder(orderService.write1(), orderService.write2(), orderService.write3());
			}

			//遍历订单
			Console.WriteLine("订单号 客户 品类 总价" + "\n");
			foreach (Order xx in orderService.list)
			{
				Console.WriteLine(xx.card + " " + xx.name + " " + xx.series + " " + xx.prize);
			}

		}
	}

}


