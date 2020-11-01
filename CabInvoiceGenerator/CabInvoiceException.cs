using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException:Exception
    {
        ///<summary>
        ///Enum for exception type
        ///</summary>
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,INVALID_DISTANCE,INVALID_TIME,NULL_RIDES,INVALID_USER_ID
        }
        ExceptionType type;
        ///<summary>
        ///Parameter Constructor for setting Exception type
        ///</summary>
        public CabInvoiceException(ExceptionType type,string message):base(message)
        {
            this.type = type;
        }
    }
}
