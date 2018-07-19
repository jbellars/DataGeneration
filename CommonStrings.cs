using System;
using System.Text.RegularExpressions;

namespace RandomizedDataGenerator
{
    class CommonStrings
    {
        #region Properties

        public static int VisitDateFirstYearStartMonth = 9;
        public static int VisitDateFirstYearEndMonth = 12;
        public static int VisitDateSecondYearStartMonth = 1;
        public static int VisitDateSecondYearEndMonth = 5;

        public static string TasteOfSALTIDSessionVariableName = "tos";

        public static readonly string IsWebauthSessionVariable = "iswebauth";
        public static readonly string StringTrueValue = "Y";

        public static readonly string gMale = "M";
        public static readonly string gFemale = "F";

        public static readonly string rFather = "Father";
        public static readonly string rMother = "Mother";

        public static readonly string FormNameSessionVariableName = "form";
        public static readonly string FormNameQueryStringVariableName = "form";

        public static readonly string FormManageTOSDates = "dates";
        public static readonly string FormManageTOSDatesURL = "admin/manageformdates.aspx";

        public static readonly string Spring = "Spring";
        public static readonly string Summer = "Summer";
        public static readonly string Fall = "Fall";
        public static readonly string Winter = "Winter";

        public static readonly string StaffProxy = "StaffProxyForms.aspx";

        public static readonly string Student = "Student";
        public static readonly string Other = "Other";
        public static readonly string Yes = "Yes";
        public static readonly string No = "No";
        public static readonly string Y = "Y";
        public static readonly string N = "N";

        public static readonly string StandardPhoneNumberPattern = @"\b([0-9]{3})([0-9]{3})([0-9]{4})\b";
        public static readonly string StandardPhoneNumberReplacement = @"($1) $2-$3";

        public static readonly string DefaultDate = "1/1/1900";

        public static readonly string True = "true";
        public static readonly string False = "false";

        public static readonly string USA = "USA";

        #endregion Properties

        #region Static Methods

        public static Int32 ConvertNullableToInt32OrZero(int? i)
        {
            try
            {
                return Convert.ToInt32(i);
            }
            catch
            {
                return 0;
            }
        }

        public static DateTime ConvertNullableToDateTime(DateTime? dt)
        {
            try
            {
                return Convert.ToDateTime(dt);
            }
            catch
            {
                return new DateTime();
            }
        }

        /// <summary>
        /// Takes a numeric sequence of 10 digits and formats it as a standard (###) ###-#### phone number.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string FormatStandardPhoneNumber(string input)
        {
            Regex rgx = new Regex(StandardPhoneNumberPattern);
            return rgx.Replace(input, StandardPhoneNumberReplacement);
        }

        #endregion Static Methods
    }
}
