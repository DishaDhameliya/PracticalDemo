using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticleDemoApp.Models
{
    public static class Call
    {
       static List<Bee> lstDynamic = new List<Bee>();

        public static List<Bee> getList()
        {
            Worker wr1 = new Worker(1, "Worker1", 100);
            Worker wr2 = new Worker(2, "Worker2", 100);
            Worker wr3 = new Worker(3, "Worker3", 100);
            Worker wr4 = new Worker(4, "Worker4", 100);
            Worker wr5 = new Worker(5, "Worker5", 100);
            Worker wr6 = new Worker(6, "Worker6", 100);
            Worker wr7 = new Worker(7, "Worker7", 100);
            Worker wr8 = new Worker(8, "Worker8", 100);
            Worker wr9 = new Worker(9, "Worker9", 100);
            Worker wr10 = new Worker(10, "Worker10", 100);

            lstDynamic.Add(wr1);
            lstDynamic.Add(wr2);
            lstDynamic.Add(wr3);
            lstDynamic.Add(wr4);
            lstDynamic.Add(wr5);
            lstDynamic.Add(wr6);
            lstDynamic.Add(wr7);
            lstDynamic.Add(wr8);
            lstDynamic.Add(wr9);
            lstDynamic.Add(wr10);

            Queen q1 = new Queen(11, "Queen1", 100);
            Queen q2 = new Queen(12, "Queen2", 100);
            Queen q3 = new Queen(13, "Queen3", 100);
            Queen q4 = new Queen(14, "Queen4", 100);
            Queen q5 = new Queen(15, "Queen5", 100);
            Queen q6 = new Queen(16, "Queen6", 100);
            Queen q7 = new Queen(17, "Queen7", 100);
            Queen q8 = new Queen(18, "Queen8", 100);
            Queen q9 = new Queen(19, "Queen9", 100);
            Queen q10 = new Queen(20, "Queen10", 100);

            lstDynamic.Add(q1);
            lstDynamic.Add(q2);
            lstDynamic.Add(q3);
            lstDynamic.Add(q4);
            lstDynamic.Add(q5);
            lstDynamic.Add(q6);
            lstDynamic.Add(q7);
            lstDynamic.Add(q8);
            lstDynamic.Add(q9);
            lstDynamic.Add(q10);

            Drone d1 = new Drone(21, "Drone1", 100);
            Drone d2 = new Drone(22, "Drone2", 100);
            Drone d3 = new Drone(23, "Drone3", 100);
            Drone d4 = new Drone(24, "Drone4", 100);
            Drone d5 = new Drone(25, "Drone5", 100);
            Drone d6 = new Drone(26, "Drone6", 100);
            Drone d7 = new Drone(27, "Drone7", 100);
            Drone d8 = new Drone(28, "Drone8", 100);
            Drone d9 = new Drone(29, "Drone9", 100);
            Drone d10 = new Drone(30, "Drone10", 100);

            lstDynamic.Add(d1);
            lstDynamic.Add(d2);
            lstDynamic.Add(d3);
            lstDynamic.Add(d4);
            lstDynamic.Add(d5);
            lstDynamic.Add(d6);
            lstDynamic.Add(d7);
            lstDynamic.Add(d8);
            lstDynamic.Add(d9);
            lstDynamic.Add(d10);
            return lstDynamic;
        }
       
        public static List<Bee> updateList(int id)
        {
            Random rnd = new Random();
            int decrease = rnd.Next(0, 80);
            Bee findRecord = lstDynamic.Where(x => x.id == id).FirstOrDefault();
            findRecord.health -= decrease;
            return lstDynamic;
        }
    }
}
