


using System;

namespace ClockAngleLogic
{
  public class Clock
  {
    private int _hr;
    private int _min;
    private int _hrDegree;
    private int _minDegree;
    private int _diffDegrees;

    public Clock(int nHr, int nMin )
    {
      if (nHr == 0)
        nHr = 12;
      else if (nMin == 0)
        nMin = 60;
      _hr = nHr;
      _min = nMin;
    }

    public void convertH()
    {
      _hrDegree = _hr * 30;
    }

    public void convertM()
    {
      _minDegree = _min * 6;
    }

    public void inDegrees()
    {
      int angle = Math.Abs(_minDegree - _hrDegree);
      _diffDegrees = findMin(360 - angle, angle);
      //gives angle btw/ minh and hrh -> can have two angles, since cirlce, so return smallest
    }

    public void printClock() {
      Console.WriteLine("Hour hand: " + _hr + " minute hand: " + _min + " hour degrees: " + _hrDegree + " min degrees: " + _minDegree + " degree difference " + _diffDegrees);
    }

    public void printDiffDegrees()
    {
      Console.WriteLine(_diffDegrees);
    }

    public void diff()
    {
      convertH();
      convertM();
      inDegrees();
      printDiffDegrees();
    }

    public int findMin(int angleOne, int angleTwo)
    {
      return (angleOne < angleTwo) ? angleOne : angleTwo;
    }
  }
}
