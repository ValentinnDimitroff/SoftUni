namespace _06.Birthday_Celebrations
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        private string Name { get; }
        public string Birthdate { get; }
    }
}
