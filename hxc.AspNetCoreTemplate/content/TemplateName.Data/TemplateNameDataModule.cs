﻿using System;
using Abp.EntityFrameworkCore;
using Abp.Modules;
using TemplateName.Core;

namespace TemplateName.Data
{
    [DependsOn(typeof(TemplateNameCoreModule), typeof(AbpEntityFrameworkCoreModule))]
    public class TemplateNameDataModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(this.GetType().Assembly);
        }
    }
}
