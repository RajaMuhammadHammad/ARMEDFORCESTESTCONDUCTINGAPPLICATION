using DataAccessLayer;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class bll
    {
        private QuestionRepository questionRepository;
         

        public bll()
        {
            questionRepository = new QuestionRepository();
           
        }

        public List<string> GetQuestions()
        {
            return questionRepository.GetQuestions();
        }
        public List<string> GetGetOption1()
        {
            return questionRepository.GetOption1();
        }

        public List<string> GetGetOption2()
        {
            return questionRepository.GetOption2();
        }

        public List<string> GetGetOption3()
        {
            return questionRepository.GetOption3();
        }

        public List<string> GetGetOption4()
        {
            return questionRepository.GetOption4();
        }
        public List<string> GetCorrectAnswers()
        {
            return questionRepository.GetCorrectAnswer();

        }
    }
}
