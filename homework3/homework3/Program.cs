using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework3;


//抽象图表接口：抽象产品类  





namespace homework3
{
    class Program
    {
            
        static void Main(string[] args)
        {
           var tuxing1=   ShapeFactory.Create("长方形");
           tuxing1.PrintShape();
           var tuxing2=  ShapeFactory.Create("正方形");
           tuxing2.PrintShape();
           var tuxing3 = ShapeFactory.Create("圆形");
           tuxing3.PrintShape();
           var tuxing4 = ShapeFactory.Create("三角形");
           tuxing4.PrintShape();
        }
    }
 
    //生产工厂  
    public class ShapeFactory
    {
        public static Shape Create(string type)
        {
            Shape shape = null;
            switch (type)
            {
                case "三角形":
                    shape = new 三角形();
                    break;
                case "长方形":
                    shape = new 长方形();
                    break;
                case "正方形":
                    shape = new 正方形();
                    break;
                case "圆形":
                    shape = new 圆形();
                    break;
            }
            return shape;
        }
    }

    
    public abstract class Shape
    {
        public abstract void PrintShape();
    }

    
    public class 三角形 : Shape
    {

        public override void PrintShape()
        {
            Console.WriteLine("这是一个边长为3，4，5的三角形，面积为6");
        }
    }
 
    public class  长方形: Shape
    {
        public override void PrintShape()
        {
            Console.WriteLine("这是一个长为4，宽为3的长方形，面积为12");
        }
    }
    public class 正方形 : Shape
    {
        public override void PrintShape()
        {
            Console.WriteLine("这是一个边长为4的正方形，面积为16");
        }
    }
    public class 圆形 : Shape
    {
        public override void PrintShape()
        {
            Console.WriteLine("这是一个半径为4的圆形，面积为16pi");
        }
    }

      
    }

