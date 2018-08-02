﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SaintSenderNew
{
    class LoginException : Exception
    {
        public LoginException() 
          : base()
        {
        }
        
        public LoginException(String message) 
          : base(message)
        {
        }
        
        public LoginException(String message, Exception innerException)
          : base(message, innerException)
        {
        }
        
        protected LoginException(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
