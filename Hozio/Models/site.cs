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
    public class site
    {
        public int siteID { get; set; }

        // *********************************************************************************************

        // ************************************* relation Fields ***************************************

        // *********************************************************************************************

        // _______________from _______________

        [Display(Name = "Company")]    // pull down menu
        public int client1ID { get; set; }

        public virtual client1 client1s { get; set; }

        //____________________

        [Display(Name = "Domain")]    //site pull down menu  (X) 
        public int ahrefID { get; set; }

        public virtual ahref ahrefs { get; set; }

        // _______________ to _______________


        // ___________________________________


        // *********************************************************************************************

        // *********************************** relation fields (end) ************************************

        // *********************************************************************************************
    }
}