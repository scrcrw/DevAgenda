namespace DevAgenda
{
    using Nancy;
    using DevAgenda.BLL;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
            	using(var session = Store.Instance.DocStore.OpenSession())
            	{

            	}

            	return View["index"];
            };
        }
    }
}
