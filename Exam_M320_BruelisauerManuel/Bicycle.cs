using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_M320_BruelisauerManuel
{
    internal class Bicycle : Vehicle 
    {
        public override Vehicle selectVehicle(Journey journey)
        {
            if (journey.distance > 30)
            {
                logger.log($"wegen zu grosser Distanz kann {journey.destinations} nicht durchgefuehrt werden");
                return new Bicycle();
            }
            else
            {
                logger.log($"fuer {journey.destinations} wird das Fahrrad verwendet");
                return new Bicycle();
            }
        }
    }
}
