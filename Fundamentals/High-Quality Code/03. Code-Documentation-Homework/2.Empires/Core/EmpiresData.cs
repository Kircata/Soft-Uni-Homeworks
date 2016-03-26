﻿namespace _1.Empires.Core
{
    using System;
    using System.Collections.Generic;
    using Contracts;
    using Enums;

    public class EmpiresData : IEmpiresData
    {
        private readonly ICollection<IBuilding> buildings = new List<IBuilding>();
        

        public EmpiresData()
        {
            this.Resources = new Dictionary<ResourceType, int>();
            this.Units = new Dictionary<string,int>();
            this.InitResources();
        }

        private void InitResources()
        {
            var resourceTypes = Enum.GetValues(typeof (ResourceType));
            foreach (ResourceType resourceType in resourceTypes)
            {
                this.Resources.Add(resourceType, 0);
            }
        }

        public IEnumerable<IBuilding> Buildings => this.buildings;
        public void AddBuilding(IBuilding building)
        {
            if (building == null)
            {
                throw new ArgumentNullException(nameof(building));
            }

             this.buildings.Add(building);
        }

        public void AddUnit(IUnit unit)
        {
            if (unit == null)
            {
                throw new ArgumentNullException(nameof(unit));
            }

            var unitType = unit.GetType().Name;
            if (!this.Units.ContainsKey(unitType))
            {
                this.Units.Add(unitType,0);
            }

            this.Units[unitType]++;
        }

        public IDictionary<string, int> Units { get; }
        public IDictionary<ResourceType, int> Resources { get; }
    }
}
