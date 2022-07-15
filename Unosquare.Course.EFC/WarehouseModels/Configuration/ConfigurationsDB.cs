using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseModels.Interfaces;

namespace WarehouseModels.Configuration
{
    public class ConfigurationsDB
    {
        public List<IConfigurationDB> configuration = new List<IConfigurationDB>();

        public List<IConfigurationDB> loadConfigurations()
        {
            configuration.Add(new CompanyDBConfig());
            configuration.Add(new ProductsDBConfig());

            return configuration;
        }

        public static List<IConfigurationDB> configurations()
        {
            ConfigurationsDB config= new ConfigurationsDB();
            return config.loadConfigurations();
        }
    }
}
