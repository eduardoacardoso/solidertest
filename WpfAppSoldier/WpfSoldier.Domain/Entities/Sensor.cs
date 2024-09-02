using System;
using System.Collections.Generic;

namespace WpfSoldier.Domain.Entities
{

    public partial class Sensor
    {
        public Guid SensorId { get; set; }

        public Guid SoldierId { get; set; }

        public string SensorName { get; set; } = null!;

        public string SensorType { get; set; } = null!;

        public virtual Soldier Soldier { get; set; } = null!;
    }
}
