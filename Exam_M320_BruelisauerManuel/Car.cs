using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_M320_BruelisauerManuel
{
    internal class Car : Vehicle
    {
        public override Vehicle selectVehicle(Journey journey)
        {
            if (journey.distance>500)
            {
                logger.log($"wegen zu grosser Distanz kann {journey.destinations} nicht durchgefuehrt werden");
                return new Car();
            }
            else
            {
                logger.log($"fuer {journey.destinations} wird das Auto verwendet");
                return new Car();
            }
        }
    }
}
