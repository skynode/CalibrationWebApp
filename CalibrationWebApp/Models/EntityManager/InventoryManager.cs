using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalibrationWebApp.Models.ViewModel;
using CalibrationWebApp.Models.DB;

namespace CalibrationWebApp.Models.EntityManager
{
    public class InventoryManager
    {
        public void AddInventoryItem(InventoryManagerView inventory)
        {
            using(Tools_Registry_Entities dbEntities = new Tools_Registry_Entities())
            {
                InstrumentInventory item = new DB.InstrumentInventory();
                item.SYSUserID = inventory.SYSUserID;
                item.PlantID = inventory.PlantID;
                item.InstrumentID = inventory.InstrumentID;
                item.InstrumentBrand = inventory.ToolBrand;
                item.InstrumentDesc = inventory.ToolDescription;
                item.CalibrationDueDate = inventory.CalibrationDueDate;
                item.Comments = inventory.Comments;

                dbEntities.InstrumentInventories.Add(item);
                dbEntities.SaveChanges();
            }

        }
    }
}