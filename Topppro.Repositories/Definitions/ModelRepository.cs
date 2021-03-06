﻿using Topppro.Interfaces.Repositories;

namespace Topppro.Repositories.Definitions
{
    public class ModelRepository : 
        Repository<Topppro.Entities.Model>, IModelRepository
    {
        public ModelRepository() { }

        public ModelRepository(ToppproEntities context) :
            base(context)
        {

        }
    }
}