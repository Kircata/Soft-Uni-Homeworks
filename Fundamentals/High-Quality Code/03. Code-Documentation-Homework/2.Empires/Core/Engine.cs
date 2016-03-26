namespace _1.Empires.Core
{
    using System;
    using Contracts;
    using System.Linq;
    using System.Text;

    public class Engine : IRunnable
    {
        private IBuildingFactory buildingFactory;
        private IResourceFactory resourceFactory;
        private IUnitFactory unitFactory;
        private IEmpiresData empiresData;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(
            IBuildingFactory buildingFactory,
            IResourceFactory resourceFactory,
            IUnitFactory unitFactory,
            IEmpiresData empiresData,
            IInputReader reader,
            IOutputWriter writer)
        {
            this.buildingFactory = buildingFactory;
            this.resourceFactory = resourceFactory;
            this.unitFactory = unitFactory;
            this.empiresData = empiresData;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();
                this.ExecuteCommand(input);
                this.UpdateBuildings();
            }
        }

        private void UpdateBuildings()
        {
            foreach (IBuilding building in this.empiresData.Buildings)
            {
                building.Update();
                if (building.CanProduceResource)
                {
                    var resource = building.ProduceResource();
                    this.empiresData.Resources[resource.ResourceType] += resource.Quantity;
                }
                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.empiresData.AddUnit(unit);
                }
            }


        }

        private void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(inputParams[1]);
                    break;
                default:
                    throw new ArgumentException("Unknown command.");
            }
        }

        private void ExecuteBuildCommand(string buildingType)
        {
            IBuilding building = this.buildingFactory.CreateBuilding(buildingType, this.unitFactory,
                this.resourceFactory);
            this.empiresData.AddBuilding(building);
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();
            AppendTreasuryInfo(output);
            AppendBuildingsInfo(output);
            AppendUnitsInfo(output);

            this.writer.WriteLine(output.ToString().Trim());
        }

        private void AppendUnitsInfo(StringBuilder output)
        {
            output.AppendLine("Units:");
            if (this.empiresData.Units.Any())
            {
                foreach (var unit in this.empiresData.Units)
                {
                    output.Append($"--{unit.Key}: {unit.Value}{Environment.NewLine}");
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendBuildingsInfo(StringBuilder output)
        {
            output.AppendLine("Buildings:");
            if (this.empiresData.Buildings.Any())
            {
                foreach (IBuilding building in this.empiresData.Buildings)
                {
                    output.AppendLine(building.ToString());
                }
            }
            else
            {
                output.AppendLine("N/A");
            }
        }

        private void AppendTreasuryInfo(StringBuilder output)
        {
            output.AppendFormat("Treasury:{0}", Environment.NewLine);
            foreach (var resource in this.empiresData.Resources)
            {
                output.Append($"--{resource.Key}: {resource.Value}{Environment.NewLine}");
            }
        }
    }
}
