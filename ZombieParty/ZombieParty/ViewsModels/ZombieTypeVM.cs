using ZombieParty.Models;

namespace ZombieParty.ViewsModels
{
    public class ZombieTypeVM
    {
        public ZombieType ZombieType { get; set; }
        public List<Zombie> ZombiesList { get; set; } = new List<Zombie>();
    }

}
