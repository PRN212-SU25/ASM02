﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.Entities;

public partial class RoomType
{
    public int RoomTypeId { get; set; }

    public string RoomTypeName { get; set; }

    public string TypeDescription { get; set; }

    public string TypeNote { get; set; }

    public virtual ICollection<RoomInformation> RoomInformations { get; set; } = new List<RoomInformation>();
}
