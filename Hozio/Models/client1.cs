using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// _____ default (end) _____

using System.ComponentModel.DataAnnotations;          // field parameters
using System.ComponentModel.DataAnnotations.Schema;   // [Column(TypeName = "DateTime2")]

// _________________________


namespace Hozio.Models
{
    public class client1
    {
        public int client1ID { get; set; }

        // __________________________________ client specific fields ___________________________________

        [Required]
        [DisplayFormat(NullDisplayText = "Company Name")]
        [Display(Name = "Company")]
        public string name { get; set; }

        [Display(Name = "Domain")]
        public string domain { get; set; }

        [Display(Name = "DNS")]
        public string domain1 { get; set; }
       
        [Display(Name = "CRM (new)")]
        public int? crm { get; set; }  // new - Monday.com

        [Display(Name = "CRM (old)")]
        public int? crm1 { get; set; } // current (old) - Highrise

        [Display(Name = "Category")]
        public string category { get; set; }

        [Display(Name = "Second Category")]
        public string category1 { get; set; }

        // public int? hog [get; set; } // add


        // _______________________________ client specific fields (end) ________________________________


        // *********************************************************************************************

        // ************************************* relation Fields ***************************************

        // *********************************************************************************************

        // _______________from _______________


        // _______________ to _______________

        public virtual ICollection<contact> contacts { get; set; }

        public virtual ICollection<site> sites { get; set; }

        public virtual ICollection<client> clients { get; set; }


        // *********************************************************************************************

        // *********************************** relation fields (end) ************************************

        // *********************************************************************************************


        // _____________________________________________________________________________________________

        // ______________________________________ common fields ________________________________________

        // _____________________________________________________________________________________________

        public string designator { get; set; }

        public string type { get; set; }

        public string type1 { get; set; }

        public int? tier { get; set; }

        public bool? boolTier { get; set; }

        public string stringTier { get; set; }

        public int? rank { get; set; }

        public string stringRank { get; set; }

        public string note { get; set; }

        public string note1 { get; set; }

        public string text { get; set; }

        public string text1 { get; set; }

        public string sort { get; set; }

        public string sort1 { get; set; }

        public string tag { get; set; }

        public string tag1 { get; set; }

        public string label { get; set; }

        public string label1 { get; set; }

        public bool? boolFlag { get; set; }

        public string flag { get; set; }

        public bool? boolFlag1 { get; set; }

        public string flag1 { get; set; }

        public bool? select { get; set; }

        public bool? select1 { get; set; }

        // ______________________________________________ date fields _____________________________________________

        // __________ start / end _____________

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime? start { get; set; }

        public bool? end { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public DateTime? dateEnd { get; set; }

        // ___________ inactive _______________

        [Display(Name = "Inactive")]
        public bool? inactive { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Inactive Date")]
        public DateTime? dateInactive { get; set; }

        // ___________ Hold _______________

        [Display(Name = "Hold")]
        public bool? hold { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hold Date")]
        public DateTime? dateHold { get; set; }

        // _______________ record __________________

        // ___________ recordCreated _______________

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Record Creation Date")]
        public DateTime? recordCreated { get; set; }

        // ___________ recordInactive _______________

        [Display(Name = "Record Inactive")]
        public bool? recordInactive { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Record Inactive Date")]
        public DateTime? dateRecordInactive { get; set; }

        // ______________________________________________ date fields (end) _____________________________________________


        // ______________________________________________________________________________________________________________

        // _____________________________________________ common fields (end)  ___________________________________________

        // ______________________________________________________________________________________________________________
    }
}