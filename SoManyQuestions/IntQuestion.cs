namespace SoManyQuestions
{
    internal class IntQuestion
    {
        private string _question;
        private int _min;
        private int _max;

        public IntQuestion(string question, int min, int max)
        {
            _question = question;
            _min = min;
            _max = max;
        }

        public void Run()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(_question + "? ");
                var answer = Console.ReadLine().Trim();
                isValid = int.TryParse(answer, out int answer2) && answer2 >= _min && answer2 <= _max;
            }
        }
    }
}
