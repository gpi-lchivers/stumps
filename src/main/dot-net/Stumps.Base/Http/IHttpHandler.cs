﻿namespace Stumps.Http
{

    using System;

    /// <summary>
    ///     An interface that represents an implementation for processing an HTTP request.
    /// </summary>
    internal interface IHttpHandler
    {

        /// <summary>
        ///     Occurs when an incomming HTTP requst is processed and responded to by the HTTP handler.
        /// </summary>
        event EventHandler<StumpsContextEventArgs> ContextProcessed;

        /// <summary>
        ///     Processes an incoming HTTP request.
        /// </summary>
        /// <param name="context">The <see cref="T:Stumps.IStumpsHttpContext"/> representing both the incoming request and the response.</param>
        /// <returns>
        ///     A member of the <see cref="T:Stumps.Http.ProcessHandlerResult"/> enumeration.
        /// </returns>
        ProcessHandlerResult ProcessRequest(IStumpsHttpContext context);

    }

}