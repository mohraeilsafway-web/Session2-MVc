using GymManagementSystem.Entities.Enums;

namespace GymManagementSystem.Entities
{
    public class Trainer :GymUser
    {
        public DateTime HireDate { get; set; }
        public Specialities Specialities { get; set; }
        public ICollection<Session> Sessions { get; set; } = default!;
    }

}
