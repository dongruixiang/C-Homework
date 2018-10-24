using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
	[TestClass()]
	public class OrderServiceTests
	{
		[TestMethod()]
		public void InsertOrderTest()
		{
			OrderService orderService = new OrderService();
			orderService.costumer = "小王";
			orderService.friutss = "苹果";
			orderService.Amount = 30;

			Order norder = new Order("0" + (orderService.list.Count + 1), orderService.costumer,
				orderService.friutss, orderService.sum);
			orderService.InsertOrder(norder);

			Assert.AreEqual(orderService.list[orderService.list.Count - 1], norder);
			Console.WriteLine("添加成功!!!!");
			//Assert.Fail();
			//Assert.Fail();
		}

		[TestMethod()]
		public void FindOrderTest()
		{
			OrderService orderService = new OrderService();
			orderService.FindOrder(1, "01");

			Assert.AreEqual(orderService.list[0], orderService.list1[0]);

			orderService.FindOrder(2, "小王");
			Assert.AreEqual(orderService.list[1], orderService.list1[1]);

			orderService.FindOrder(3, "苹果");
			Assert.AreEqual(orderService.list[1], orderService.list1[2]);
			//通过输出结果检验
			Console.WriteLine("\n");
			foreach (Order oo in orderService.list1)
				Console.WriteLine(oo.card + " " + oo.name + " " + oo.series + " " + oo.prize);

			//Assert.Fail();
		}

		[TestMethod()]
		public void DelOrderTest()
		{
			OrderService orderService = new OrderService();
			orderService.num = "01";
			Order ordera = orderService.list[0];

			orderService.DelOrder(orderService.num);
			//Console.WriteLine(ordera.name);
			//Console.WriteLine(orderService.list[0].name);
			Assert.AreNotEqual(ordera, orderService.list[0]);
			//Assert.Fail();
		}

		[TestMethod()]
		public void ChangeOrderTest()
		{
			OrderService orderService = new OrderService();
			orderService.nummm = "01";
			orderService.x1 = 2;
			orderService.change = "小凯";

			orderService.ChangeOrder(orderService.nummm, orderService.x1, orderService.change);

			Assert.AreEqual(orderService.list[0].name, "小凯");
			//Assert.Fail();
		}
	}
}