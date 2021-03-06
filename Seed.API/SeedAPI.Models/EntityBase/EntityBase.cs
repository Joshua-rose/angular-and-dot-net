﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SeedAPI.Models.EntityBase
{
    class EntityBase
    {
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public bool Deleted { get; set; }
        public EntityBase()
        {
            Deleted = false;
        }
        public virtual int IdentityId()
        {
            return 0;
        }
        public virtual object[] IdentityId(bool dummy = true)
        {
            return new List<object>().ToArray();
        }
    }
}
