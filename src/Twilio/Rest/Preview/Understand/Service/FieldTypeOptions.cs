/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Understand.Service 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchFieldTypeOptions
    /// </summary>
    public class FetchFieldTypeOptions : IOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchFieldTypeOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchFieldTypeOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadFieldTypeOptions
    /// </summary>
    public class ReadFieldTypeOptions : ReadOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadFieldTypeOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        public ReadFieldTypeOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateFieldTypeOptions
    /// </summary>
    public class CreateFieldTypeOptions : IOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new CreateFieldTypeOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="uniqueName"> The unique_name </param>
        public CreateFieldTypeOptions(string pathServiceSid, string uniqueName)
        {
            PathServiceSid = pathServiceSid;
            UniqueName = uniqueName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// UpdateFieldTypeOptions
    /// </summary>
    public class UpdateFieldTypeOptions : IOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }

        /// <summary>
        /// Construct a new UpdateFieldTypeOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        public UpdateFieldTypeOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteFieldTypeOptions
    /// </summary>
    public class DeleteFieldTypeOptions : IOptions<FieldTypeResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteFieldTypeOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteFieldTypeOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}