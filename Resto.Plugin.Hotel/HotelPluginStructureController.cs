using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Resto.BackApi.Core.BackgroundTask;
using Resto.BackApi.Core.BackgroundTask.Extensions;
using Resto.BackApi.Core.RestApi;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace Resto.Plugin.Hotel
{
    public class HotelPluginStructureController
    {

        /// <summary>
        /// Элемент управления плагина.
        /// </summary>
        private readonly HotelStructureMain userControl;

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
        public HotelPluginStructureController(HotelStructureMain userControl)
        {
            this.userControl = userControl;
            userControl.Controller = this;
            restApiClient = new RestApiClient();
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
