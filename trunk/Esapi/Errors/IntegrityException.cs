﻿/// <summary> OWASP .NET Enterprise Security API (.NET ESAPI)
/// 
/// This file is part of the Open Web Application Security Project (OWASP)
/// .NET Enterprise Security API (.NET ESAPI) project. For details, please see
/// http://www.owasp.org/index.php/Category:ESAPI.
/// 
/// Copyright (c) 2009 - The OWASP Foundation
/// 
/// The .NET ESAPI is published by OWASP under the BSD. You should read and accept the
/// LICENSE before you use, modify, and/or redistribute this software.
/// 
/// </summary>
/// <author>  Alex Smolen
/// </author>
/// <created>  2008 </created>

using System;

namespace Owasp.Esapi.Errors
{
    /// <summary> An AvailabilityException should be thrown when the availability of a limited
    /// resource is in jeopardy. For example, if a database connection pool runs out
    /// of connections, an availability exception should be thrown.
    /// </summary>
    /// <author>  Alex Smolen (me@alexsmolen.com)
    /// </author>
    [Serializable]
    public class IntegrityException: EnterpriseSecurityException
    {
        /// <summary>The Constant serialVersionUID. </summary>
        private const long serialVersionUID = 1L;

        /// <summary> Instantiates a new availability exception.</summary>
        protected internal IntegrityException()
        {
            // hidden
        }

        /// <summary> Creates a new instance of IntegrityException.
        /// 
        /// </summary>
        /// <param name="userMessage">The message for the user.
        /// </param>
        /// <param name="logMessage">The message for the log.
        /// </param>
        public IntegrityException(string userMessage, string logMessage)
            : base(userMessage, logMessage)
        {
        }

        /// <summary> Instantiates a new IntegrityException.
        /// 
        /// </summary>
        /// <param name="userMessage">The message for the user.
        /// </param>
        /// <param name="logMessage">The message for the log.
        /// </param>
        /// <param name="cause">The cause of the exception.
        /// </param>
        public IntegrityException(string userMessage, string logMessage, Exception cause)
            : base(userMessage, logMessage, cause)
        {
        }
    }
}