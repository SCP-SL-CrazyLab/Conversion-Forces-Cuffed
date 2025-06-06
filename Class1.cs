using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace CuffConversion
{
    public class ConvertOnEscape
    {
        public void OnCuffedEscape(EscapingEventArgs ev)
        {
            if (!ev.IsAllowed || ev.Player.Role.Side == Side.Scp) return;
            if (!ev.Player.IsCuffed) return;

            var cuffer = ev.Player.Cuffer;
            if (cuffer == null) return;

            // إذا كان المقيد Chaos وقام بتقييده MTF
            if (ev.Player.Role.Team == Team.ChaosInsurgency && cuffer.Role.Team == Team.FoundationForces)
            {
                ev.Player.Role.Set(RoleTypeId.NtfPrivate); // تحويله إلى MTF
                ev.Player.Broadcast(5, "<color=green>You have been transferred to MTF after your escape!</color>");
            }

            // إذا كان المقيد MTF وقام بتقييده Chaos
            else if (ev.Player.Role.Team == Team.FoundationForces && cuffer.Role.Team == Team.ChaosInsurgency)
            {
                ev.Player.Role.Set(RoleTypeId.ChaosConscript); // تحويله إلى Chaos
                ev.Player.Broadcast(5, "<color=red>You have been transferred to Chaos after your escape!</color>");
            }
        }
    }
}