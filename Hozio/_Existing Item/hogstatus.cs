//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//// _____ default (end) _____

//using System.ComponentModel.DataAnnotations;          // field parameters
//using System.ComponentModel.DataAnnotations.Schema;   // [Column(TypeName = "DateTime2")]

//// _________________________


//namespace Hozio.Models
//{
//    public class hogStatus
//    {
//        public int hogStatusID { get; set; }

//        public int hog1ID { get; set; }

//        // __________________________________ hog specific fields ____________________________________

//        //[Required]
//        //[DisplayFormat(NullDisplayText = "First Name")]
//        //public string firstName { get; set; }

//        // _____ run _____

//        public int run { get; set; } // run


//        // _____ template _____

//        public int template { get; set; } // template number

//        public DateTime dateTemplate { get; set; }

//        // _____ location _____

//        public string location { get; set; } // template location

//        // _____ keyword _____

//        public bool keyword { get; set; } // CSV & Keyword.com- Make CSV file for import and add town keywords to serpbook for master service

//        public string stringKeyword { get; set; } // master keyword - run relationshp?

//        public string stringKeyword1 { get; set; } // master keyword


//        // _____ content _____

//        public bool content { get; set; } // sent out for content

//        public bool content1 { get; set; } // sent out for content

//        public DateTime dateContent { get; set; } // sent out for content

//        public DateTime dateContent1 { get; set; } // sent out for content

//        public string stringContent { get; set; } // writer - content given to


//        // _____ html _____

//        public bool html { get; set; } // converted word to html // HTML - converted word to html

//        public DateTime dateHtml{ get; set; } // converted word to html // HTML - converted word to html

//        // _____ meta _____

//        public bool meta { get; set; } // Meta Descriptions made - Write it in https://wordcounter.net/ or the metamaker to count characters. Put name of person who wrote it in cell.

//        public string stringMeta { get; set; } // Meta Descriptions made - Write it in https://wordcounter.net/ or the metamaker to count characters. Put name of person who wrote it in cell.

//        public DateTime dateMeta { get; set; } // Meta Descriptions made - Write it in https://wordcounter.net/ or the metamaker to count characters. Put name of person who wrote it in cell.

//        // _____ seo _____

//        public bool seo { get; set; } // SEO completed on website

//        public DateTime dateSeo { get; set; } // SEO completed on website


//        // _____ plugin _____

//        public bool plugin { get; set; } // Plugins - Damian - installed wp all import and seo plugin

//        public DateTime datePlugin { get; set; } // Plugins - Damian - installed wp all import and seo plugin

//        // _____ hero _____

//        public bool hero { get; set; } // Hero Slider(s)- make 1 Hero/homepage slider

//        public bool hero1 { get; set; } // Review Slider - Make it

//        public string stringHero { get; set; } // Review Slider - Make it

//        public DateTime dateHero { get; set; } // Review Slider - Make it

//        // _____ backup _____

//        public bool backup { get; set; }

//        public string stringBackup { get; set; } // Backups - Damian - Site Backup made - 2 of each site

//        public DateTime dateBackup { get; set; } // Backups - Damian - Site Backup made - 2 of each site

//        // _____ build / export _____

//        public bool buildExport { get; set; } // Build & Export HOG

//        public DateTime dateBuildExport { get; set; } // Build & Export HOG

//        public string stringBuildExport { get; set; } // Build & Export HOG

//        // _____ build / export _____

//        public bool hog1 { get; set; } // Post-hog - disable comments on ALL pages, sitemap updated, robots checked, submitted to GSC and recrawled/re-indexed.Check Pages - 404's checked and fixed, cache flushed and re-made, at least 1 pages from EACH template is checked

//        public DateTime dateHog { get; set; } // Post-hog - disable comments on ALL pages, sitemap updated, robots checked, submitted to GSC and recrawled/re-indexed.Check Pages - 404's checked and fixed, cache flushed and re-made, at least 1 pages from EACH template is checked

//        public string stringHog { get; set; } // Post-hog - disable comments on ALL pages, sitemap updated, robots checked, submitted to GSC and recrawled/re-indexed.Check Pages - 404's checked and fixed, cache flushed and re-made, at least 1 pages from EACH template is checked

//        // _____ post _____

//        public bool post { get; set; }

//        public string stringPost { get; set; }

//        public DateTime datePost { get; set; }


//        // _____ site _____

//        public bool site { get; set; } // Review - Was this site reviewed on Friday... Check design of HOG Slider and mobile.Mobile Responsiveness checker and Speed Test

//        public DateTime dateSite { get; set; } // Review - Was this site reviewed on Friday... Check design of HOG Slider and mobile.Mobile Responsiveness checker and Speed Test

//        public string stringSite { get; set; } // Review - Was this site reviewed on Friday... Check design of HOG Slider an

//        // _____ dev _____

//        public bool dev { get; set; } //    dev website (empty)


//        // ________________________________ hog specific fields (end) _________________________________




//        // *********************************************************************************************

//        // ************************************* relation Fields ***************************************

//        // *********************************************************************************************

//        // _______________from _______________

//        public int clientID { get; set; }

//        public virtual client clients { get; set; }

//        // ___________________________________

//        // *********************************************************************************************

//        // *********************************** relation fields (end) ***********************************

//        // *********************************************************************************************

//    }
//}