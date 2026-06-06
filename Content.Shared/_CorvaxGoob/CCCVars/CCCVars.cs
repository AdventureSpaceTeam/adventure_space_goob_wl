using Robust.Shared.Configuration;

namespace Content.Shared._CorvaxGoob.CCCVars;

/// <summary>
///     Corvax modules console variables
/// </summary>
[CVarDefs]
// ReSharper disable once InconsistentNaming
public sealed class CCCVars
{
    /*
     * Station Goal
     */

    /// <summary>
    /// Send station goal on round start or not.
    /// </summary>
    public static readonly CVarDef<bool> StationGoal =
        CVarDef.Create("game.station_goal", true, CVar.SERVERONLY);

    /// <summary>
    /// Deny any VPN connections.
    /// </summary>
    public static readonly CVarDef<bool> PanicBunkerDenyVPN =
        CVarDef.Create("game.panic_bunker.deny_vpn", false, CVar.SERVERONLY);


    /// <summary>
    /// Maximum name for a squad in SecApartment
    /// </summary>
    public static readonly CVarDef<int> MaxSquadNameLength =
        CVarDef.Create("game.max_squad_name", 16, CVar.SERVER | CVar.REPLICATED);

    /// <summary>
    /// Will skills be applied to players.
    /// </summary>
    public static readonly CVarDef<bool> SkillsEnabled =
        CVarDef.Create("skills.enabled", true, CVar.SERVERONLY);

    /// <summary>
    /// Show MRP-designated jobs in the lobby and late join.
    /// </summary>
    public static readonly CVarDef<bool> MrpJobsEnabled =
        CVarDef.Create("jobs.mrp_enabled", true, CVar.SERVER | CVar.REPLICATED);

    /// <summary>
    /// Activate announcer in round by their special calendar.
    /// </summary>
    public static readonly CVarDef<bool> CalendarAnnouncerEnabled =
        CVarDef.Create("announcer.calendar", true, CVar.SERVERONLY);

    /// <summary>
    /// Offer item.
    /// </summary>
    public static readonly CVarDef<bool> OfferModeIndicatorsPointShow =
        CVarDef.Create("hud.offer_mode_indicators_point_show", true, CVar.ARCHIVE | CVar.CLIENTONLY);

    public static readonly CVarDef<bool> CombatModeSoundEnabled =
        CVarDef.Create("audio.combat_mode_sound_enabled", true, CVar.ARCHIVE | CVar.CLIENTONLY);

    /// <summary>
    /// Default volume setting of announcements sound.
    /// </summary>
    public static readonly CVarDef<float> AnnouncementsSound =
        CVarDef.Create("audio.announcements_volume", 0.5f, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> PhotoPlayTimeRequire =
        CVarDef.Create("photo.playtime_require", true, CVar.SERVERONLY);

    public static readonly CVarDef<float> PhotoPlayTimeHours =
        CVarDef.Create("photo.playtime_require_time", 20f, CVar.SERVERONLY);
}
