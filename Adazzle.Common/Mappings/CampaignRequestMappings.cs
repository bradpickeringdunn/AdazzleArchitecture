using Adazzle.Common.Models;

namespace Adazzle.Common.Mappings
{
    public static class CampaignRequestMappings
    {
        public static ExampleResult ToExampleResult(this ExampleResult result)
        {
         return new ExampleResult() {
            CanHaveAHUGEGlassOfWine = result.CanHaveAHUGEGlassOfWine
            };
        }
    }
}
