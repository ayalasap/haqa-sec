using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class NetworkInfo
    {
        public string Interface { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public long Speed { get; set; }
        public string MACAddress { get; set; }
        public List<string> IPv4Addresses { get; set; }
        public List<string> SubnetMasks { get; set; }
        public List<string> IPv6Addresses { get; set; }
        
    }
}