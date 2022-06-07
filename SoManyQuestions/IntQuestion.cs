namespace SoManyQuestions
{
    internal class IntQuestion : Question
    {
        private int _min;
        private int _max;

        public IntQuestion(string question, int min, int max)
            : base(question)
        {
            _min = min;
            _max = max;
        }

        protected override bool IsValid(string answer)
        {
            return int.TryParse(answer, out int answer2) 
                && answer2 >= _min && answer2 <= _max;
        }
    }
}
