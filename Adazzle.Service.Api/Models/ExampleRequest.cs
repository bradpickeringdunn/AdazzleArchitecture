using System.Runtime.Serialization;

namespace Adazzle.Services.Campaign.Api.Models
{
    [DataContract]
    public class ExampleRequest
    {
        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Name { get; set; }
        
    }
}
