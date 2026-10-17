using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared._Mriya.CCVar;

[CVarDefs]
public sealed class MriyaCVars : CVars
{
    public static readonly CVarDef<float> MriyaExplosionShakeIntensity =
        CVarDef.Create("mriya.explosion_shake_intensity", 1f, CVar.CLIENTONLY | CVar.ARCHIVE);
}
