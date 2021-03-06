﻿using System.Configuration;

namespace NewSocketServer.Configuration
{
    public class PluginInfoInstanceCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new PluginInfoInstanceElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PluginInfoInstanceElement) element).Name;
        }
    }
}