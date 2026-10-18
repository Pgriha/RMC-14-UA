using Content.Shared.FixedPoint;

namespace Content.Shared._RMC14.Xenonids.Psychic;

[RegisterComponent]
public sealed partial class XenoPsychicCommunicationComponent : Component
{
    [DataField]
    public float WhisperRange = 7;

    [DataField]
    public float RadianceRange = 12;

    [DataField]
    public FixedPoint2 RadiancePlasmaCost = 0; // Mriya. 100 в оригіналі. Поекономьте плазму моїй королеві

    [DataField]
    public FixedPoint2 GiveOrderPlasmaCost = 0; // Mriya. 100 в оригіналі. Поекономьте плазму моїй королеві

    [DataField]
    public int CharacterLimit = 200;
}
