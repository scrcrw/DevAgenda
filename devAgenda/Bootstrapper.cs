namespace DevAgenda
{
    using Nancy;
	using Nancy.TinyIoc;
	using Nancy.Bootstrapper;
	using DevAgenda.BLL;

	public class CustomBootstrapper : DefaultNancyBootstrapper
	{
	    protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
	    {
	         Store.Instance.Init();
	    }
	}
}