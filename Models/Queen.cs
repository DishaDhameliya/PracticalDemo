using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PracticleDemoApp.Models
{
    public class Queen: Bee
    {
        public int id { get; set; }
        public string name { get; set; }

        [Range(1, 100)]
        public float health { get; set; }
        public Queen(int idValue, string nameValue, float healthValue)
        {
            id = idValue;
            name = nameValue;
            health = healthValue;
        }
        public List<Bee> Damage(int percentage)
        {
            if (!isDead)
                return Call.updateList(percentage);
            else
                return Call.getList();
        }
        public Boolean isDead
        {
            get
            {
                return health < 20 ? true : false;
            }
            set { }
        }
    }
}
