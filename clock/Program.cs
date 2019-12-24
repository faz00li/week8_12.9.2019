


using System;
using ClockAngleLogic;

namespace InterviewPractice.ClockAngleLogic
{
  public class Program {

    static void Main()
    {
      // //hourhand before minute hand
      // Clock c1 = new Clock(1,10);
      // Clock c2 = new Clock(2, 30);
      // Clock c3 = new Clock(9, 50);
      // Clock c4 = new Clock(9, 30);
      //
      // //hourhand on same as minutehand
      // Clock c5 = new Clock(9,45);
      //
      // //hourhand on 0
      //
      // Clock c6 = new Clock(12,45);
      // Clock c7 = new Clock(0,45);//if hourhand is 0 treat it like 12
      //
      // //minutehand on 0
      // Console.WriteLine("Miute hand on 0");
      // Clock c8 = new Clock(12,0);
      // Clock c9 = new Clock(9,12);//if minutehand is 0 treat it like 12
      //
      //
      // //both on 0
      //
      // c1.diff();
      // c2.diff();
      // c3.diff();
      // c4.diff();
      // Console.WriteLine("hourhand on same as minutehand");
      // c5.diff();
      // Console.WriteLine("hourhand on 0");
      // c6.diff();
      // c7.diff();
      // Console.WriteLine("Miute hand on 0");
      // c8.diff();
      // c9.diff();


      //hourhand before minute hand
      Clock c1 = new Clock(1,55);
      Clock c2 = new Clock(2, 45);
      Clock c3 = new Clock(9, 50);
      Clock c4 = new Clock(9, 30);

      //hourhand on same as minutehand
      Clock c5 = new Clock(9,45);

      //hourhand on 0

      Clock c6 = new Clock(12,45);
      Clock c7 = new Clock(0,45);//if hourhand is 0 treat it like 12

      //minutehand on 0
      Console.WriteLine("Miute hand on 0");
      Clock c8 = new Clock(12,0);
      Clock c9 = new Clock(9,12);//if minutehand is 0 treat it like 12


      //both on 0

      c1.diff();
      c2.diff();
      c3.diff();
      c4.diff();
      Console.WriteLine("hourhand on same as minutehand");
      c5.diff();
      Console.WriteLine("hourhand on 0");
      c6.diff();
      c7.diff();
      Console.WriteLine("Miute hand on 0");
      c8.diff();
      c9.diff();


    }
  }
}
