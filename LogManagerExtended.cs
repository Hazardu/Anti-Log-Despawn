using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anti_Log_Despawn
{
    class SceneTrackerEx : sceneTracker 
    {
        protected override void doAwake()
        {
            base.doAwake();
            maxSpawnedLogs = int.MaxValue - 8;
        }
    }
}
