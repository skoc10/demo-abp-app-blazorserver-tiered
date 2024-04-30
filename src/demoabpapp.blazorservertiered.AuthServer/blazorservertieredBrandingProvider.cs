﻿using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace demoabpapp.blazorservertiered;

[Dependency(ReplaceServices = true)]
public class blazorservertieredBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "blazorservertiered";
}
