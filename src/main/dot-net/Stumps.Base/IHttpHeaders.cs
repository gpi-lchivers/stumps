namespace Stumps
{

    using System.Collections.Generic;

    /// <summary>
    ///     An interface that represents a collection of HTTP headers.
    /// </summary>
    public interface IHttpHeaders
    {

        /// <summary>
        ///     Gets the count of headers in the dictionary.
        /// </summary>
        /// <value>
        /// The count of headers in the dictionary.
        /// </value>
        int Count { get; }

        /// <summary>
        ///     Gets a collection of the names of all the headers.
        /// </summary>
        /// <value>
        ///     The collection of names of all the headers.
        /// </value>
        ICollection<string> HeaderNames { get; }


        /// <summary>
        ///     Gets a value indicating whether the <see cref="T:Stumps.IHttpHeaders"/> is read-only.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the <see cref="T:Stumps.IHttpHeaders"/> is read-only; otherwise, <c>false</c>.
        /// </value>
        bool IsReadOnly { get; }

        /// <summary>
        ///     Gets or sets the <see cref="System.String"/> value for the specified header name.
        /// </summary>
        /// <value>
        ///     The <see cref="System.String"/> value for the specified header name.
        /// </value>
        /// <param name="headerName">The name of the header.</param>
        string this[string headerName] { get; set; }

        /// <summary>
        ///     Clears all existing headers from the instance.
        /// </summary>
        void Clear();

        /// <summary>
        ///     Copies the elements of the <see cref="T:Stumps.IHttpHeaders"/> collection to another <see cref="T:Stumps.IHttpHeaders"/>.
        /// </summary>
        /// <param name="httpHeaders">The target <see cref="T:Stumps.IHttpHeaders"/>.</param>
        /// <exception cref="System.ArgumentNullException"><paramref name="httpHeaders"/> is <c>null</c>.</exception>
        void CopyTo(IHttpHeaders httpHeaders);

        /// <summary>
        ///     Removes the header with the specified name.
        /// </summary>
        /// <param name="headerName">The name of the header to remove.</param>
        /// <returns><c>true</c> if the header was found and removed; otherwise, <c>false</c>.</returns>
        bool Remove(string headerName);

    }

}
