﻿// Type: SmartQuant.FinChart.Ranko
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using SmartQuant.Data;
using SmartQuant.Series;
using System;
using System.Runtime.CompilerServices;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class Ranko : BarSeries
  {
    private double xEpya2iCkD;
    private BarSeries M0IypMtV6M;

    public double BoxSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.xEpya2iCkD;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Ranko(BarSeries BarSeries)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.M0IypMtV6M = BarSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Ranko(BarSeries BarSeries, double BoxSize)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.M0IypMtV6M = BarSeries;
      this.xEpya2iCkD = BoxSize;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Calculate()
    {
      double num1 = 0.0;
      int index1 = 1;
      while (Math.Abs(this.M0IypMtV6M[index1].Close - this.M0IypMtV6M[0].Close) <= this.xEpya2iCkD)
        ++index1;
      bool flag = this.M0IypMtV6M[index1].Close > this.M0IypMtV6M[0].Close;
      double num2 = !flag ? this.M0IypMtV6M[0].Close - Math.Floor((this.M0IypMtV6M[0].Close - this.M0IypMtV6M[index1].Close) / this.xEpya2iCkD) * this.xEpya2iCkD : this.M0IypMtV6M[0].Close + Math.Floor((this.M0IypMtV6M[index1].Close - this.M0IypMtV6M[0].Close) / this.xEpya2iCkD) * this.xEpya2iCkD;
      this.Add(new Bar(this.M0IypMtV6M.GetDateTime(0), this.M0IypMtV6M[0].Close, num1, this.M0IypMtV6M[0].Close, num1, 1L, 1L));
      for (int index2 = index1 + 1; index2 < this.M0IypMtV6M.Count; ++index2)
      {
        if (flag)
        {
          if (this.M0IypMtV6M[index2].Close >= num2 + this.xEpya2iCkD)
          {
            double num3 = num2 + Math.Floor((this.M0IypMtV6M[index2].Close - num2) / this.xEpya2iCkD) * this.xEpya2iCkD;
            this.Add(new Bar(this.M0IypMtV6M.GetDateTime(index2), num3, num3, num3, num3, 1L, 1L));
            num2 = num3;
          }
          else if (this.M0IypMtV6M[index2].Close <= num2 - 2.0 * this.xEpya2iCkD)
          {
            double num3 = num2 - Math.Floor((num2 - this.M0IypMtV6M[index2].Close) / this.xEpya2iCkD) * this.xEpya2iCkD;
            this.Add(new Bar(this.M0IypMtV6M.GetDateTime(index2), num3 - this.xEpya2iCkD, num3, num3 - this.xEpya2iCkD, num3, 1L, 1L));
            flag = false;
            num2 = num3;
          }
        }
        else if (this.M0IypMtV6M[index2].Close >= num2 + 2.0 * this.xEpya2iCkD)
        {
          double num3 = num2 + Math.Floor((this.M0IypMtV6M[index2].Close - num2) / this.xEpya2iCkD) * this.xEpya2iCkD;
          this.Add(new Bar(this.M0IypMtV6M.GetDateTime(index2), num3 + this.xEpya2iCkD, num3, num3 + this.xEpya2iCkD, num3, 1L, 1L));
          flag = true;
          num2 = num3;
        }
        else if (this.M0IypMtV6M[index2].Close <= num2 - this.xEpya2iCkD)
        {
          double num3 = num2 - Math.Floor((num2 - this.M0IypMtV6M[index2].Close) / this.xEpya2iCkD) * this.xEpya2iCkD;
          this.Add(new Bar(this.M0IypMtV6M.GetDateTime(index2), num3, num3, num3, num3, 1L, 1L));
          num2 = num3;
        }
      }
    }
  }
}