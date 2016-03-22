namespace _3.Company_Hierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Developer : RegularEmployee
    {
        private List<Project> projects; 
        public Developer(uint id, string firstName, string lastName, decimal salary, DepartamentType departament)
            : base(id,firstName,lastName,salary,departament)
        {
            this.projects = new List<Project>();
        }

        public List<Project> Projects
        {
            get { return this.projects; }
        } 

        public void CloseProject(Project project)
        {
            bool found = this.projects.Any(pr => pr.Name == project.Name);

            if (!found)
            {
                throw new ArgumentException("Projects is not part of developers project.");
            }

            project.IsOpen = false;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"ID: {this.Id} First name: {this.FirstName} Last name: {this.LastName}\nSalary: {this.Salary} Departament: {this.Departament}");
            output.AppendLine("Sales:");
            foreach (Project project in this.Projects)
            {
                output.AppendLine($"Project name: {project.Name} Start date of the project: {project.StartDate}\n Project details: {project.Details}\n Open: {project.IsOpen}");
            }
            return output.ToString();
        }
    }
}
