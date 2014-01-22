using FreeQuant;
using FreeQuant.Data;
using FreeQuant.FIX;
using FreeQuant.FIXData;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace FreeQuant.Simulation
{
  public class SimulationDataProvider : ISimulationMarketDataProvider, IMarketDataProvider, IProvider
  {
    private const string nWGyg9yZVO = "Simulator(market data)";
    private const string U6ByembQOS = "Simulation data provider";
    private const string wHoyyeM6ef = "http://www.FreeQuant.com";
    private const byte FhJy0jACT6 = (byte) 1;
    private const string clQyPVFekp = "Information";
    private const string JgPyFjZLOy = "Status";
    private Simulator d2YymsvbJ5;
    private bool Gsgyf9JvhJ;
    private ProviderStatus tnvyBO3Dib;
    private IBarFactory arZykcjuVw;
    private Hashtable z1tyr7wr0l;
    private Dictionary<long, int> iSFyRrCNfO;
//    private SortedList<DateTime, sTqplWAhZEpULyK2Wh> Il6yEpdoR8;

    public IBarFactory BarFactory
    {
      get
      {
        return this.arZykcjuVw;
      }
      set
      {
        if (this.arZykcjuVw != null)
        {
          this.arZykcjuVw.NewBar -= new BarEventHandler(this.wGKext6dJq);
          this.arZykcjuVw.NewBarOpen -= new BarEventHandler(this.iC1eQuSAJx);
          this.arZykcjuVw.NewBarSlice -= new BarSliceEventHandler(this.OgUezdlsKf);
        }
        this.arZykcjuVw = value;
        if (this.arZykcjuVw == null)
          return;
        this.arZykcjuVw.NewBar += new BarEventHandler(this.wGKext6dJq);
        this.arZykcjuVw.NewBarOpen += new BarEventHandler(this.iC1eQuSAJx);
        this.arZykcjuVw.NewBarSlice += new BarSliceEventHandler(this.OgUezdlsKf);
      }
    }

    [Browsable(false)]
    public IMarketDataFilter MarketDataFilter { get; set; }

    [Category("Information")]
    public string Name
    {
      get
      {
				return "Name";
      }
    }

    [Category("Information")]
    public string Title
    {
      get
      {
				return "Title";
      }
    }

    [Category("Information")]
    public byte Id
    {
      get
      {
        return 1;
      }
    }

    [Category("Information")]
    public string URL
    {
      get
      {
				return "URL";
      }
    }

    [Category("Status")]
    public bool IsConnected
    {
      get
      {
        return this.Gsgyf9JvhJ;
      }
    }

    [Category("Status")]
    public ProviderStatus Status
    {
      get
      {
        return this.tnvyBO3Dib;
      }
    }

//    [Editor(typeof (sgWeWhHGgY7IAm2Btf), typeof (UITypeEditor))]
    public Simulator Simulator
    {
      get
      {
        return this.d2YymsvbJ5;
      }
    }

    public event MarketDataRequestRejectEventHandler MarketDataRequestReject;

    public event MarketDataEventHandler NewMarketData;

    public event BarEventHandler NewBar;

    public event BarEventHandler NewBarOpen;

    public event BarSliceEventHandler NewBarSlice;

    public event QuoteEventHandler NewQuote;

    public event TradeEventHandler NewTrade;

    public event MarketDepthEventHandler NewMarketDepth;

    public event FundamentalEventHandler NewFundamental;

    public event CorporateActionEventHandler NewCorporateAction;

    public event MarketDataSnapshotEventHandler MarketDataSnapshot;

    public event BarEventHandler NewMarketBar;

    public event EventHandler Connected;

    public event EventHandler Disconnected;

    public event ProviderErrorEventHandler Error;

    public event EventHandler StatusChanged;

   
		public SimulationDataProvider():this("simprovider", 100)
    {
    }

   
		public SimulationDataProvider(string name, int id):base()
    {
      this.d2YymsvbJ5 = new Simulator();
      this.d2YymsvbJ5.Error += new ExceptionEventHandler(this.LAceiZ6F3C);
      this.d2YymsvbJ5.NewObject += new SeriesObjectEventHandler(this.QVVeAUpp2O);
      this.d2YymsvbJ5.LeaveInterval += new IntervalEventHandler(this.Db5eVnQ9kG);
      this.Gsgyf9JvhJ = false;
      this.tnvyBO3Dib = ProviderStatus.Unknown;
      this.BarFactory = (IBarFactory) new BarFactory(false);
      this.z1tyr7wr0l = new Hashtable();
      this.iSFyRrCNfO = new Dictionary<long, int>();
//      this.Il6yEpdoR8 = new SortedList<DateTime, sTqplWAhZEpULyK2Wh>();
      ProviderManager.Add((IProvider) this);
      ProviderManager.MarketDataSimulator = (IMarketDataProvider) this;
    }

   
    public void SendMarketDataRequest(FIXMarketDataRequest request)
    {
      bool flag = (int) request.SubscriptionRequestType == 49;
      for (int i = 0; i < request.NoRelatedSym; ++i)
        this.V6Aetvk5jr(InstrumentManager.Instruments[request.GetRelatedSymGroup(i).Symbol], request.GetRelatedSymGroup(i).GetStringValue(10001), flag);
    }

   
    public void Connect()
    {
      lock (this)
      {
        if (this.Gsgyf9JvhJ)
          return;
        this.HxJehe481y(ProviderStatus.Connecting);
        this.Gsgyf9JvhJ = true;
        this.HxJehe481y(ProviderStatus.Connected);
        this.n6Le9jcnlS();
        this.HxJehe481y(ProviderStatus.LoggingIn);
        this.HxJehe481y(ProviderStatus.LoggedIn);
      }
    }

   
    public void Connect(int timeout)
    {
      this.Connect();
      ProviderManager.WaitConnected((IProvider) this, timeout);
    }

   
    public void Disconnect()
    {
      lock (this)
      {
        if (!this.Gsgyf9JvhJ)
          return;
        this.d2YymsvbJ5.Stop();
        this.Gsgyf9JvhJ = false;
        this.HxJehe481y(ProviderStatus.Disconnected);
        this.cXHepEJgmE();
      }
    }

   
    public void Shutdown()
    {
      this.Disconnect();
    }

   
    public override string ToString()
    {
      return this.Name;
    }

   
    public void AddTrade(Trade trade, Instrument instrument)
    {
//      this.Il6yEpdoR8.Add(trade.DateTime, new sTqplWAhZEpULyK2Wh((IFIXInstrument) instrument, trade));
    }

   
    public void AddQuote(Quote quote, Instrument instrument)
    {
//      this.Il6yEpdoR8.Add(quote.DateTime, new sTqplWAhZEpULyK2Wh((IFIXInstrument) instrument, quote));
    }

   
    private void n6Le9jcnlS()
    {
//      if (this.nX0yZ30caU == null)
//        return;
//      this.nX0yZ30caU((object) this, EventArgs.Empty);
    }

   
    private void cXHepEJgmE()
    {
//      if (this.rYsy8LbfoT == null)
//        return;
//      this.rYsy8LbfoT((object) this, EventArgs.Empty);
    }

   
    private void HxJehe481y([In] ProviderStatus obj0)
    {
      this.tnvyBO3Dib = obj0;
      this.DRxe52yCXc();
    }

   
    private void DRxe52yCXc()
    {
//      if (this.py9yuCA5Te == null)
//        return;
//      this.py9yuCA5Te((object) this, EventArgs.Empty);
    }

   
    private void LAceiZ6F3C([In] ExceptionEventArgs obj0)
    {
//      if (this.vgjyjHHd2O == null)
//        return;
//      this.vgjyjHHd2O(new ProviderErrorEventArgs(new ProviderError(Clock.Now, (IProvider) this, -1, -1, ((object) obj0.Exception).ToString())));
    }

   
    private void QVVeAUpp2O([In] SeriesObjectEventArgs obj0)
    {
//      if (obj0.Object is sTqplWAhZEpULyK2Wh)
//      {
//        sTqplWAhZEpULyK2Wh tqplWahZepUlyK2Wh = obj0.Object as sTqplWAhZEpULyK2Wh;
//        if (tqplWahZepUlyK2Wh.KNNFdwuabW == 0)
//        {
//          // ISSUE: reference to a compiler-generated method
//          this.NijeKZTPBN(tqplWahZepUlyK2Wh.Instrument, tqplWahZepUlyK2Wh.VahFT29LTg());
//        }
//        else
//        {
//          // ISSUE: reference to a compiler-generated method
//          this.RS5eD2QuOd(tqplWahZepUlyK2Wh.Instrument, tqplWahZepUlyK2Wh.YcmFObcjsv());
//        }
//      }
//      else
//      {
//        Instrument instrument = this.z1tyr7wr0l[(object) obj0.Series] as Instrument ?? InstrumentManager.Instruments[obj0.Series.Name.Substring(0, obj0.Series.Name.IndexOf('.'))];
//        IDataObject @object = obj0.Object;
//        if (@object is Bar)
//        {
//          Bar bar = @object as Bar;
//          if (bar.IsComplete)
//          {
//            if (this.MarketDataFilter != null)
//              bar = this.MarketDataFilter.FilterBar(bar, instrument.Symbol);
//            if (bar == null)
//              return;
//            this.k38e3T3by9((IFIXInstrument) instrument, bar);
//            if (bar.BarType != BarType.Time)
//              return;
//            Dictionary<long, int> dictionary;
//            long size;
//            (dictionary = this.iSFyRrCNfO)[size = bar.Size] = dictionary[size] - 1;
//            if (this.iSFyRrCNfO[bar.Size] != 0)
//              return;
//            this.liIenLMabF(bar.Size);
//          }
//          else
//          {
//            if (this.MarketDataFilter != null)
//              bar = this.MarketDataFilter.FilterBarOpen(bar, instrument.Symbol);
//            if (bar == null)
//              return;
//            this.HBde253tvr((IFIXInstrument) instrument, bar);
//            if (bar.BarType != BarType.Time)
//              return;
//            if (!this.iSFyRrCNfO.ContainsKey(bar.Size))
//              this.iSFyRrCNfO[bar.Size] = 0;
//            Dictionary<long, int> dictionary;
//            long size;
//            (dictionary = this.iSFyRrCNfO)[size = bar.Size] = dictionary[size] + 1;
//          }
//        }
//        else if (@object is Trade)
//        {
//          Trade trade = @object as Trade;
//          if (this.MarketDataFilter != null)
//            trade = this.MarketDataFilter.FilterTrade(@object as Trade, instrument.Symbol);
//          if (trade == null)
//            return;
//          this.NijeKZTPBN((IFIXInstrument) instrument, trade);
//        }
//        else if (@object is Quote)
//        {
//          Quote quote = @object as Quote;
//          if (this.MarketDataFilter != null)
//            quote = this.MarketDataFilter.FilterQuote(@object as Quote, instrument.Symbol);
//          if (quote == null)
//            return;
//          this.RS5eD2QuOd((IFIXInstrument) instrument, quote);
//        }
//        else if (@object is MarketDepth)
//          this.HiaeqOcUjh((IFIXInstrument) instrument, @object as MarketDepth);
//        else if (@object is Fundamental)
//        {
//          this.YejeMsdynK((IFIXInstrument) instrument, @object as Fundamental);
//        }
//        else
//        {
//          if (!(@object is CorporateAction))
//            return;
//          this.NQyesH3ccX((IFIXInstrument) instrument, @object as CorporateAction);
//        }
//      }
    }

   
    private void Db5eVnQ9kG([In] IntervalEventArgs obj0)
    {
      this.iSFyRrCNfO.Clear();
    }

   
    private void liIenLMabF([In] long obj0)
    {
//      if (this.xLdyJCfw8a == null)
//        return;
//      this.xLdyJCfw8a((object) this, new BarSliceEventArgs(obj0, (IMarketDataProvider) this));
    }

   
    private void k38e3T3by9([In] IFIXInstrument obj0, [In] Bar obj1)
    {
//      if (this.H91yCHx5ct == null)
//        return;
//      this.H91yCHx5ct((object) this, new BarEventArgs(obj1, obj0, (IMarketDataProvider) this));
    }

   
    private void HBde253tvr([In] IFIXInstrument obj0, [In] Bar obj1)
    {
//      if (this.luIylJLmnN == null)
//        return;
//      this.luIylJLmnN((object) this, new BarEventArgs(obj1, obj0, (IMarketDataProvider) this));
    }

   
    private void NijeKZTPBN([In] IFIXInstrument obj0, [In] Trade obj1)
    {
//      if (this.DQ7yGgKkyX != null)
//        this.DQ7yGgKkyX((object) this, new TradeEventArgs(obj1, obj0, (IMarketDataProvider) this));
      if (this.arZykcjuVw == null)
        return;
      this.arZykcjuVw.OnNewTrade(obj0, obj1);
    }

   
    private void RS5eD2QuOd([In] IFIXInstrument obj0, [In] Quote obj1)
    {
//      if (this.C5cy7WVXIx != null)
//        this.C5cy7WVXIx((object) this, new QuoteEventArgs(obj1, obj0, (IMarketDataProvider) this));
      if (this.arZykcjuVw == null)
        return;
      this.arZykcjuVw.OnNewQuote(obj0, obj1);
    }

   
    private void HiaeqOcUjh([In] IFIXInstrument obj0, [In] MarketDepth obj1)
    {
//      if (this.TF9ya7cnm4 == null)
//        return;
//      this.TF9ya7cnm4((object) this, new MarketDepthEventArgs(obj1, obj0, (IMarketDataProvider) this));
    }

   
    private void YejeMsdynK([In] IFIXInstrument obj0, [In] Fundamental obj1)
    {
//      if (this.jCoyvcREkw == null)
//        return;
//      this.jCoyvcREkw((object) this, new FundamentalEventArgs(obj1, obj0, (IMarketDataProvider) this));
    }

   
    private void NQyesH3ccX([In] IFIXInstrument obj0, [In] CorporateAction obj1)
    {
//      if (this.a7Zy4TJaPL == null)
//        return;
//      this.a7Zy4TJaPL((object) this, new CorporateActionEventArgs(obj1, obj0, (IMarketDataProvider) this));
    }

   
    private void V6Aetvk5jr([In] Instrument obj0, [In] string obj1, [In] bool obj2)
    {
      DataSeriesList dataSeries = obj0.GetDataSeries();
      Regex regex = new Regex(obj1);
      foreach (IDataSeries series in dataSeries)
      {
        if (series.Name.Substring(obj0.Symbol.Length + 1) == obj1)
        {
          if (obj2)
          {
            if (!this.d2YymsvbJ5.InputSeries.Contains(series))
            {
              this.d2YymsvbJ5.InputSeries.Add(series);
              if (!this.z1tyr7wr0l.Contains((object) series))
                this.z1tyr7wr0l.Add((object) series, (object) obj0);
            }
          }
          else
          {
            this.d2YymsvbJ5.InputSeries.Remove(series);
            this.z1tyr7wr0l.Remove((object) series);
          }
        }
      }
    }

   
    private void wGKext6dJq([In] object obj0, [In] BarEventArgs obj1)
    {
//      if (this.H91yCHx5ct == null)
//        return;
//      this.H91yCHx5ct((object) this, new BarEventArgs(obj1.Bar, obj1.Instrument, (IMarketDataProvider) this));
    }

   
    private void iC1eQuSAJx([In] object obj0, [In] BarEventArgs obj1)
    {
//      if (this.luIylJLmnN == null)
//        return;
//      this.luIylJLmnN((object) this, new BarEventArgs(obj1.Bar, obj1.Instrument, (IMarketDataProvider) this));
    }

   
    private void OgUezdlsKf([In] object obj0, [In] BarSliceEventArgs obj1)
    {
//      if (this.xLdyJCfw8a == null)
//        return;
//      this.xLdyJCfw8a((object) this, new BarSliceEventArgs(obj1.BarSize, (IMarketDataProvider) this));
    }

   
    public void EmitTrade(IFIXInstrument instrument, Trade trade)
    {
//      this.d2YymsvbJ5.nNp9oHTwk(new sTqplWAhZEpULyK2Wh(instrument, trade));
    }

   
    public void EmitQuote(IFIXInstrument instrument, Quote quote)
    {
//      this.d2YymsvbJ5.nNp9oHTwk(new sTqplWAhZEpULyK2Wh(instrument, quote));
    }
  }
}
