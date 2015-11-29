using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Charecter titan1 = new Titan(500, 300, 30, 15,0);
            Charecter titan2 = new Titan(500, 300, 30, 15,0);
            Charecter sisadmin1 = new Sisadmin(250 ,500 ,20, 5,0);
            Charecter sisadmin2 = new Sisadmin(250, 500, 20, 5,0);
            Charecter ninja2 = new Ninja(300,400,100,3,0.1);
            Charecter ninja1 = new Ninja(300,400,100,3,0.1);
            Charecter astronomer1 = new Astronomer(350, 700, 50, 10, 0);
            Charecter astronomer2 = new Astronomer(350, 700, 50, 10, 0);
            Charecter halk1 = new Halk(350, 500, 40, 7, 0);
            Charecter halk2 = new Halk(350, 500, 40, 7, 0);            
            //titan1.Skill1();
            //titan2.Skill1();
            //sisadmin1.Skill1();
            //sisadmin2.Skill1();
            //ninja1.Skill1();
            //ninja2.Skill1();
            //astronomer1.Skill1();
            //astronomer2.Skill1();
            //halk1.Skill1();
            //halk2.Skill1();
            Console.ReadLine();
        }
    }
}
