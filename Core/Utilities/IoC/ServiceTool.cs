using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.IoC
{
    //Web Api'de veya Autofac'de oluşturduğumuz injection'ları oluşturabilmemize yarıyor.
    //İstediğimiz herhangi bir interface'in servisteki karşılığını alabilmemize yarıyor.
    public static class ServiceTool
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static IServiceCollection Create(IServiceCollection services)
        {
            ServiceProvider = services.BuildServiceProvider();
            return services;
        }
    }
}
