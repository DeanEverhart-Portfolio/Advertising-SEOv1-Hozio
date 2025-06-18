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
    public class hog2
    {
        public int hog2ID { get; set; }

        // __________________________________ hog2 specific fields ____________________________________

        // _____ run _____

        [Display(Name = "Run")]
        public int run { get; set; } // run

        [Display(Name = "Run")]
        public string stringRun { get; set; } // run

        [Display(Name = "Rerun")]
        public bool rerun { get; set; }

        [Display(Name = "Rerun")]
        public string stringRerun { get; set; }

        [Display(Name = "Run")]
        public string fullRun
        {
            get
            {
                return stringRun + " " + stringRerun;
            }
        }

        // _____ template _____

        [Display(Name = "Template")]
        public int template { get; set; } // template number

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateTemplate")]
        public DateTime? dateTemplate { get; set; }

        // _____ location _____

        [Display(Name = "Location")]
        public string location { get; set; } // template location

        // ___________________

        [Display(Name = "Template / Location")]
        public string fullTemplate
        {
            get
            {
                return template + " " + location;
            }
        }

        // _____ keyword _____

        [Display(Name = "CSV")]
        public bool keyword { get; set; } // CSV & Keyword.com- Make CSV file for import and add town keywords to serpbook for master service

        [Display(Name = "Keyword")]
        public string stringKeyword { get; set; } // master keyword - run relationshp?

        public string stringKeyword1 { get; set; } // master keyword


        // _____ content _____

        [Display(Name = "Sent")]
        public bool content { get; set; } // sent out for content

        [Display(Name = "Received")]
        public bool content1 { get; set; } // received

        [Display(Name = "Checked")]
        public bool content2 { get; set; } // checked


        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Sent")]
        public DateTime? dateContent { get; set; } // sent

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Writer")]
        public DateTime? dateContent1 { get; set; } // writer

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Received")]
        public DateTime? dateContent2 { get; set; } // received

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Checked")]
        public DateTime? dateContent3 { get; set; } // checked

        [Display(Name = "Writer")]
        public string stringContent { get; set; } // writer - content given to

        [Display(Name = "Writer")]
        public string fullWriter
        {
            get
            {
                return stringContent + " " + dateContent1;
            }
        }

        // ___ content (end) _____

        // _____ html _____

        [Display(Name = "Html")]
        public bool html { get; set; } // converted word to html // HTML - converted word to html

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateHtml")]
        public DateTime? dateHtml { get; set; } // converted word to html // HTML - converted word to html

        // _____ meta _____

        [Display(Name = "Meta")]
        public bool meta { get; set; } // Meta Descriptions made - Write it in https://wordcounter.net/ or the metamaker to count characters. Put name of person who wrote it in cell.

        [Display(Name = "Meta")]
        public string stringMeta { get; set; } // Meta Descriptions made - Write it in https://wordcounter.net/ or the metamaker to count characters. Put name of person who wrote it in cell.

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateMeta")]
        public DateTime? dateMeta { get; set; } // Meta Descriptions made - Write it in https://wordcounter.net/ or the metamaker to count characters. Put name of person who wrote it in cell.

        [Display(Name = "Meta")]
        public string fullMeta
        {
            get
            {
                return meta + " " + stringMeta;
            }
        }


        // _____ seo _____

        [Display(Name = "SEO")]
        public bool seo { get; set; } // SEO completed on website

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateSeo")]
        public DateTime? dateSeo { get; set; } // SEO completed on website


        // _____ plugin _____

        [Display(Name = "Plugin")]
        public bool plugin { get; set; } // Plugins - Damian - installed wp all import and seo plugin

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "datePlugin")]
        public DateTime? datePlugin { get; set; } // Plugins - Damian - installed wp all import and seo plugin

        // _____ hero _____

        [Display(Name = "Hero")]
        public bool hero { get; set; } // Hero Slider(s)- make 1 Hero/homepage slider

        [Display(Name = "Hero")]
        public bool hero1 { get; set; } // Review Slider - Make it

        [Display(Name = "Review")]
        public string stringHero { get; set; } // Review Slider - Make it

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateHero")]
        public DateTime? dateHero { get; set; } // Review Slider - Make it

        // _____ backup _____

        [Display(Name = "Backup")]
        public bool backup { get; set; }

        public string stringBackup { get; set; } // Backups - Damian - Site Backup made - 2 of each site

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateBackup")]
        public DateTime? dateBackup { get; set; } // Backups - Damian - Site Backup made - 2 of each site

        // _____ build / export _____

        [Display(Name = "Build")]
        public bool buildExport { get; set; } // Build & Export HOG

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Build")]
        public DateTime? dateBuildExport { get; set; } // Build & Export HOG

        [Display(Name = "Build")]
        public string stringBuildExport { get; set; } // Build & Export HOG

        [Display(Name = "Build / Export")]
        public string fullBuildExport
        {
            get
            {
                return buildExport + " " + dateBuildExport + " " + stringBuildExport;
            }
        }

        // _____ build / export (end) _____


        public bool hog1 { get; set; } // Post-hog - disable comments on ALL pages, sitemap updated, robots checked, submitted to GSC and recrawled/re-indexed.Check Pages - 404's checked and fixed, cache flushed and re-made, at least 1 pages from EACH template is checked

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateHog")]
        public DateTime? dateHog { get; set; } // Post-hog - disable comments on ALL pages, sitemap updated, robots checked, submitted to GSC and recrawled/re-indexed.Check Pages - 404's checked and fixed, cache flushed and re-made, at least 1 pages from EACH template is checked

        public string stringHog { get; set; } // Post-hog - disable comments on ALL pages, sitemap updated, robots checked, submitted to GSC and recrawled/re-indexed.Check Pages - 404's checked and fixed, cache flushed and re-made, at least 1 pages from EACH template is checked

        // _____ post _____

        [Display(Name = "Post")]
        public bool post { get; set; }

        public string stringPost { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "datePost")]
        public DateTime? datePost { get; set; }


        // _____ site _____

        [Display(Name = "Review")]
        public bool site { get; set; } // Review - Was this site reviewed on Friday... Check design of HOG Slider and mobile.Mobile Responsiveness checker and Speed Test

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "dateSite")]
        public DateTime? dateSite { get; set; } // Review - Was this site reviewed on Friday... Check design of HOG Slider and mobile.Mobile Responsiveness checker and Speed Test

        public string stringSite { get; set; } // Review - Was this site reviewed on Friday... Check design of HOG Slider an

        // _____ dev _____

        [Display(Name = "Dev")]
        public bool dev { get; set; } //    dev website (empty)

        public int? hogOld { get; set; }


        // ________________________________ hog specific fields (end) _________________________________




        // *********************************************************************************************

        // ************************************* relation Fields ***************************************

        // *********************************************************************************************

        // _______________from _______________


        // _______________ to ________________

        public virtual ICollection<client> clients { get; set; }

        // ___________________________________

        // *********************************************************************************************

        // *********************************** relation fields (end) ***********************************

        // *********************************************************************************************


        // _____________________________________________________________________________________________

        // ______________________________________ common fields ________________________________________

        // _____________________________________________________________________________________________

        public string designator { get; set; }

        public string type { get; set; }

        public string type1 { get; set; }

        public string category { get; set; }

        public string category1 { get; set; }

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