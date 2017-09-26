using System;
using System.Collections.Generic;
using System.Linq;
using Resto.BackApi.Core;
using Resto.BackApi.Core.Plugin;

namespace Resto.Plugin.Hotel
{
    /// <summary>
    /// Представляет плагин для работы Отеля
    /// </summary>
    public class HotelPlugin : INavBarPlugin
    {
        /// <summary>
        /// Возвращает группу меню.
        /// </summary>
        public MenuGroup MenuGroup
        {
            get {
                return new MenuGroup("Отель", new BaseMenuItem[]
                {
                    
                    new MenuItem(tabPage: new HotelPluginTabPage(), qualifyingId: "HotelPlugin"),
                    new MenuSubGroupLabel("Справочники"),
                    new MenuItem(tabPage: new HotelPluginHousekeepingStatusesTabPage(), qualifyingId: "HotelPluginHousekeepingStatuses"),
                    new MenuItem(tabPage: new HotelPluginAgeGroupsTabPage(), qualifyingId: "HotelPluginAgeGroups"),
                }, "HotelPluginGroup"); }
        }

        /// <summary>
        /// Нужно только для реализации интерфейса <see cref="IPlugin"/>.
        /// </summary>
        public void SetAdapter(IPluginAdapter adapter)
        {
        }
    }
}
