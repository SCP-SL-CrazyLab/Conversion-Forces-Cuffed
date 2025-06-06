using Exiled.API.Features;
using System;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;

namespace CuffConversion
{
    public class CuffConversionPlugin : Plugin<Config>
    {
        public static CuffConversionPlugin Instance;

        private readonly ConvertOnEscape _handler = new();

        public override string Author => "CrazyLab";
        public override string Name => "CuffConversion";
        public override string Prefix => "CF";
        public override Version Version => new(1, 0, 0);
        public override Version RequiredExiledVersion => new(9, 6, 0);

        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Player.Escaping += _handler.OnCuffedEscape;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Escaping -= _handler.OnCuffedEscape;
            Instance = null;
            base.OnDisabled();
        }
        public void OnCuffedEscape(EscapingEventArgs ev)
        {
            var cfg = CuffConversionPlugin.Instance.Config;

            if (!cfg.IsEnabled || !ev.IsAllowed || !ev.Player.IsCuffed) return;

            var cuffer = ev.Player.Cuffer;
            if (cuffer == null) return;

            if (cfg.ConvertChaosToMTF &&
                ev.Player.Role.Team == Team.ChaosInsurgency &&
                cuffer.Role.Team == Team.FoundationForces)
            {
                ev.Player.Role.Set(RoleTypeId.NtfPrivate);
                ev.Player.Broadcast(cfg.BroadcastDuration, cfg.ChaosToMTFMessage);
            }

            else if (cfg.ConvertMTFToChaos &&
                     ev.Player.Role.Team == Team.FoundationForces &&
                     cuffer.Role.Team == Team.ChaosInsurgency)
            {
                ev.Player.Role.Set(RoleTypeId.ChaosConscript);
                ev.Player.Broadcast(cfg.BroadcastDuration, cfg.MTFToChaosMessage);
            }
        }

    }
}