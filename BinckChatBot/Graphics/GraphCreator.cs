namespace BinckChatBot.Graphics
{
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms.DataVisualization.Charting;
    using System.IO;

    public class GraphCreator
    {
        public static string GetDesktopPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private static Chart CreateDefaultChart(double yLow, double yHigh)
        {
            var chart = new Chart();
            chart.Size = new Size(600, 250);

            var chartArea = new ChartArea();
            chartArea.AxisX.LabelStyle.Format = "dd/MMM";
            chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea.AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chartArea.AxisY.LabelStyle.Font = new Font("Consolas", 8);
            chartArea.AxisY.Interval = 2;

            chartArea.AxisY.Minimum = Math.Round(yLow);
            chartArea.AxisY.Maximum = yHigh;
            chart.ChartAreas.Add(chartArea);

            return chart;
        }

        public static string CreateChartCandleStick(Contracts.INDaily[] quotes, int days)
        {
            var adjustedPeriod = quotes.Take(days).ToArray();

            var yLow = adjustedPeriod.Min(q => q.adj_low);
            if (yLow < 0) yLow = 0;
            var yHigh = adjustedPeriod.Max(q => q.adj_high);

            var chart = CreateDefaultChart(yLow, yHigh);
            var dates = adjustedPeriod.Select(q => q.date).ToArray(); // x

            chart.ChartAreas[0].AxisX.Interval = 1;

            var series = new Series();
            series.Name = "Candles";
            series.ChartType = SeriesChartType.Candlestick;
            series.XValueType = ChartValueType.DateTime;

            series["ShowOpenClose"] = "Both";
            series["PriceUpColor"] = "#8CD600"; // green
            series["PriceDownColor"] = "#ee002b"; // red
            series.Color = Color.FromArgb(104, 104, 104); // "#686868"; // gray
            series["PointWidth"] = "0.3";
            series.BorderWidth = 4;
            series["OpenCloseStyle"] = "Triangle";
            chart.Series.Add(series);

            // bind the datapoints
            for (int i = 0; i < dates.Length; i++)
            {
                chart.Series["Candles"].Points.AddXY(dates[i],
                    adjustedPeriod[i].adj_high,
                    adjustedPeriod[i].adj_low,
                    adjustedPeriod[i].adj_open,
                    adjustedPeriod[i].adj_close);
            }

            // draw!
            chart.Invalidate();

            var path = Path.Combine(GetDesktopPath(), "chartCandle.png");

            // write out a file
            chart.SaveImage(path, ChartImageFormat.Png);

            return path;
        }

        public static string CreateChartClose(Contracts.INDaily[] quotes)
        {
            var yLow = quotes.Min(q => q.adj_low);
            if (yLow < 0) yLow = 0;
            var yHigh = quotes.Max(q => q.adj_high);

            var closeQuoteData = quotes.Select(q => q.adj_close).ToArray();
            var dates = quotes.Select(q => q.date).ToArray();

            var chart = CreateDefaultChart(yLow, yHigh);

            var series = new Series();
            series.Name = "Close";
            series.ChartType = SeriesChartType.FastLine;
            series.XValueType = ChartValueType.DateTime;
            series.BorderWidth = 3;
            chart.Series.Add(series);

            // bind the datapoints
            chart.Series["Close"].Points.DataBindXY(dates, closeQuoteData);

            // draw!
            chart.Invalidate();

            // write out a file
            var path = Path.Combine(GetDesktopPath(), "chartLine.png");

            // write out a file
            chart.SaveImage(path, ChartImageFormat.Png);

            return path;
        }
    }
}
