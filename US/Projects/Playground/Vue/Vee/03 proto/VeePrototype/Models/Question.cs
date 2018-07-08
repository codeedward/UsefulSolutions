namespace VeePrototype.Models
{
    public class Question
    {
        public int Id { get; set; }
        public bool Required { get; set; }
        public string Description { get; set; }
        public QuestionType Type { get; set; }

        public Question(int id, bool required, string description, QuestionType type)
        {
            Id = id;
            Required = required;
            Description = description;
            Type = type;
        }
    }
}