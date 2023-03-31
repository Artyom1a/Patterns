namespace FitnessClub.Domain
{
    internal interface IMembership //интерфейс абонемента
    {
        string Name { get; }
        string Description { get; set; }
        decimal GetPrice(); //метод цены
    }
}