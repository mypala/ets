using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class Connection
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Query { get; set; }
        public string QueryString { get; set; }

        public Connection()
        {
            Controller = default;
            Action = default;
            Query = default;
            QueryString = default;
        }
    }

    public class Connection<T>
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Query { get; set; }
        public string QueryString { get; set; }
        public T Model { get; set; }

        public Connection()
        {
            Controller = default;
            Action = default;
            Query = default;
            QueryString = default;
            Model = default;
        }
    }
}
