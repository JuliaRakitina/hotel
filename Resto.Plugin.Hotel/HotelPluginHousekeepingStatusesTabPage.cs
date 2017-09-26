using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Resto.BackApi.Core;
using Resto.BackApi.Core.RestApi;

namespace Resto.Plugin.Hotel
{
    class HotelPluginHousekeepingStatusesTabPage : PluginTabPageBase
    {
        /// <summary>
        /// ModuleId плагина для лицензирования.
        /// В примере использован ModuleId фронта TS.
        /// </summary>
        private const int PluginModuleId = 101; // ModuleId.FrontOfficeTableService
        private String currentUser = RestApiClient.CurrentSessionAuthData.Login;


        public HotelPluginHousekeepingStatusesTabPage(): base("Статусы комнат")
        {

        }

        /// <summary>
        /// Создает контрол, отображаемый на вкладке.
        /// </summary>
        /// <returns>Если возвращает <c>null</c>, то вкладка не открывается.</returns>
        public override UserControl CreateControl()
        {
            if (!LicenseServiceAccessor.CheckExistingConnectionOrGetNew(PluginModuleId))
            {
                return null;
            }

            var ctrl = new HotelPluginHousekeepingStatuses();
            return ctrl;
        }


        /// <summary>
        /// Возвращает идентификатор вкладки.
        /// Если мы хотим, чтобы если вкладка плагина уже открыта, при повторном нажатии на пункт меню осуществлялся переход на 
        /// нее же, а не открывалась новая, то идентификатор должен быть постоянным.
        /// В случае если необходимо, чтобы каждый раз открывалась новая вкладка, идентификатор должен быть уникальным.
        /// </summary>
        public override string GetTabPageId()
        {
            return "HotelPluginHousekeepingStatuses";
        }

        /// <summary>
        /// Вызывается при закрытии вкладки, которое происходит, в том числе, и при штатном выходе из приложения.
        /// </summary>
        /// <param name="control">
        /// Отображаемый на вкладке элемент управления.
        /// (это контрол, который был создан в методе <see cref="CreateControl"/>)
        /// </param>
        /// <returns><c>true</c>, если вкладку можно закрывать и <c>false</c> в противном случае.</returns>
        public override bool Closed(UserControl control)
        {
            LicenseServiceAccessor.ReleaseLicenseConnection(PluginModuleId);

            return base.Closed(control);
        }
    }
}
