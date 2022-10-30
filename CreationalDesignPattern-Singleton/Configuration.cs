namespace CreationalDesignPattern_Singleton;
internal class Configuration
{
	private static Configuration _instance;
	private static readonly object _instanceLock = new object();

	public string InitValue { get; set; }

	private Configuration() 
	{
		InitValue = "Hello Singleton!";
	}

	public static Configuration Instance 
	{
		get 
		{
			if(_instance is null)
			{
				lock(_instanceLock)
				{
					if(_instance is null)
					{
						_instance = new Configuration();
					}
				}
			}
			return _instance; 
		}
	}
}
