﻿using System;

namespace OpenQuant.API
{
  internal class OrderBookEntry
  {
    private FreeQuant.Data.OrderBookEntry entry;

    public DateTime DateTime
    {
      get
      {
        return this.entry.DateTime;
      }
    }

    public double Price
    {
      get
      {
        return this.entry.Price;
      }
    }

    public int Size
    {
      get
      {
        return this.entry.Size;
      }
    }

    internal OrderBookEntry(FreeQuant.Data.OrderBookEntry entry)
    {
      this.entry = entry;
    }

    public override string ToString()
    {
      return this.entry.ToString();
    }
  }
}
