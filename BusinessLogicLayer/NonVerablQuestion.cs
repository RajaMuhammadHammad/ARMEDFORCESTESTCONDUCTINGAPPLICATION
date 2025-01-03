using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using DataAccesslayer;

namespace Businesslogiclayer
{
    public class NonVerablQuestion
    {

private Nonverbaldal questionRepository;


public NonVerablQuestion()
{
    questionRepository = new Nonverbaldal();
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
