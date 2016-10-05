using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Resto.BackApi.Core.Departments;
using Resto.BackApi.Core.RestApi; 

namespace Resto.Plugin.Hotel
{
    /// <summary>
    /// Репозиторий демо-плагина, отвечает за поставку данных для отображения.
    /// </summary>
    internal class HotelPluginRepository
    {
        private readonly RestApiClient restApiClient;

        public HotelPluginRepository(RestApiClient restApiClient)
        {
            this.restApiClient = restApiClient;
        }

        /// <summary>
        /// Возвращает подразделения.
        /// </summary>
        public IDictionary<Guid, string> GetDepartments()
        {
            return MultiDepartmentsProvider.Instance
                .GetChainOrRmsDepartments()
                .ToDictionary(dept => dept.Id, dept => dept.Name);
        }

        /// <summary>
        /// Возвращает данные отчета по выручке.
        /// </summary>
        /// <param name="departmentId">Идентификатор подразделения.</param>
        /// <param name="dateFrom">Дата с.</param>
        /// <param name="dateTo">Дата по.</param>
        public IDictionary<DateTime, double> GetSales(Guid departmentId, DateTime dateFrom, DateTime dateTo)
        {
            var webResponse = restApiClient.GetResponse(
                () => restApiClient.PrepareRequest("reports/sales",
                    "department", departmentId.ToString(),
                    "dateFrom", dateFrom.ToString("dd.MM.yyyy"),
                    "dateTo", dateTo.ToString("dd.MM.yyyy")));

            var data = XElement.Load(webResponse.GetResponseStream()).Elements("dayDishValue")
                               .ToDictionary(
                                   dv =>
                                       {
                                           var xelem = dv.Element("date");
                                           Contract.Assert(xelem != null);

                                           return DateTime.ParseExact(xelem.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                                       },
                                   dv =>
                                       {
                                           var xelem = dv.Element("value");
                                           Contract.Assert(xelem != null);

                                           return double.Parse(xelem.Value, NumberStyles.AllowDecimalPoint,
                                                               NumberFormatInfo.InvariantInfo);
                                       });

            return data;
        }

    }
}
