using System.Drawing;
using ZombieParty.Models;

namespace ZombieParty.ViewsModels
{
    public class ZombieTypeVM
    {
        public ZombieType ZombieType { get; set; }

        public List<Zombie> ZombiesList { get; set; } = new List<Zombie>();

        public int ZombieCount { get; set; }

        public double AveragePoint { get; set; }
    }

}
