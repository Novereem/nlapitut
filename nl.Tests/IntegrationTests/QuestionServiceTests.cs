using nl.Commen.Models;
using nl.Commen.Models.ApiModels;
using nl.Logic;
using nl.Tests.FakeData;
using NUnit.Framework;

namespace nl.Tests.UnitTests
{
    public class QuestionServiceTests
    {
        private readonly QuestionService _questionService;

        public QuestionServiceTests()
        {
            _questionService = new QuestionService(new FakeQuestionData());
        }

        [Test]
        public void TestGetFirstQuestion_True()
        {
            ApiQuestion apiQuestion1 = _questionService.GetFirstQuestion("a");
            
            Assert.True(apiQuestion1.Id == 1 && 
                        apiQuestion1.Text == "First Question" && 
                        apiQuestion1.Answers[0].OrderId == 1 &&
                        apiQuestion1.Answers[0].Text == "First Option" &&
                        apiQuestion1.Answers[3].OrderId == 4 &&
                        apiQuestion1.Answers[3].Text == "Fourth Option");
        }
        
        [Test]
        public void TestGetFirstQuestion_False()
        {
            ApiQuestion apiQuestion = _questionService.GetFirstQuestion("a");
            
            Assert.False(apiQuestion.Id == 2 && 
                        apiQuestion.Text == "First Question" && 
                        apiQuestion.Answers[0].OrderId == 1 &&
                        apiQuestion.Answers[0].Text == "First Option" &&
                        apiQuestion.Answers[3].OrderId == 4 &&
                        apiQuestion.Answers[3].Text == "Fourth Option");
        }

        [Test]
        public void TestGetNextQuestion_True()
        {
            string answerId = "First Option";
            string token = "a";
            ApiQuestion apiQuestion = _questionService.GetNextQuestion(answerId, token);
            
            Assert.True(apiQuestion.Id == 2 &&
                        apiQuestion.Text == "Second Question" &&
                        apiQuestion.Answers[0].OrderId == 1 &&
                        apiQuestion.Answers[0].Text == "First Option" &&
                        apiQuestion.Answers[3].OrderId == 4 &&
                        apiQuestion.Answers[3].Text == "Fourth Option");
        }
        
        [Test]
        public void TestGetNextQuestion_False()
        {
            string answerId = "First Option";
            string token = "a";
            ApiQuestion apiQuestion = _questionService.GetNextQuestion(answerId, token);
            
            Assert.True(apiQuestion.Id == 2 &&
                        apiQuestion.Text == "Second Question" &&
                        apiQuestion.Answers[0].OrderId == 1 &&
                        apiQuestion.Answers[0].Text == "First Option" &&
                        apiQuestion.Answers[3].OrderId == 4 &&
                        apiQuestion.Answers[3].Text == "Fourth Option");
        }
    }
}