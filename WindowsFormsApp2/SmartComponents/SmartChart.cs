using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WindowsFormsApp2
{
    class SmartChart : Chart
    {
       
        public ChartData ChartData_Sensor1;
        public ChartData ChartData_Sensor2;
        public ChartData ChartData_Sensor3;
        public ChartData ChartData_Sensor4;
        public ChartData ChartData_Sensor5;
        public ChartData ChartData_Sensor6;

        Series series_1, series_2, series_3, series_4, series_5, series_6;
        Thread ChartSetupThread;        
        MethodInvoker visualSettings;
        MethodInvoker addSeries;      
        public SmartChart()
        {
            return;
            if (DesignMode)
            {
                return;
            }
            ChartData_Sensor1 = new ChartData();
            ChartData_Sensor2 = new ChartData();
            ChartData_Sensor3 = new ChartData();
            ChartData_Sensor4 = new ChartData();
            ChartData_Sensor5 = new ChartData();
            ChartData_Sensor6 = new ChartData();

            ChartSetupThread = new Thread(new ThreadStart(chartSetupThreadMethod));
            ChartSetupThread.SetApartmentState(ApartmentState.MTA);            
            visualSettings = new MethodInvoker(visualSettingsMethod);
            addSeries = new MethodInvoker(addSeriesMethod);
            ChartSetupThread.Start();
            newSeries();
                        
            populateChartMethodInvoker = new MethodInvoker(populateChartMethod);
        }                       

        public void AddChartData(ChartDataPoint Sensor1, ChartDataPoint Sensor2, ChartDataPoint Sensor3, ChartDataPoint Sensor4, ChartDataPoint SensorKanal, ChartDataPoint SensorKos)
        {
            if (Parent == null || !Parent.IsHandleCreated)
            { return; }

            if (Sensor1 != null)
            {
                ChartData_Sensor1.AddChartDataPoint(Sensor1);                
            }
            if (Sensor2 != null)
            {
                ChartData_Sensor2.AddChartDataPoint(Sensor2);                
            }
            if (Sensor3 != null)
            {
                ChartData_Sensor3.AddChartDataPoint(Sensor3);                
            }
            if (Sensor4 != null)
            {
                ChartData_Sensor4.AddChartDataPoint(Sensor4);                
            }
            if (SensorKanal != null)
            {
                ChartData_Sensor5.AddChartDataPoint(SensorKanal);                
            }
            if (SensorKos != null)
            {
                ChartData_Sensor6.AddChartDataPoint(SensorKos);
            }            

            populateChart();
        }

      
        void chartSetupThreadMethod()
        {
            return;
            // wait for form to load
            while (Parent == null || !Parent.IsHandleCreated || !Parent.Visible)
            {
                Thread.Sleep(100);                
            }
            Thread.Sleep(1000);
            // apply settings and populate  
            Parent.Invoke(addSeries);
            Parent.Invoke(visualSettings);            
        }

        int gridInterval = 20;
        void visualSettingsMethod()
        {
            ChartAreas[0].AxisY.MajorGrid.Interval = gridInterval; // set interval for Y axix
            Series[0].IsVisibleInLegend = false; // we need invisible default series to lock the chart proportions
            Series[0].Points.AddXY(DateTime.Now, 20);
            Series[0].Points.AddXY(DateTime.Now, 300);
            Series[0].ChartType = SeriesChartType.Spline;
            Series[0].SetCustomProperty("LineTension", "0.2");
            Series[0].BorderWidth = 0;
            Series[0].XValueType = ChartValueType.Time;
            Series[0].Name = "InvisibleSeries";

            series_1.ChartType = SeriesChartType.Spline;
            series_1.SetCustomProperty("LineTension", "0.2");
            series_1.BorderWidth = 3;
            series_1.XValueType = ChartValueType.Time;
            series_1.Name = "Sensor1";                     

            series_2.ChartType = SeriesChartType.Spline;
            series_2.SetCustomProperty("LineTension", "0.2");
            series_2.BorderWidth = 3;
            series_2.XValueType = ChartValueType.Time;
            series_2.Name = "Sensor2";

            series_3.ChartType = SeriesChartType.Spline;
            series_3.SetCustomProperty("LineTension", "0.2");
            series_3.BorderWidth = 3;
            series_3.XValueType = ChartValueType.Time;
            series_3.Name = "Sensor3";

            series_4.ChartType = SeriesChartType.Spline;
            series_4.SetCustomProperty("LineTension", "0.2");
            series_4.BorderWidth = 3;
            series_4.XValueType = ChartValueType.Time;
            series_4.Name = "Sensor4";

            series_5.ChartType = SeriesChartType.Spline;
            series_5.SetCustomProperty("LineTension", "0.2");
            series_5.BorderWidth = 3;
            series_5.XValueType = ChartValueType.Time;
            series_5.Name = "Kanal";

            series_6.ChartType = SeriesChartType.Spline;
            series_6.SetCustomProperty("LineTension", "0.2");
            series_6.BorderWidth = 3;
            series_6.XValueType = ChartValueType.Time;
            series_6.Name = "Kos";
        }

        MethodInvoker populateChartMethodInvoker;

        void populateChart()
        {
            Parent.Invoke(populateChartMethodInvoker);
        }
        void populateChartMethod()
        {
            if (series_1 == null)
            {
                return;
            }

            ClearAllSeries();

            // data Sensor1
            var buff = ChartData_Sensor1.GetNextChartDatatPoint();

            ChartData_Sensor1.ResetRetrival();
            while (ChartData_Sensor1.HasNext())
            {
                buff = ChartData_Sensor1.GetNextChartDatatPoint();
                series_1.Points.AddXY(buff.Time, buff.Value);
            }

            // data Sensor2
             buff = ChartData_Sensor2.GetNextChartDatatPoint();

            ChartData_Sensor2.ResetRetrival();
            while (ChartData_Sensor2.HasNext())
            {
                buff = ChartData_Sensor2.GetNextChartDatatPoint();
                series_2.Points.AddXY(buff.Time, buff.Value);
            }

            // data Sensor3
             buff = ChartData_Sensor3.GetNextChartDatatPoint();

            ChartData_Sensor3.ResetRetrival();
            while (ChartData_Sensor3.HasNext())
            {
                buff = ChartData_Sensor3.GetNextChartDatatPoint();
                series_3.Points.AddXY(buff.Time, buff.Value);
            }

            // data Sensor4
             buff = ChartData_Sensor4.GetNextChartDatatPoint();

            ChartData_Sensor4.ResetRetrival();
            while (ChartData_Sensor4.HasNext())
            {
                buff = ChartData_Sensor4.GetNextChartDatatPoint();
                series_4.Points.AddXY(buff.Time, buff.Value);
            }

            // data Kanal
             buff = ChartData_Sensor5.GetNextChartDatatPoint();

            ChartData_Sensor5.ResetRetrival();
            while (ChartData_Sensor5.HasNext())
            {
                buff = ChartData_Sensor5.GetNextChartDatatPoint();
                series_5.Points.AddXY(buff.Time, buff.Value);
            }

            // data Kos
             buff = ChartData_Sensor6.GetNextChartDatatPoint();

            ChartData_Sensor6.ResetRetrival();
            while (ChartData_Sensor6.HasNext())
            {
                buff = ChartData_Sensor6.GetNextChartDatatPoint();
                series_6.Points.AddXY(buff.Time, buff.Value);
            }
        }
        
        void newSeries()
        {
            series_1 = new Series();
            series_2 = new Series(); 
            series_3 = new Series(); 
            series_4 = new Series(); 
            series_5 = new Series(); 
            series_6 = new Series(); 
        }                

        void addSeriesMethod()
        {
            Series.Add(series_1);
            Series.Add(series_2);
            Series.Add(series_3);
            Series.Add(series_4);
            Series.Add(series_5);
            Series.Add(series_6);
        }
      
        void ClearAllSeries()
        {
            try
            {
                Series[0].Points.Clear();
                series_1.Points.Clear();
                series_2.Points.Clear();
                series_3.Points.Clear();
                series_4.Points.Clear();
                series_5.Points.Clear();
                series_6.Points.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception("Cant clear Points in chart. " + ex.Message);
            }            
        }        
    }

    class ChartData
    {
        public int MaxEntries { get; private set; } = 0; // 0 means no limit

        List<ChartDataPoint> ChartDataPoints = new List<ChartDataPoint>();

        int currentcdp = 0;

        public ChartData()
        {
            
        }
        public ChartData(int maxEntries)
        {
            MaxEntries = maxEntries;
        }

        public void AddChartDataPoint(ChartDataPoint cdp)
        {
            if (MaxEntries > 0)
            {
                if (ChartDataPoints.Count > MaxEntries)
                {
                    ChartDataPoints.RemoveAt(0);
                }
            }
            
            ChartDataPoints.Add(cdp);
        }

        public ChartDataPoint GetNextChartDatatPoint()
        {
            currentcdp ++;
            return ChartDataPoints[currentcdp-1];
        }

        public bool HasNext()
        {
            if (currentcdp < ChartDataPoints.Count)
            {
               return true;
            }
            return false;
        }

        public void ResetRetrival()
        {
            currentcdp = 0;
        }

    }

    public class ChartDataPoint
    {       
        public DateTime Time { get; private set; }
        public float Value { get; private set; }

        public ChartDataPoint(int value)
        {
            Time = DateTime.Now;
            Value = value;
        }
        public ChartDataPoint(float value)
        {
            Time = DateTime.Now;
            Value = value;
        }
        public ChartDataPoint(DateTime time, float value)
        {
            Time = time;
            Value = value;
        }
    }

    class MyTimer : System.Windows.Forms.Timer
    {

    }
}

