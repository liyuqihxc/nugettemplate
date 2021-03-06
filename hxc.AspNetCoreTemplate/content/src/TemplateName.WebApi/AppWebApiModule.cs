﻿using System;
using Abp.AutoMapper;
using Abp.Modules;
using TemplateName.App;
using TemplateName.WebApi.Exceptions;

namespace TemplateName.WebApi
{
    [DependsOn(typeof(AppApplicationModule), typeof(AbpAutoMapperModule))]
    public class AppWebApiModule : AbpModule
    {
        public override void PreInitialize()
        {
            
        }
        
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().Assembly);
        }
    }
}
