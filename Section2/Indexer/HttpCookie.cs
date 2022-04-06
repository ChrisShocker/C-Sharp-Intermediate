using System.Collections.Generic;

namespace Indexer
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictonary;

        public HttpCookie()
        {
            this._dictonary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                return this._dictonary[key];

            }
            set
            {
                this._dictonary[key] = value;
            }
        }
    }
}
