using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfSoldier.Application.Interface
{
    public interface ISensorSimulationService
    {
        (double, double) GenerateRandomCoordinates();
    }
}
