﻿namespace TestsAreFun.Configuration;

public class ConfigurationWrapper : IConfigurationWrapper
{
    public string ConnectionString
    {
        get { return Configuration.ConnectionString; }
    }
}