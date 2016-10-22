using Adazzle.Performace.Examples.Models;
using ServiceModels = Adazzle.Service.Models;

namespace Adazzle.Performace.Examples.Mappings
{
    public static class ExampleResultMappings
    {
        public static ExampleResult ToExampleResult(this ServiceModels.ExampleResult result)
        {
         return new ExampleResult() {
            CanHaveAHUGEGlassOfWine = result.CanHaveAHUGEGlassOfWine
            };
        }
    }
}
