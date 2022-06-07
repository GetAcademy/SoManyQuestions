namespace SoManyQuestions
{
    internal class StringQuestion : Question
    {
        public StringQuestion(string question)
            : base(question)
        {
        }

        protected override bool IsValid(string answer)
        {
            return answer.Length > 0;
        }
    }
}
