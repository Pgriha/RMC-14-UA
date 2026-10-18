// Ported from Colonial Marines Universe (https://github.com/AU-14/ColonialMarinesUniverse), licensed under AGPL-3.0.
using Content.Shared._CMU14.Announce;
using Robust.Shared;
using Robust.Shared.Configuration;

namespace Content.Shared._CMU14.CCVar;

[CVarDefs]
public sealed class CMUCVars : CVars
{
    /// <summary>
    /// How announcements should be displayed for this client.
    /// </summary>
    public static readonly CVarDef<AnnouncementDisplayPreference> CMUAnnouncementStyle =
        CVarDef.Create("cmu.announcement_style", AnnouncementDisplayPreference.Default, CVar.ARCHIVE | CVar.CLIENTONLY);

    /// <summary>
    /// Per-announcement display overrides keyed by announcement preset id.
    /// </summary>
    public static readonly CVarDef<string> CMUAnnouncementStyleOverrides =
        CVarDef.Create("cmu.announcement_style_overrides", string.Empty, CVar.ARCHIVE | CVar.CLIENTONLY);
}
