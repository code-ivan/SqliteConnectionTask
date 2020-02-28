using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteCEF
{
    public class CEFFormat
    {
        const string CEF = "CEF:";
        public CEFFormat()
        {

        }
        /// <summary>
        ///an integer that identifies version of the CEF format.Event consumers use this information to determine what the fields represent.Currently only version 0 (zero) is established in the above format.
        /// </summary>
        public string Version;

        /// <summary>
        /// strings that uniquely identify the type of sending device.No two products can use the same device-vendor and device-product pair.Event producers ensure that they assign unique name pairs.
        /// </summary>
        public string Device_Vendor;

        /// <summary>
        /// strings that uniquely identify the type of sending device.No two products can use the same device-vendor and device-product pair.Event producers ensure that they assign unique name pairs.
        /// </summary>
        public string Device_Product;

        /// <summary>
        /// strings that uniquely identify the type of sending device.No two products can use the same device-vendor and device-product pair.Event producers ensure that they assign unique name pairs.
        /// </summary>
        public string Device_Version;

        /// <summary>
        /// unique identifier per event-type (can be a string or an integer).DeviceEventClassId identifies the type of event reported.Each signature or rule that detects certain activity has a unique deviceEventClassId assigned.This is a requirement for other types of devices as well, and helps correlation engines deal with the events.
        /// </summary>
        public string DeviceEventClassId;

        /// <summary>
        ///  string describing the event, such as Port scan
        /// </summary>
        public string Name;

        /// <summary>
        /// integer (between 0-10, where 10 indicates the most important event) that reflects event importance.
        /// </summary>
        public string Severity;

        /// <summary>
        ///  collection of key-value pairs, where the keys are part of a predefined set
        ///  Events can contain any number of key - value pairs in any order, separated by spaces. If a field contains a space, such as a file name, this is okay and can be logged on exactly that manner.For example: fileName = c:\Program Files\ArcSight is a valid token.
        /// </summary>
        public string Extension;

        public string CreateFormat(string host)
        {
            return new StringBuilder()
                .Append(DateTime.Now.ToString("MMM dd HH:mm:ss GMT", new CultureInfo("en-US")))
                .Append(" " + host + " ")
                .Append(CEF)
                .Append(Version).Append("|")
                .Append(Device_Vendor).Append("|")
                .Append(Device_Product).Append("|")
                .Append(Device_Version).Append("|")
                .Append(DeviceEventClassId).Append("|")
                .Append(Name).Append("|")
                .Append(Severity).Append("|")
                .Append(Extension).ToString();
        }
    }
}
