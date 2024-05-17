using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using WebApplication1;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/Networks", () => GetNetworkConfig());

app.Run();

 string GetNetworkConfig()
    {
        NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
        List<NetworkInfo> networkInfoList = new List<NetworkInfo>();

        foreach (NetworkInterface networkInterface in networkInterfaces)
        {

            NetworkInfo info = new NetworkInfo
            {
                Interface = networkInterface.Name,
                Description = networkInterface.Description,
                Status = networkInterface.OperationalStatus.ToString(),
                Speed = networkInterface.Speed,
                MACAddress = networkInterface.GetPhysicalAddress().ToString(),
                IPv4Addresses = new List<string>(),
                SubnetMasks = new List<string>(),
                IPv6Addresses = new List<string>()
            };
            
            if (networkInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet || networkInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
            {
                IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                foreach (UnicastIPAddressInformation ip in ipProperties.UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                         info.IPv4Addresses.Add(ip.Address.ToString());
                        info.SubnetMasks.Add(ip.IPv4Mask.ToString());
                    }
                    else if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                    {
                        info.IPv6Addresses.Add(ip.Address.ToString());
                    }
                }
            }
            
            networkInfoList.Add(info);
            
        }
        return JsonConvert.SerializeObject(networkInfoList, Formatting.Indented);
    }
