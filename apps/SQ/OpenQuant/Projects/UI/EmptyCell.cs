﻿// Type: OpenQuant.Projects.UI.EmptyCell
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

namespace OpenQuant.Projects.UI
{
  internal class EmptyCell : MarketScannerCell
  {
    public override double GetValue()
    {
      return double.NaN;
    }
  }
}