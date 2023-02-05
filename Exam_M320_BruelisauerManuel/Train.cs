using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_M320_BruelisauerManuel
{
    internal class Train : Vehicle
    {
        public override Vehicle selectVehicle(Journey journey)
        {
            if (journey.distance > 1000)
            {
                logger.log($"wegen zu grosser Distanz kann {journey.destinations} nicht durchgefuehrt werden");
                return new Train();
            }
            else
            {
                logger.log($"fuer {journey.destinations} wird der Zug verwendet");
                return new Train();
            }
        }
    }
}
