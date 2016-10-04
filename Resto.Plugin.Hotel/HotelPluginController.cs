using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Resto.BackApi.Core.BackgroundTask;
using Resto.BackApi.Core.BackgroundTask.Extensions;
using Resto.BackApi.Core.RestApi;

namespace Resto.Plugin.Hotel
{
    internal class HotelPluginController
    {
        /// <summary>
        /// Элемент управления плагина.
        /// </summary>
        private readonly HotelMain userControl;

        /// <summary>
        /// Клиент для доступа к серверному REST API.
        /// </summary>
        private readonly RestApiClient restApiClient;

        /// <summary>
        /// Репозиторий для доступа к данным через REST API.
        /// </summary>
        private readonly HotelPluginRepository repository;

        /// <summary>
        /// ModuleId плагина для лицензирования.
        /// В примере использован ModuleId фронта TS.
        /// </summary>
        private const int PluginModuleId = 101; // ModuleId.FrontOfficeTableService

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="userControl">Элемент управления плагина.</param>
        public HotelPluginController(HotelMain userControl)
        {
            this.userControl = userControl;
            userControl.Controller = this;
            restApiClient = new RestApiClient();
        }

        /// <summary>
        /// Загружает данные для плагина.
        /// </summary>
        public void OnLoadData()
        {
        //    userControl.StartBackgroundTask(context =>
        //        {
        //            context.DisableUiCancellation();

        //            restApiClient.Login();

        //            userControl.Invoke(new MethodInvoker(() => userControl.SetDepartments(repository.GetDepartments())));
        //        });
        }

        /// <summary>
        /// Обновляет данные отчета.
        /// </summary>
        /// <param name="departmentId">Идентификатор подразделения.</param>
        /// <param name="dateFrom">Дата с.</param>
        /// <param name="dateTo">Дата по.</param>
        public void OnRefreshReport(Guid departmentId, DateTime dateFrom, DateTime dateTo)
        {
            //userControl.StartBackgroundTask(context =>
            //    {
            //        context.DisableUiCancellation();

            //        var sales = repository.GetSales(departmentId, dateFrom, dateTo);
            //        userControl.Invoke(new MethodInvoker(() => userControl.ShowData(sales)));
            //    });
        }

        /// <summary>
        /// Обрабатывает закрытие плагина.
        /// </summary>
        public void OnClosed()
        {
            restApiClient.Logout();
        }
    }
}
