using System.Collections.Generic;
using nl.Commen.Models;

namespace nl.Commen.Interfaces
{
    public interface IAnswerData
    {
        /*List<Laptop> GetLaptopByPrice(string price);
        List<Laptop> GetLaptopByUsage(string usage);*/
        UserAnswer GetUserAnswersByToken(string token);
        List<Answer> GetAllAnswers();
        List<Component> GetAllComponents();
    }
}