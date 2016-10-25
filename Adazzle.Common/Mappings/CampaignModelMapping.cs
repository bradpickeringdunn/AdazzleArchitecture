using Adazzle.Service.Api.Models;

namespace Adazzle.Common.Mappings
{
    public static class CampaignModelMapping
    {
        public static Service.Api.Models. AsServiceRequest(this Models.ExampleModel model)
        {
            return new ExampleRequest()
            {
                Name = model.Name,

                Age = model.Age
            };
        }
    }
}
