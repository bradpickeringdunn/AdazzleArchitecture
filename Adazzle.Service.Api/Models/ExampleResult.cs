using OutTheBox.Services.Results;
using System.Runtime.Serialization;

namespace Adazzle.Services.Campaign.Api.Models
{
    [DataContract]
    public class ExampleResult : GenericServiceResult
    {
        [DataMember]
        //Response properties go here E.g. database results.
        public dynamic ListDatabaseResults { get; set; }
    }
}
