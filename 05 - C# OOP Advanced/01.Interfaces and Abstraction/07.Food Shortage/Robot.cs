namespace _07.Food_Shortage
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
        public string Model { get; set; }
        public string Id { get; }
    }
}
