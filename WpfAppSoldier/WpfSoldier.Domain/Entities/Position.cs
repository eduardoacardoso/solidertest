using System;
using System.Collections.Generic;

namespace WpfSoldier.Domain.Entities { 

public partial class Position
{
    public Guid PositionId { get; set; }

    public Guid SoldierId { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public virtual Soldier Soldier { get; set; } = null!;
}

}