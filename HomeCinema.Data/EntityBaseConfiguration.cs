﻿using System.Data.Entity.ModelConfiguration;
using HomeCinema.Entities;

namespace HomeCinema.Data
{
    public class EntityBaseConfiguration<T> : EntityTypeConfiguration<T> where T : class, IEntityBase
    {
        public EntityBaseConfiguration()
        {
            HasKey(e => e.Id);
        }
    }
}