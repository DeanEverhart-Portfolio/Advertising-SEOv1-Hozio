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
    public class contact1
    {
        public int contact1ID { get; set; }

        // __________________________________ contact specific fields ____________________________________

        [Required]
        [Display(Name = "First Name")]
        [DisplayFormat(NullDisplayText = "First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [DisplayFormat(NullDisplayText = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Name")]
        public string fullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public string middleName { get; set; }

        public string aka { get; set; }

        // ____________ phone _____________

        public string phoneAreaCode { get; set; }

        public string phonePrefix { get; set; }

        public string phoneLine { get; set; }

        public string phoneExtension { get; set; }

        public string phoneLabel { get; set; }

        [Display(Name = "Gatekeeper")]
        public string phoneGatekeeper { get; set; }

        [Display(Name = "Note")]
        public string phoneNote { get; set; }

        public int phoneSort { get; set; }

        public string stringPhoneSort { get; set; }

        [Display(Name = "Phone")]
        public string fullPhone
        {
            get
            {
                return phoneLabel + " " + " " + " " + "(" + phoneAreaCode + ")" + " " + phonePrefix + "-" + phoneLine + " " +" " + phoneExtension;
            }
        }

        // ____________ phone2 ________________

        public string phone1AreaCode { get; set; }

        public string phone1Prefix { get; set; }

        public string phone1Line { get; set; }

        public string phone1Extension { get; set; }

        public string phone1Label { get; set; }

        public string phone1Gatekeeper { get; set; }

        [Display(Name = "Note")]
        [DisplayFormat(NullDisplayText = "Note")]
        public string phone1Note { get; set; }

        public int phone1Sort { get; set; }

        public string stringPhone1Sort { get; set; }

        public string fullPhone1
        {
            get
            {
                return phone1Label + " " + phone1Prefix + " " + phone1Line + " " + phone1Extension;
            }
        }

        // ____________ phone3 ________________

        public string phone2AreaCode { get; set; }

        public string phone2Prefix { get; set; }

        public string phone2Line { get; set; }

        public string phone2Extension { get; set; }

        public string phone2Label { get; set; }

        public string phone3Gatekeeper { get; set; }

        [Display(Name = "Note")]
        [DisplayFormat(NullDisplayText = "Note")]
        public string phone2Note { get; set; }

        public int phone2Sort { get; set; }

        public string stringPhone2Sort { get; set; }

        public string fullPhone2
        {
            get
            {
                return phone2Label + " " + phone2Prefix + " " + phone2Line + " " + phone2Extension;
            }
        }

        //_________ phone (end) __________

        //__________ email __________

        [Display(Name = "Email")]
        [DisplayFormat(NullDisplayText = "Email")]
        public string email { get; set; }

        public string emailLabel { get; set; }

        public int emailSort { get; set; }

        public string stringEmailSort { get; set; }

        public string email1 { get; set; }

        public string email1Label { get; set; }

        public int email1Sort { get; set; }

        public string stringEmail1Sort { get; set; }

        public string email2 { get; set; }

        public string email2Label { get; set; }

        public int email2Sort { get; set; }

        public string stringEmail2Sort { get; set; }

        //__________ email (end) __________

        // __________ website _____________

        [Display(Name = "Domain")]
        public string domain { get; set; }

        [Display(Name = "DNS")]
        public string domain1 { get; set; }

        // __________ website _____________
        [Display(Name = "Website")]
        [DisplayFormat(NullDisplayText = "Website")]
        public string website { get; set; }

        public string websiteLabel { get; set; }

        public string website1 { get; set; }

        public string website1Label { get; set; }

        public string website2 { get; set; }

        public string website2Label { get; set; }

        // _______ website (end) __________

        // _________ address __________

        public string addressStreetNumber { get; set; }

        public string addressStreetName { get; set; }

        public string addressStreetDesignator { get; set; }

        public string addressStreet2 { get; set; }

        public string addressTownCity { get; set; }

        public string addressState { get; set; }

        public string addressZipCode { get; set; }

        public string addressCounty { get; set; }

        public string addressCountry { get; set; }

        public string addressURL { get; set; }
        
        [Display(Name = "Address")]
        [DisplayFormat(NullDisplayText = "Address")]
        public string fullAddress
        {
            get
            {
                return addressStreetNumber + " " + addressStreetName + " " + addressStreetDesignator + " " + addressStreet2 + ", " + addressTownCity + ", " + addressZipCode;
            }
        }

        // _________ address (end) __________

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime? doh { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Separation Date")]
        public DateTime? dos { get; set; }

        // _______________________________ contact specific fields (end) ________________________________



        // *********************************************************************************************

        // ************************************* relation Fields ***************************************

        // *********************************************************************************************

        // _______________from _______________



        // _______________ to _______________

        public virtual ICollection<contact> contacts { get; set; }

        //___________________________________

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