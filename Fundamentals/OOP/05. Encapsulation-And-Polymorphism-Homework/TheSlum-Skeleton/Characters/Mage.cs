using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    public class Mage : AttackableCharacter
    {

        private const int AttackPointsDefault = 300;
        private const int DefensePointsDefault = 50;
        private const int HealthPointsDefault = 150;
        private const int RangePointsDefault = 5;

        public Mage(string id, int x, int y, Team team) 
            : base(id, x, y, HealthPointsDefault,DefensePointsDefault, team, RangePointsDefault)
        {
            this.AttackPoints = AttackPointsDefault;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault(c => c.IsAlive && c.Team != this.Team);
        }

    }
}
