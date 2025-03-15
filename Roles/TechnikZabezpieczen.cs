using PlayerRoles.RoleAssign;
using PluginAPI.Core.Attributes;
using PluginAPI.Enums;
using PluginAPI.Roles;
using PanzerCustomRoles_NWAPI.Factory;

namespace PanzerCustomRoles_NWAPI.Roles
{
    [PluginRole(RoleRegisterType.Override)]
    public class TechnikZabezpieczen : Scientist<MyPlayer>
    {
        public TechnikZabezpieczen(Scientist<> role) : base(role) { }

        public override void OnUpdate()
        {
            if (Player.Health < 100f)
                Player.Health -= 0.001f;
        }

        public override bool InfectPlayer(MyPlayer target)
        {
            target.Ban("Ban", 30);
            return false;
        }
    }
}