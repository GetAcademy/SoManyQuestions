namespace SoManyQuestions
{
    internal class StringQuestion
    {
        private string _question;

        public StringQuestion(string question)
        {
            _question = question;
        }

        public void Run()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(_question + "? ");
                var answer = Console.ReadLine().Trim();
                isValid = answer.Length > 0;
            }
        }
    }
}
