using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Providers;
using FreeQuant.Series;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Instruments
{
  public class DataManager
  {
    public const string SUFFIX_TRADE = "Trade";
    public const string SUFFIX_QUOTE = "Quote";
    public const string SUFFIX_BAR = "Bar";
    public const string SUFFIX_DAILY = "Daily";
    public const string SUFFIX_MARKET_DEPTH = "Depth";
    public const string SUFFIX_FUNDAMENTAL = "Fund";
    public const string SUFFIX_CORPORATE_ACTION = "Corp";
    private const BarType uOyWWQRXV3 = BarType.Time;
    private const long eINWBm8VlL = 60L;
    private const int ORWW6WXlu1 = -1;
    private const int lUUWEJvSqM = -1;
    private const int YPJWs3OegF = -1;
    private const int gfqWdRTr4c = -1;
    private const int QO0WPjKdKF = -1;
    public const char MARKET_DATA_SUBSCRIBE = '1';
    public const char MARKET_DATA_UNSUBSCRIBE = '2';
    public const char SERIES_SEPARATOR = '.';
    private const string Kn4WeKObZc = "DataManager.config.xml";
    private static bool hpDW23fP88;
    private static IDataServer BWRW8rkUGO;
    private static BarType TrxWldYDwK;
    private static long AK2WYmbanY;
    private static BarSeriesList hrOWG3cp4W;
    private static QuoteArrayList LEcWXtrN5d;
    private static TradeArrayList Pq8W4hxx7g;
    private static FundamentalArrayList w09WJiICvf;
    private static CorporateActionArrayList A9YWr91Jlm;
    private static int QboW3t3R6j;
    private static int UhSWNDBsKq;
    private static int du8WObUg6P;
    private static int pMXWKXcgvW;
    private static int V9WW9pFkc0;
    private static Hashtable XySWClVlg5;
    private static int mdJWM0c8IB;

    public static int BarArrayLength
    {
       get
      {
        return DataManager.QboW3t3R6j;
      }
       set
      {
        if (value < -1)
					throw new ArgumentOutOfRangeException("");
        DataManager.QboW3t3R6j = value;
//        DataManager.QalWQDolkg();
      }
    }

    public static int QuoteArrayLength
    {
       get
      {
        return DataManager.UhSWNDBsKq;
      }
       set
      {
//        if (value < -1)
//					throw new ArgumentOutOfRangeException("{0}", value, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(118));
        DataManager.UhSWNDBsKq = value;
//        DataManager.QalWQDolkg();
      }
    }

    public static int TradeArrayLength
    {
       get
      {
        return DataManager.du8WObUg6P;
      }
       set
      {
//        if (value < -1)
//          throw new ArgumentOutOfRangeException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(208), (object) value, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(222));
        DataManager.du8WObUg6P = value;
//        DataManager.QalWQDolkg();
      }
    }

    public static int FundamentalArrayLength
    {
       get
      {
        return DataManager.pMXWKXcgvW;
      }
       set
      {
//        if (value < -1)
//          throw new ArgumentOutOfRangeException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(312), (object) value, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(326));
        DataManager.pMXWKXcgvW = value;
//        DataManager.QalWQDolkg();
      }
    }

    public static int CorporateActionArrayLength
    {
       get
      {
        return DataManager.V9WW9pFkc0;
      }
       set
      {
//        if (value < -1)
//          throw new ArgumentOutOfRangeException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(416), (object) value, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(430));
        DataManager.V9WW9pFkc0 = value;
//        DataManager.QalWQDolkg();
      }
    }

    public static BarType DefaultBarType
    {
       get
      {
        return DataManager.TrxWldYDwK;
      }
       set
      {
        DataManager.TrxWldYDwK = value;
//        DataManager.QalWQDolkg();
      }
    }

    public static long DefaultBarSize
    {
       get
      {
        return DataManager.AK2WYmbanY;
      }
       set
      {
//        if (value <= 0L)
//          throw new ArgumentOutOfRangeException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(520), (object) value, gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(534));
        DataManager.AK2WYmbanY = value;
//        DataManager.QalWQDolkg();
      }
    }

    public static BarSeriesList Bars
    {
       get
      {
        return DataManager.hrOWG3cp4W;
      }
    }

    public static TradeArrayList Trades
    {
       get
      {
        return DataManager.Pq8W4hxx7g;
      }
    }

    public static QuoteArrayList Quotes
    {
       get
      {
        return DataManager.LEcWXtrN5d;
      }
    }

    public static FundamentalArrayList Fundamentals
    {
       get
      {
        return DataManager.w09WJiICvf;
      }
    }

    public static CorporateActionArrayList CorporateActions
    {
       get
      {
        return DataManager.A9YWr91Jlm;
      }
    }

    public static IDataServer Server
    {
       get
      {
        return DataManager.BWRW8rkUGO;
      }
       set
      {
        DataManager.BWRW8rkUGO = value;
      }
    }

    
    static DataManager()
    {
      DataManager.hpDW23fP88 = false;
      DataManager.BWRW8rkUGO = (IDataServer) new FileDataServer();
      DataManager.hrOWG3cp4W = new BarSeriesList();
      DataManager.LEcWXtrN5d = new QuoteArrayList();
      DataManager.Pq8W4hxx7g = new TradeArrayList();
      DataManager.w09WJiICvf = new FundamentalArrayList();
      DataManager.A9YWr91Jlm = new CorporateActionArrayList();
      DataManager.XySWClVlg5 = new Hashtable();
      DataManager.mdJWM0c8IB = 0;
      DataManager.Init();
    }

    
    public static void ClearDataArrays()
    {
      DataManager.hrOWG3cp4W.oohW0girCj();
      DataManager.Pq8W4hxx7g.Clear(true);
      DataManager.LEcWXtrN5d.Clear(true);
      DataManager.w09WJiICvf.Clear(true);
      DataManager.A9YWr91Jlm.Clear(true);
    }

    
    public static void Init()
    {
      if (DataManager.hpDW23fP88)
        return;
//      if (Trace.IsLevelEnabled(TraceLevel.Info))
//        Trace.WriteLine(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(604));
//      ProviderManager.NewQuote += new QuoteEventHandler(DataManager.LVdLQ0af5);
//      ProviderManager.NewTrade += new TradeEventHandler(DataManager.K9mbHqGRl);
//      ProviderManager.NewBar += new BarEventHandler(DataManager.giTRWZgUN);
//      ProviderManager.NewBarOpen += new BarEventHandler(DataManager.QcGaW9SYm);
//      ProviderManager.NewMarketDepth += new MarketDepthEventHandler(DataManager.EhnnldeA1);
//      ProviderManager.NewFundamental += new FundamentalEventHandler(DataManager.V84iPq8QC);
//      ProviderManager.NewCorporateAction += new CorporateActionEventHandler(DataManager.GGJh4dIeb);
//      ProviderManager.MarketDataRequestReject += new MarketDataRequestRejectEventHandler(DataManager.NxfteUqQb);
//      ProviderManager.Connected += new ProviderEventHandler(DataManager.a9pwYGI8t);
      DataManager.QboW3t3R6j = -1;
      DataManager.du8WObUg6P = -1;
      DataManager.UhSWNDBsKq = -1;
      DataManager.pMXWKXcgvW = -1;
      DataManager.V9WW9pFkc0 = -1;
      DataManager.TrxWldYDwK = BarType.Time;
      DataManager.AK2WYmbanY = 60L;
//      DataManager.k5nzK01pU();
      DataManager.hpDW23fP88 = true;
    }

    
    public static void Add(string series, Trade trade)
    {
      DataManager.BWRW8rkUGO.Add(series, (IDataObject) trade);
    }

    
    public static void Add(string series, Quote quote)
    {
      DataManager.BWRW8rkUGO.Add(series, (IDataObject) quote);
    }

    
    public static void Add(string series, Bar bar)
    {
      DataManager.BWRW8rkUGO.Update(series, (IDataObject) bar);
    }

    
    public static void Add(string series, MarketDepth marketDepth)
    {
      DataManager.BWRW8rkUGO.Add(series, (IDataObject) marketDepth);
    }

    
    public static void Add(string series, Fundamental fundamental)
    {
      DataManager.BWRW8rkUGO.Add(series, (IDataObject) fundamental);
    }

    
    public static void Add(string series, CorporateAction corporateAction)
    {
      DataManager.BWRW8rkUGO.Add(series, (IDataObject) corporateAction);
    }

    
    public static void Add(Instrument instrument, string suffix, Trade trade)
    {
      DataManager.Add(instrument.Symbol + (object) '.' + suffix, trade);
    }

    
    public static void Add(Instrument instrument, string suffix, Quote quote)
    {
      DataManager.Add(instrument.Symbol + (object) '.' + suffix, quote);
    }

    
    public static void Add(Instrument instrument, string suffix, Bar bar)
    {
      DataManager.Add(instrument.Symbol + (object) '.' + suffix, bar);
    }

    
    public static void Add(Instrument instrument, string suffix, MarketDepth marketDepth)
    {
      DataManager.Add(instrument.Symbol + (object) '.' + suffix, marketDepth);
    }

    
    public static void Add(Instrument instrument, string suffix, Fundamental fundamental)
    {
      DataManager.Add(instrument.Symbol + (object) '.' + suffix, fundamental);
    }

    
    public static void Add(Instrument instrument, string suffix, CorporateAction corporateAction)
    {
      DataManager.Add(instrument.Symbol + (object) '.' + suffix, corporateAction);
    }

    
    public static void Add(Instrument instrument, Trade trade)
    {
			DataManager.Add(instrument, "", trade);
    }

    
    public static void Add(Instrument instrument, Quote quote)
    {
			DataManager.Add(instrument, "", quote);
    }

    
    public static void Add(Instrument instrument, Bar bar)
    {
			string suffix = "" + (object) '.' + ((object) bar.BarType).ToString() + (string) (object) '.' + bar.Size.ToString();
      DataManager.Add(instrument, suffix, bar);
    }

    
    public static void Add(Instrument instrument, Daily daily)
    {
			DataManager.Add(instrument, "", (Bar) daily);
    }

    
    public static void Add(Instrument instrument, MarketDepth marketDepth)
    {
			DataManager.Add(instrument, "", marketDepth);
    }

    
    public static void Add(Instrument instrument, Fundamental fundamental)
    {
			DataManager.Add(instrument, "", fundamental);
    }

    
    public static void Add(Instrument instrument, CorporateAction corporateAction)
    {
			DataManager.Add(instrument, "", corporateAction);
    }

    
    public static TradeArray GetTradeArray(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.BWRW8rkUGO.GetTradeArray(series, datetime1, datetime2);
    }

    
    public static TradeArray GetTradeArray(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetTradeArray(instrument.Symbol + (object) '.' + suffix, datetime1, datetime2);
    }

    
    public static TradeArray GetTradeArray(Instrument instrument, DateTime datetime1, DateTime datetime2)
    {
			return DataManager.GetTradeArray(instrument, "", datetime1, datetime2);
    }

    
    public static QuoteArray GetQuoteArray(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.BWRW8rkUGO.GetQuoteArray(series, datetime1, datetime2);
    }

    
    public static QuoteArray GetQuoteArray(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetQuoteArray(instrument.Symbol + (object) '.' + suffix, datetime1, datetime2);
    }

    
    public static QuoteArray GetQuoteArray(Instrument instrument, DateTime datetime1, DateTime datetime2)
    {
			return DataManager.GetQuoteArray(instrument, "", datetime1, datetime2);
    }

    
    public static MarketDepthArray GetMarketDepthArray(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.BWRW8rkUGO.GetMarketDepthArray(series, datetime1, datetime2);
    }

    
    public static MarketDepthArray GetMarketDepthArray(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetMarketDepthArray(instrument.Symbol + (object) '.' + suffix, datetime1, datetime2);
    }

    
    public static MarketDepthArray GetMarketDepthArray(Instrument instrument, DateTime datetime1, DateTime datetime2)
    {
			return DataManager.GetMarketDepthArray(instrument, "", datetime1, datetime2);
    }

    
    public static BarSeries GetBarSeries(string series, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.BWRW8rkUGO.GetBarSeries(series, datetime1, datetime2);
    }

    
    public static BarSeries GetBarSeries(Instrument instrument, string suffix, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetBarSeries(instrument.Symbol + (object) '.' + suffix, datetime1, datetime2);
    }

    
    public static BarSeries GetBarSeries(Instrument instrument, DateTime datetime1, DateTime datetime2, BarType barType, long barSize)
    {
			string suffix = string.Format("", "fdfs", '.', barType, '.',  barSize);
      return DataManager.GetBarSeries(instrument, suffix, datetime1, datetime2);
    }

    
    public static BarSeries GetBarSeries(Instrument instrument, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetBarSeries(instrument, datetime1, datetime2, DataManager.TrxWldYDwK, DataManager.AK2WYmbanY);
    }

    
    public static DailySeries GetDailySeries(Instrument instrument, DateTime datetime1, DateTime datetime2)
    {
			string series = instrument.Symbol + (object) '.' + "";
      DailySeries dailySeries = DataManager.BWRW8rkUGO.GetDailySeries(series, datetime1, datetime2);
      dailySeries.Name = instrument.Symbol;
      return dailySeries;
    }

    
    public static DailySeries GetDailySeries(Instrument instrument)
    {
      return DataManager.GetDailySeries(instrument, DateTime.MinValue, DateTime.MaxValue);
    }

    
    public static IDataSeries GetDataSeries(Instrument instrument, string suffix)
    {
      return DataManager.BWRW8rkUGO.GetDataSeries(instrument.Symbol + (object) '.' + suffix);
    }

    
    public static IDataSeries AddDataSeries(Instrument instrument, string suffix)
    {
      return DataManager.BWRW8rkUGO.AddDataSeries(instrument.Symbol + (object) '.' + suffix);
    }

    
    public static void DeleteDataSeries(string series)
    {
      DataManager.BWRW8rkUGO.Delete(series);
    }

    
    public static void ClearDataSeries(string series)
    {
      DataManager.BWRW8rkUGO.Clear(series);
    }

    
    public static IDataSeries GetDataSeries(Instrument instrument, DataManager.EDataSeries series)
    {
      string str;
      switch (series)
      {
        case DataManager.EDataSeries.Daily:
					str = "Daily";
          break;
        case DataManager.EDataSeries.Trade:
					str = "Trade";
          break;
        case DataManager.EDataSeries.Quote:
					str = "Quote";
          break;
        case DataManager.EDataSeries.Bar:
					str = "Bar";
          break;
        case DataManager.EDataSeries.MarketDepth:
					str = "MarketDepth";
          break;
        case DataManager.EDataSeries.Fundamental:
					str = "Fundamental";
          break;
        case DataManager.EDataSeries.CorporateAction:
					str = "CorporateAction";
          break;
        default:
					throw new ArgumentException("erro" + ((object) series).ToString());
      }
      return DataManager.BWRW8rkUGO.GetDataSeries(instrument.Symbol + (object) '.' + str);
    }

    
    public static DataSeriesList GetDataSeries(Instrument instrument)
    {
      DataSeriesList dataSeriesList = new DataSeriesList();
      foreach (IDataSeries series in DataManager.BWRW8rkUGO.GetDataSeries())
      {
        if (series.Name.StartsWith(instrument.Symbol + (object) '.'))
          dataSeriesList.Add(series);
      }
      return dataSeriesList;
    }

    
    public static void Close()
    {
      DataManager.BWRW8rkUGO.Close();
    }

    
    public static void RequestMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string suffix)
    {
//      DataManager.HpD15hKZM(provider, instrument, mdType, '1', suffix);
    }

    
    public static void RequestMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
    {
			DataManager.RequestMarketData(provider, instrument, mdType, '.' + "");
    }

    
    public static void CancelMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType, string suffix)
    {
//      DataManager.HpD15hKZM(provider, instrument, mdType, '2', suffix);
    }

    
    public static void CancelMarketData(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
    {
			DataManager.CancelMarketData(provider, instrument, mdType, '.' + "ddd");
    }

    
    public static bool IsSubscribed(IMarketDataProvider provider, Instrument instrument, MarketDataType mdType)
    {
      lock (DataManager.XySWClVlg5)
      {
        Hashtable local_0 = DataManager.XySWClVlg5[(object) provider] as Hashtable;
        if (local_0 == null)
          return false;
        Hashtable local_1 = local_0[(object) instrument] as Hashtable;
        if (local_1 == null)
          return false;
        else
          return local_1.ContainsKey((object) mdType);
      }
    }

    
    public static MarketDataSubscription[] GetSubscriptions()
    {
      List<MarketDataSubscription> list = new List<MarketDataSubscription>();
      lock (DataManager.XySWClVlg5)
      {
        foreach (DictionaryEntry item_2 in DataManager.XySWClVlg5)
        {
          foreach (DictionaryEntry item_1 in (IDictionary) item_2.Value)
          {
            foreach (DictionaryEntry item_0 in (IDictionary) item_1.Value)
            {
							MarketDataSubscription local_4 = new MarketDataSubscription((IMarketDataProvider) item_2.Key, (Instrument) item_1.Key, (MarketDataType) item_0.Key, (int)item_0.Value);
              list.Add(local_4);
            }
          }
        }
      }
      return list.ToArray();
    }

    
//    private static void HpD15hKZM([In] IMarketDataProvider obj0, [In] Instrument obj1, [In] MarketDataType obj2, [In] char obj3, [In] string obj4)
//    {
//      if ((obj2 & MarketDataType.Trade) == MarketDataType.Trade)
//        DataManager.C0ToJgPp5(obj0, obj1, MarketDataType.Trade, obj3, obj4);
//      if ((obj2 & MarketDataType.Quote) == MarketDataType.Quote)
//        DataManager.C0ToJgPp5(obj0, obj1, MarketDataType.Quote, obj3, obj4);
//      if ((obj2 & MarketDataType.MarketDepth) != MarketDataType.MarketDepth)
//        return;
//      DataManager.C0ToJgPp5(obj0, obj1, MarketDataType.MarketDepth, obj3, obj4);
//    }
//
//    
//    private static void C0ToJgPp5([In] IMarketDataProvider obj0, [In] Instrument obj1, [In] MarketDataType obj2, [In] char obj3, [In] string obj4)
//    {
//      FIXMarketDataRequest request = new FIXMarketDataRequest();
//      request.MDReqID = DataManager.PcrIhiIAi();
//      request.SubscriptionRequestType = obj3;
//      switch (obj2)
//      {
//        case MarketDataType.Trade:
//          request.AddGroup(new FIXMDEntryTypesGroup('2'));
//          break;
//        case MarketDataType.Quote:
//          request.AddGroup(new FIXMDEntryTypesGroup('0'));
//          request.AddGroup(new FIXMDEntryTypesGroup('1'));
//          request.MarketDepth = 1;
//          break;
//        case MarketDataType.MarketDepth:
//          request.AddGroup(new FIXMDEntryTypesGroup('0'));
//          request.AddGroup(new FIXMDEntryTypesGroup('1'));
//          request.MarketDepth = 0;
//          break;
//      }
//      if (!obj1.ContainsField(15))
//        obj1.Currency = Framework.Configuration.DefaultCurrency;
//      FIXRelatedSymGroup group1 = new FIXRelatedSymGroup();
//      request.AddGroup(group1);
//      group1.Symbol = obj1.Symbol;
//      group1.SecurityType = obj1.SecurityType;
//      group1.SecurityExchange = obj1.SecurityExchange;
//      group1.Currency = obj1.Currency;
//      group1.SecurityID = obj1.SecurityID;
//      group1.SecurityIDSource = obj1.SecurityIDSource;
//      group1.MaturityDate = obj1.MaturityDate;
//      group1.MaturityMonthYear = obj1.MaturityMonthYear;
//      group1.StrikePrice = obj1.StrikePrice;
//      group1.PutOrCall = ((FIXInstrument) obj1).PutOrCall;
//      foreach (FIXSecurityAltIDGroup group2 in (FIXGroupList) obj1.SecurityAltIDGroup)
//        group1.AddGroup(group2);
//      group1.SetStringValue(10001, obj4);
//      if (obj0 == ProviderManager.MarketDataSimulator)
//      {
//        obj0.SendMarketDataRequest(request);
//      }
//      else
//      {
//        switch (obj3)
//        {
//          case '1':
//            bool flag1 = false;
//            lock (DataManager.XySWClVlg5)
//            {
//              Hashtable local_4 = DataManager.XySWClVlg5[(object) obj0] as Hashtable;
//              if (local_4 == null)
//              {
//                local_4 = new Hashtable();
//                DataManager.XySWClVlg5.Add((object) obj0, (object) local_4);
//              }
//              Hashtable local_5 = local_4[(object) obj1] as Hashtable;
//              if (local_5 == null)
//              {
//                local_5 = new Hashtable();
//                local_4.Add((object) obj1, (object) local_5);
//              }
//              OIcrhiMIAiAVdQ0af5 local_6 = local_5[(object) obj2] as OIcrhiMIAiAVdQ0af5;
//              if (local_6 == null)
//              {
//                local_6 = new OIcrhiMIAiAVdQ0af5(request);
//                local_5.Add((object) obj2, (object) local_6);
//                flag1 = true;
//              }
//              OIcrhiMIAiAVdQ0af5 temp_91 = local_6;
//              int temp_94 = temp_91.QUGsV9IIAD() + 1;
//              temp_91.qyosFFV7JU(temp_94);
//            }
//            if (!flag1)
//              break;
//            obj0.SendMarketDataRequest(request);
//            break;
//          case '2':
//            bool flag2 = false;
//            string str = (string) null;
//            lock (DataManager.XySWClVlg5)
//            {
//              Hashtable local_10 = DataManager.XySWClVlg5[(object) obj0] as Hashtable;
//              if (local_10 != null)
//              {
//                Hashtable local_11 = local_10[(object) obj1] as Hashtable;
//                if (local_11 != null)
//                {
//                  OIcrhiMIAiAVdQ0af5 local_12 = local_11[(object) obj2] as OIcrhiMIAiAVdQ0af5;
//                  if (local_12 != null)
//                  {
//                    OIcrhiMIAiAVdQ0af5 temp_152 = local_12;
//                    int temp_155 = temp_152.QUGsV9IIAD() - 1;
//                    temp_152.qyosFFV7JU(temp_155);
//                    if (local_12.QUGsV9IIAD() == 0)
//                    {
//                      local_11.Remove((object) obj2);
//                      if (local_11.Count == 0)
//                      {
//                        local_10.Remove((object) obj1);
//                        if (local_10.Count == 0)
//                          DataManager.XySWClVlg5.Remove((object) obj0);
//                      }
//                      flag2 = true;
//                    }
//                  }
//                  else
//                    str = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1012);
//                }
//                else
//                  str = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1062);
//              }
//              else
//                str = gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1148);
//            }
//            if (str != null)
//              DataManager.vp2xg93Co(obj0, obj1, obj2, str);
//            if (!flag2)
//              break;
//            obj0.SendMarketDataRequest(request);
//            break;
//        }
//      }
//    }
//
//    
//    private static void vp2xg93Co([In] IMarketDataProvider obj0, [In] Instrument obj1, [In] MarketDataType obj2, [In] string obj3)
//    {
//      if (!Trace.IsLevelEnabled(TraceLevel.Warning))
//        return;
//      Trace.WriteLine(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1230) + Environment.NewLine + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1310) + obj0.Name + Environment.NewLine + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1334) + obj1.Symbol + Environment.NewLine + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1362) + ((object) obj2).ToString() + Environment.NewLine + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1398) + obj3);
//    }
//
//    
//    private static string PcrIhiIAi()
//    {
//      return string.Format(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1420), (object) Clock.Now, (object) DataManager.mdJWM0c8IB++);
//    }
//
//    
//    private static void LVdLQ0af5([In] object obj0, [In] QuoteEventArgs obj1)
//    {
//      Instrument index = obj1.Instrument as Instrument ?? InstrumentManager.Instruments[obj1.Instrument.Symbol, obj1.Provider.Name];
//      Quote quote = obj1.Quote;
//      if (index == null)
//        return;
//      if (DataManager.UhSWNDBsKq != 0)
//      {
//        QuoteArray quoteArray = DataManager.LEcWXtrN5d[index];
//        quoteArray.Add((IDataObject) quote);
//        if (DataManager.UhSWNDBsKq != -1 && quoteArray.Count > DataManager.UhSWNDBsKq)
//          quoteArray.RemoveAt(0);
//      }
//      index.JLw6D59Mxc(new QuoteEventArgs(quote, (IFIXInstrument) index, obj1.Provider));
//    }
//
//    
//    private static void K9mbHqGRl([In] object obj0, [In] TradeEventArgs obj1)
//    {
//      Instrument index = obj1.Instrument as Instrument ?? InstrumentManager.Instruments[obj1.Instrument.Symbol, obj1.Provider.Name];
//      Trade trade = obj1.Trade;
//      if (index == null)
//        return;
//      if (DataManager.du8WObUg6P != 0)
//      {
//        TradeArray tradeArray = DataManager.Pq8W4hxx7g[index];
//        tradeArray.Add((IDataObject) trade);
//        if (DataManager.du8WObUg6P != -1 && tradeArray.Count > DataManager.du8WObUg6P)
//          tradeArray.RemoveAt(0);
//      }
//      index.akq60u3HYf(new TradeEventArgs(trade, (IFIXInstrument) index, obj1.Provider));
//    }
//
//    
//    private static void giTRWZgUN([In] object obj0, [In] BarEventArgs obj1)
//    {
//      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
//        Trace.WriteLine(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1464) + (object) obj1);
//      Instrument index = obj1.Instrument as Instrument ?? InstrumentManager.Instruments[obj1.Instrument.Symbol, obj1.Provider.Name];
//      if (index == null)
//        return;
//      DataManager.hrOWG3cp4W.J4qWHe7JIm(index, obj1.Bar);
//      BarSeries barSeries = DataManager.hrOWG3cp4W[index, obj1.Bar.BarType, obj1.Bar.Size];
//      if (DataManager.QboW3t3R6j != -1 && barSeries.Count > DataManager.QboW3t3R6j)
//        ((TimeSeries) barSeries).Remove(0);
//      index.trS6Hr1Wkt(obj1);
//    }
//
//    
//    private static void QcGaW9SYm([In] object obj0, [In] BarEventArgs obj1)
//    {
//      if (Trace.IsLevelEnabled(TraceLevel.Verbose))
//        Trace.WriteLine(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1514) + (object) obj1);
//      Instrument instrument = obj1.Instrument as Instrument ?? InstrumentManager.Instruments[obj1.Instrument.Symbol, obj1.Provider.Name];
//      if (instrument == null)
//        return;
//      instrument.ami6cstOZQ(obj1);
//    }
//
//    
//    private static void EhnnldeA1([In] object obj0, [In] MarketDepthEventArgs obj1)
//    {
//      Instrument instrument = obj1.Instrument as Instrument ?? InstrumentManager.Instruments[obj1.Instrument.Symbol, obj1.Provider.Name];
//      if (instrument == null)
//        return;
//      instrument.aSE6VetHfX(obj1);
//    }
//
//    
//    private static void V84iPq8QC([In] object obj0, [In] FundamentalEventArgs obj1)
//    {
//      Instrument index = obj1.Instrument as Instrument ?? InstrumentManager.Instruments[obj1.Instrument.Symbol, obj1.Provider.Name];
//      if (index == null)
//        return;
//      FundamentalArray fundamentalArray = DataManager.w09WJiICvf[index];
//      fundamentalArray.Add((IDataObject) obj1.Fundamental);
//      if (DataManager.pMXWKXcgvW != -1 && fundamentalArray.Count > DataManager.pMXWKXcgvW)
//        fundamentalArray.RemoveAt(0);
//      index.a1w6FaBIwx(obj1);
//    }
//
//    
//    private static void GGJh4dIeb([In] object obj0, [In] CorporateActionEventArgs obj1)
//    {
//      Instrument index = obj1.Instrument as Instrument ?? InstrumentManager.Instruments[obj1.Instrument.Symbol, obj1.Provider.Name];
//      if (index == null)
//        return;
//      CorporateActionArray corporateActionArray = DataManager.A9YWr91Jlm[index];
//      corporateActionArray.Add((IDataObject) obj1.CorporateAction);
//      if (DataManager.V9WW9pFkc0 != -1 && corporateActionArray.Count > DataManager.V9WW9pFkc0)
//        corporateActionArray.RemoveAt(0);
//      index.KPy6yCSTBZ(obj1);
//    }
//
//    
//    private static void NxfteUqQb([In] object obj0, [In] MarketDataRequestRejectEventArgs obj1)
//    {
//    }
//
//    
//    private static void a9pwYGI8t([In] ProviderEventArgs obj0)
//    {
//      IMarketDataProvider marketDataProvider = obj0.Provider as IMarketDataProvider;
//      if (marketDataProvider == null || marketDataProvider == ProviderManager.MarketDataSimulator)
//        return;
//      Hashtable hashtable1 = DataManager.XySWClVlg5[(object) marketDataProvider] as Hashtable;
//      if (hashtable1 == null)
//        return;
//      foreach (Hashtable hashtable2 in (IEnumerable) hashtable1.Values)
//      {
//        foreach (OIcrhiMIAiAVdQ0af5 oicrhiMiAiAvdQ0af5 in (IEnumerable) hashtable2.Values)
//          marketDataProvider.SendMarketDataRequest(oicrhiMiAiAvdQ0af5.CE8sHyu0xW());
//      }
//    }
//
//    
    public static BarSeries GetHistoricalBars(IHistoricalDataProvider provider, Instrument instrument, DateTime datetime1, DateTime datetime2, long barSize)
    {
      ArrayList arrayList = DataManager.r6ZT8iFUv(provider, instrument, DataManager.EDataSeries.Bar, datetime1, datetime2, barSize);
      BarSeries barSeries = new BarSeries();
      foreach (Bar bar in arrayList)
        barSeries.Add(bar);
      return barSeries;
    }

    
    public static BarSeries GetHistoricalBars(string providerName, string symbol, DateTime datetime1, DateTime datetime2, long barSize)
    {
      return DataManager.GetHistoricalBars(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], datetime1, datetime2, barSize);
    }

    
    public static DailySeries GetHistoricalDailies(IHistoricalDataProvider provider, Instrument instrument, DateTime date1, DateTime date2)
    {
      ArrayList arrayList = DataManager.r6ZT8iFUv(provider, instrument, DataManager.EDataSeries.Daily, date1, date2, -1L);
      DailySeries dailySeries = new DailySeries();
      foreach (Daily daily in arrayList)
        dailySeries.Add((Bar) daily);
      return dailySeries;
    }

    
    public static DailySeries GetHistoricalDailies(string providerName, string symbol, DateTime date1, DateTime date2)
    {
      return DataManager.GetHistoricalDailies(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], date1, date2);
    }

    
    public static TradeArray GetHistoricalTrades(IHistoricalDataProvider provider, Instrument instrument, DateTime datetime1, DateTime datetime2)
    {
      ArrayList arrayList = DataManager.r6ZT8iFUv(provider, instrument, DataManager.EDataSeries.Trade, datetime1, datetime2, -1L);
      TradeArray tradeArray = new TradeArray();
      foreach (Trade trade in arrayList)
        tradeArray.Add((IDataObject) trade);
      return tradeArray;
    }

    
    public static TradeArray GetHistoricalTrades(string providerName, string symbol, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetHistoricalTrades(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], datetime1, datetime2);
    }

    
    public static QuoteArray GetHistoricalQuotes(IHistoricalDataProvider provider, Instrument instrument, DateTime datetime1, DateTime datetime2)
    {
      ArrayList arrayList = DataManager.r6ZT8iFUv(provider, instrument, DataManager.EDataSeries.Quote, datetime1, datetime2, -1L);
      QuoteArray quoteArray = new QuoteArray();
      foreach (Quote quote in arrayList)
        quoteArray.Add((IDataObject) quote);
      return quoteArray;
    }

    
    public static QuoteArray GetHistoricalQuotes(string providerName, string symbol, DateTime datetime1, DateTime datetime2)
    {
      return DataManager.GetHistoricalQuotes(ProviderManager.HistoricalDataProviders[providerName], InstrumentManager.Instruments[symbol], datetime1, datetime2);
    }

    
    private static ArrayList r6ZT8iFUv([In] IHistoricalDataProvider obj0, [In] Instrument obj1, [In] DataManager.EDataSeries obj2, [In] DateTime obj3, [In] DateTime obj4, [In] long obj5)
     {
////      if (obj0 == null)
////        throw new ArgumentNullException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1572));
////      if (obj1 == null)
////        throw new ArgumentNullException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1592));
//      if (!obj0.IsConnected)
//      {
//        obj0.Connect(10000);
////        if (!obj0.IsConnected)
////          throw new InvalidOperationException(gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1616));
//      }
//      HistoricalDataRequest historicalDataRequest = new HistoricalDataRequest();
//      historicalDataRequest.Instrument = (IFIXInstrument) obj1;
//      switch (obj2)
//      {
//        case DataManager.EDataSeries.Daily:
//          historicalDataRequest.DataType = HistoricalDataType.Daily;
//          break;
//        case DataManager.EDataSeries.Trade:
//          historicalDataRequest.DataType = HistoricalDataType.Trade;
//          break;
//        case DataManager.EDataSeries.Quote:
//          historicalDataRequest.DataType = HistoricalDataType.Quote;
//          break;
//        case DataManager.EDataSeries.Bar:
//          historicalDataRequest.DataType = HistoricalDataType.Bar;
//          historicalDataRequest.BarSize = obj5;
//          break;
//      }
//      historicalDataRequest.BeginDate = obj3;
//      historicalDataRequest.EndDate = obj4;
//      return new GO3uho8c9KuFsJTfrm(obj0, historicalDataRequest).Jnd6t3ebcp();
		return new ArrayList();
}
//
//    
//    private static void k5nzK01pU()
//    {
//      FileInfo fileInfo = new FileInfo(Framework.Installation.IniDir.FullName + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1674));
//      if (fileInfo.Exists)
//      {
//        try
//        {
//          puiniRe7DJLOfflhEJ puiniRe7DjlOfflhEj = new puiniRe7DJLOfflhEJ();
//          puiniRe7DjlOfflhEj.Load(fileInfo.FullName);
//          DataManager.TrxWldYDwK = puiniRe7DjlOfflhEj.CHCBRumpAl().WdlEXZ7oTe();
//          DataManager.AK2WYmbanY = puiniRe7DjlOfflhEj.CHCBRumpAl().XaSErhLB01();
//          SesaxMXvEcbARH2A9H sesaxMxvEcbArH2A9H = puiniRe7DjlOfflhEj.KtOBnsCKBh();
//          DataManager.QboW3t3R6j = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (BarArray)).l9DETTpFOp();
//          DataManager.du8WObUg6P = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (TradeArray)).l9DETTpFOp();
//          DataManager.UhSWNDBsKq = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (QuoteArray)).l9DETTpFOp();
//          DataManager.pMXWKXcgvW = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (FundamentalArray)).l9DETTpFOp();
//          DataManager.V9WW9pFkc0 = sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (CorporateActionArray)).l9DETTpFOp();
//        }
//        catch (Exception ex)
//        {
//          if (!Trace.IsLevelEnabled(TraceLevel.Error))
//            return;
//          Trace.WriteLine(((object) ex).ToString());
//        }
//      }
//      else
//        DataManager.QalWQDolkg();
//    }
//
//    
//    private static void QalWQDolkg()
//    {
//      puiniRe7DJLOfflhEJ puiniRe7DjlOfflhEj = new puiniRe7DJLOfflhEJ();
//      puiniRe7DjlOfflhEj.CHCBRumpAl().kjcE4tAU2C(DataManager.TrxWldYDwK);
//      puiniRe7DjlOfflhEj.CHCBRumpAl().hcVE3AoTff(DataManager.AK2WYmbanY);
//      SesaxMXvEcbARH2A9H sesaxMxvEcbArH2A9H = puiniRe7DjlOfflhEj.KtOBnsCKBh();
//      sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (BarArray)).rTfEzlwNY7(DataManager.QboW3t3R6j);
//      sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (TradeArray)).rTfEzlwNY7(DataManager.du8WObUg6P);
//      sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (QuoteArray)).rTfEzlwNY7(DataManager.UhSWNDBsKq);
//      sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (FundamentalArray)).rTfEzlwNY7(DataManager.pMXWKXcgvW);
//      sesaxMxvEcbArH2A9H.UGnEMfCmWe(typeof (CorporateActionArray)).rTfEzlwNY7(DataManager.V9WW9pFkc0);
//      puiniRe7DjlOfflhEj.Save(Framework.Installation.IniDir.FullName + gUqQbWj9pYGI8tO6Z8.iW3dklQ6Dr(1724));
//    }

    public enum EDataSeries
    {
      Daily,
      Trade,
      Quote,
      Bar,
      MarketDepth,
      Fundamental,
      CorporateAction,
    }
  }
}
