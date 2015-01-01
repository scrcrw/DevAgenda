namespace DevAgenda.BLL
{
    using System;
    using Raven.Client;
    using Raven.Client.Embedded;

    public sealed class Store
	{
	   private static volatile Store _instance;
	   private static object _syncRoot = new Object();

	   public IDocumentStore DocStore { get; private set; }

	   private Store() 
	   {
            var docStore = new EmbeddableDocumentStore
            {	
                DataDirectory = "Data"
            };
            docStore.Initialize();

            DocStore = docStore;
	   }

	   public static Store Instance
	   {
	      get 
	      {
	         if (_instance == null) 
	         {
	            lock (_syncRoot) 
	            {
	               if (_instance == null) 
	                  _instance = new Store();
	            }
	         }

	         return _instance;
	      }
	   }
	}
}