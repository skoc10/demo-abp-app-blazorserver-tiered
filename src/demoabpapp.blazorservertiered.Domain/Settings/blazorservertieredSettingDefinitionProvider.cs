using Volo.Abp.Settings;

namespace demoabpapp.blazorservertiered.Settings;

public class blazorservertieredSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(blazorservertieredSettings.MySetting1));
    }
}
