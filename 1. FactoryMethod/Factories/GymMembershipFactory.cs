using FitnessClub.Domain;

namespace FitnessClub.Factories
{
    internal class GymMembershipFactory : MembershipFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public GymMembershipFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMembership GetMembership() // реализация фабричного метода (мы его переопределяем)
        {
            GymMembership membership = new(_price) // создаём абонемент только для посещения спортзала
            {
                Description = _description
            };

            return membership;
        }
    }
}