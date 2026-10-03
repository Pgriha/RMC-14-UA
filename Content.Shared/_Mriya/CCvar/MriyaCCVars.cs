using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared._Mriya.CCVar;

[CVarDefs]
public sealed partial class MriyaCVars : CVars
{
    /// <summary>
    /// Використовується для відображення старих/наших спрайтів, замість РМСних
    /// </summary>
    public static readonly CVarDef<bool> MRUseOldSprites =
        CVarDef.Create("mriya.use_old_sprites", true, CVar.REPLICATED | CVar.CLIENT | CVar.ARCHIVE);
}
