namespace WebApplication1
{
    using Nancy;
    using DevAgenda.BLL;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => Consts.HelloMessage;
        }
    }
}
