using System;
using System.Collections.Generic;

namespace WpfSoldier.Domain.Entities
{

    public partial class Soldier
    {
        public Guid SoldierId { get; set; }

        public string Name { get; set; } = null!;

        public string Rank { get; set; } = null!;

        public string Country { get; set; } = null!;

        public virtual ICollection<Position> Positions { get; set; } = new List<Position>();

        public virtual ICollection<Sensor> Sensors { get; set; } = new List<Sensor>();

        public virtual ICollection<Training> Training { get; set; } = new List<Training>();
    }
}
