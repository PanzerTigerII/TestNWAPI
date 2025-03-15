﻿namespace PanzerCustomRoles_NWAPI.Commands
{
    using CommandSystem;
    using System;

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class TestCommand : ICommand
    {
        public string Command { get; } = "test";

        public string[] Aliases { get; } = new string[] { "tstcmd", "testcommand" };

        public string Description { get; } = "Test command.";

        public bool SanitizeResponse { get; } = false;

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "Success response";
            return true;
        }
    }
}