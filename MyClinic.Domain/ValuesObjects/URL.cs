using System;
using System.Collections.Generic;
using System.Text;

namespace MyClinic.Domain.ValuesObjects
{
    public class URL
    {
        public URL(string url)
        {
            this.URLResource = url;
        }

        public string URLResource { get; private set; }
    }
}
