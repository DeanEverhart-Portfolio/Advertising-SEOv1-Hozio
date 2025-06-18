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
    public class client
    {
        public int clientID { get; set; }

        // *********************************************************************************************

        // ************************************* relation Fields ***************************************

        // *********************************************************************************************

        // _______________from _______________

        [Display(Name = "Company")]    // client / "Company" pull down menu
        public int client1ID { get; set; }

        public virtual client1 client1s { get; set; }

        //____________________

        [Display(Name = "Domain")]    //site pull down menu (X) 
        public int hog2ID { get; set; }

        public virtual hog2 hog2s { get; set; }

        // _______________ to _______________


        // ___________________________________


        // *********************************************************************************************

        // *********************************** relation fields (end) ************************************

        // *********************************************************************************************

    }
}