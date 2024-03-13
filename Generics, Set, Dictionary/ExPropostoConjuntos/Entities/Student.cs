namespace ExPropostoConjuntos.Entities
{
     class Student
    {
        public int NumberCard { get; set; }

        public override int GetHashCode()
        {
            return NumberCard.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return NumberCard.Equals(other.NumberCard);
        }

        

    }
}
