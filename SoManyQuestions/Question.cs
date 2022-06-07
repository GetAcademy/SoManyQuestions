namespace SoManyQuestions
{
    internal abstract class Question
    {
        private string _question;

        public Question(string question)
        {
            _question = question;
        }

        /*
         * virtual = kan overrides
         * abstract = må overrides
         */
        public void Run()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(_question + "? ");
                var answer = Console.ReadLine().Trim();
                isValid = IsValid(answer);
            }
        }

        protected abstract bool IsValid(string answer);
    }
}
