using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Resto.Plugin.Hotel
{
    /// <summary>
    /// UI-контрол демо-плагина.
    /// </summary>
    internal partial class HotelPluginUserControl : UserControl
    {
        public HotelPluginUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Контроллер.
        /// </summary>
        public HotelPluginController Controller { get; set; }

        /// <summary>
        /// Наполняет комбо-бокс списокм подразделений.
        /// </summary>
        /// <param name="departments"></param>
        public void SetDepartments(IDictionary<Guid, string> departments)
        {
            cmbDepartment.DataSource = departments.OrderBy(dept => dept.Value, StringComparer.CurrentCultureIgnoreCase).ToList();
            cmbDepartment.DisplayMember = "Value";
        }

        /// <summary>
        /// Отображает данные отчета.
        /// </summary>
        /// <param name="sales">Данные для отображения.</param>
        public void ShowData(IDictionary<DateTime, double> sales)
        {
            var series = chart.Series.Single();
            series.Points.Clear();

            var title = chart.Titles.Single();
            if (!sales.Any())
            {
                title.Text = "Нет данных для отображения";
                return;
            }
            else
            {
                title.Text = "Отчет по выручке";
            }

            IList<Tuple<DateTime, double>> sourceSales;

            if (radioModeMonths.Checked)
            {
                var groupedSales = sales
                    .OrderBy(s => s.Key)
                    .GroupBy(s => new { s.Key.Year, s.Key.Month });

                sourceSales = new List<Tuple<DateTime, double>>();

                foreach (var g in groupedSales)
                {
                    sourceSales.Add(
                        new Tuple<DateTime, double>(
                            new DateTime(g.Key.Year, g.Key.Month, 1),
                            g.Sum(item => item.Value)));
                }
            }
            else
            {
                sourceSales = sales.OrderBy(s => s.Key)
                    .Select(pair => new Tuple<DateTime, double>(pair.Key, pair.Value))
                    .ToArray();
            }

            for (int i = 0; i < sourceSales.Count; i++)
            {
                var sale = sourceSales[i];
                var point = new DataPoint(series);
                point.SetValueXY(sale.Item1, sale.Item2);

                string labelFormat = radioModeMonths.Checked ? "MM.yyyy" : "dd.MM.yyyy";
                point.AxisLabel = sale.Item1.ToString(labelFormat);

                // первое, последнее значение или локальный максимум/минимум
                if (i == 0 || i == sourceSales.Count - 1 ||
                    sourceSales[i - 1].Item2 < sale.Item2 && sourceSales[i + 1].Item2 < sale.Item2 ||
                    sourceSales[i - 1].Item2 > sale.Item2 && sourceSales[i + 1].Item2 > sale.Item2)
                {
                    point.IsValueShownAsLabel = true;
                }
                series.Points.Add(point);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            var dept = cmbDepartment.SelectedItem as KeyValuePair<Guid, string>?;
            if (dept == null)
            {
                MessageBox.Show("Необходимо выбрать подразделение.");
                return;
            }
            Controller.OnRefreshReport(dept.Value.Key, dtFrom.Value, dtTo.Value);
        }
    }
}
