using Nancy;

namespace WebApplication1.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = x => View["Index.html"]; //
        }
    }
}