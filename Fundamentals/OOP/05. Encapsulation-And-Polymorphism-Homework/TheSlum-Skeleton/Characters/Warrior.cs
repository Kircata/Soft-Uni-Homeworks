using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Warrior : AttackableCharacter
    {
        private const int AttackPointsDefault = 150;
        private const int DefensePointsDefault = 100;
        private const int HealthPointsDefault = 200;
        private const int RangePointsDefault = 2;

        public Warrior(string id, int x, int y, Team team) 
            : base(id, x, y, HealthPointsDefault,DefensePointsDefault, team, RangePointsDefault)
        {
            this.AttackPoints = AttackPointsDefault;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.FirstOrDefault(c => c.IsAlive && c.Team != this.Team);
        }

      
    }
}
