using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            People p = new People();
            TIME t = new TIME();
            t.TimeUp += new TimeUpHandler(p.Getup);
            t.Time();
            Console.ReadLine();
        }
    }

    public delegate void TimeUpHandler(object sender, EventArgs e);
    public class People
    {
        public void Getup(object sender, EventArgs e)
        {
            Console.WriteLine("听到闹铃，马上起床啦。");
        }
    }
    public class TIME
    {
        public event TimeUpHandler TimeUp;
        public void Time()
        {
            int nowtime = DateTime.Now.Hour;
            if (nowtime == 6)
            {
                Console.WriteLine("6点到了,闹钟响起");
                EventArgs e = new EventArgs();
                OnTimeUp(e);
            }

        }
        protected virtual void OnTimeUp(EventArgs e)
        {
            if (TimeUp != null)
            {
                TimeUp(this, e);
            }
        }
    }
}
