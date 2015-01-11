namespace DevAgenda.BLL
{
    using System;
    using Raven.Client;
	using Raven.Client.Document;
	using Raven.Client.Extensions;

    public sealed class Store
    {
        private static volatile Store _instance;
        private static object _syncRoot = new Object();

        private IDocumentStore _docStore;
        public IDocumentStore DocStore
        { 
            get { return _docStore; }
            private set
            {
                _docStore = value;
            } 
        }

        public void Init()
        {
            var docStore = new DocumentStore
            {	
				Url = "http://localhost:8080/",	// server URL
				DefaultDatabase = "Northwind"	// default database
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