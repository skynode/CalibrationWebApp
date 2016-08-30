using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CalibrationWebApp.Models.ViewModel
{
    public class InventoryManagerView
    {
        [Key]
        public int SYSUserID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Plant No.")]
        public string PlantID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Tool Part No.")]
        public string InstrumentID { get; set; }        

        [Required(ErrorMessage = "*")]
        [Display(Name = "Tool brand")]
        public string ToolBrand { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Tool Description")]
        public string ToolDescription { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Calibration Due Date")]
        public DateTime CalibrationDueDate { get; set; }

        public string Comments { get; set; }

    }
}