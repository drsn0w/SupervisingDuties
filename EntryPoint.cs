using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rage;
using LSPD_First_Response.Mod.API;

namespace SupervisingDuties
{
    public class EntryPoint : Plugin
    {
        public override void Initialize()
        {

            // Subscribe to OnOnDutyStateChanged event
            Functions.OnOnDutyStateChanged += OnDutyStateChangedHandler;

            // Log loading of our plugin
            Game.LogTrivial("SupervisingDuties v0.0.1, by drsn0w, loaded");
        }

        private static void OnDutyStateChangedHandler(bool OnDuty)
        {
            if (OnDuty)
            {
                Game.LogTrivial("Have fun");
            }
        }

        public override void Finally()
        {
            Game.LogTrivial("SupervisingDuties unloaded");
        }
    }
}
