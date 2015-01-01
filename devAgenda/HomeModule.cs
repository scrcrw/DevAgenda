namespace WebApplication1
{
    using Nancy;
    using DevAgenda.BLL;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
            	//var i = Store.Instance;

            	//using(var session = Store.Instance.DocStore.OpenSession())
            	{

            	}

            	return Consts.HelloMessage;
            };
        }
    }
}
