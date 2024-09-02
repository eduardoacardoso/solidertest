using System;
using System.Collections.Generic;

namespace WpfSoldier.Domain.Entities
{

    public partial class Training
    {
        public Guid TrainingId { get; set; }

        public Guid SoldierId { get; set; }

        public string TraningIformation { get; set; } = null!;

        public virtual Soldier Soldier { get; set; } = null!;
    }
}
