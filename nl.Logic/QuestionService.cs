using System;
using System.Collections.Generic;
using nl.Commen.Interfaces;
using nl.Commen.Models;
using nl.Commen.Models.ApiModels;

namespace nl.Logic
{
    public class QuestionService
    {
        private readonly IQuestionData _questionData;

        public QuestionService(IQuestionData questionData)
        {
            _questionData = questionData;
        }

        public ApiQuestion GetFirstQuestion(string token)
        {
            //Gets the first question
            Question question = _questionData.GetQuestion(1);
            
            //Gets answers for the first question
            List<Answer> answers = GetAnswers(1);
            
            //Return the question
            return new ApiQuestion(question.Id, question.Text, answers);
        }

        public ApiQuestion GetNextQuestion(string answerId, string token)
        {
            //Save the answer with the user's token
            _questionData.SaveSingleAnswer(token, answerId);
            Answer answer = _questionData.GetAnswer(answerId);
            
            //If answer question id is the last return the results
            if (answer.QuestionId == 9)
            {
                //Results results = new Results(token, SingleToUserAnswerList(_questionData.GetUserAnswers(token)));
                UserAnswer userAnswer = new UserAnswer(token, SingleToUserAnswerList(_questionData.GetUserAnswersTemps(token)));
                _questionData.SaveUserAnswers(userAnswer);
                return new ApiQuestion();
            }
            else
            {
                //Get question by answer question id
                Question question = _questionData.GetQuestion(answer.NextQuestionId);
                
                //Get answers based on question id
                List<Answer> answers = GetAnswers(question.Id);
                
                //Return the quesion
                return new ApiQuestion(question.Id, question.Text, answers);
            }
        }

        

        private List<SingleAnswer> SingleToUserAnswerList(List<SingleAnswerTemp> singleAnswerTemps)
        {
            List<SingleAnswer> singleAnswers = new List<SingleAnswer>();
            foreach (var a in singleAnswerTemps)
            {
                singleAnswers.Add(new SingleAnswer(a.AnswerId, a.Token));
            }

            return singleAnswers;
        }
        
        private List<Answer> GetAnswers(int questionId)
        {
            return _questionData.GetAnswers(questionId);
        }
    }
}