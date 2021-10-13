using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace PracticleDemoApp.Models
{
    public  interface Bee
    {
        public int id { get; set; }
        public string name { get; set; }
        public float health { get; set; }        
        public Boolean isDead { get; set; }

        public List<Bee> Damage(int percentage);
    }

   
}
