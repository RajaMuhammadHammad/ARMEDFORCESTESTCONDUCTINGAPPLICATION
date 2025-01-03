using DataAccesslayer;
using DataAccessLayer;
using System.Collections.Generic;

namespace Businesslogiclayer
{
    public class AcademicsQuestionbll
    {
        private AccademicsDal questionRepository;

        public AcademicsQuestionbll()
        {
            questionRepository = new AccademicsDal();
        }

        public List<string> GetQuestions()
        {
            return questionRepository.GetQuestions();
        }

        public List<string> GetOption1()
        {
            return questionRepository.GetOption1();
        }

        public List<string> GetOption2()
        {
            return questionRepository.GetOption2();
        }

        public List<string> GetOption3()
        {
            return questionRepository.GetOption3();
        }

        public List<string> GetOption4()
        {
            return questionRepository.GetOption4();
        }

        public List<string> GetCorrectAnswers()
        {
            return questionRepository.GetCorrectAnswer();
        }
    }
}
