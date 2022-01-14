using System;
using System.Collections.Generic;
using System.Linq;
using nl.Commen.Interfaces;
using nl.Commen.Models;

namespace nl.Logic
{
    public class AnswerService
    {
        private readonly IAnswerData _answerData;

        
        public AnswerService(IAnswerData answerData)
        {
            _answerData = answerData;
        }
        
        public object GetResults(string token)
        {
            UserAnswer userAnswer = _answerData.GetUserAnswersByToken(token);
            return GetLaptop(userAnswer);;
        }

        private Laptop GetLaptop(UserAnswer userAnswer)
        {
            int processor = 0;
            int storage = 0;
            int ram = 0;
            int graphicsCard = 0;
            int screenSize  = 0;
            Laptop laptop = new Laptop();

            List<Component> components = _answerData.GetAllComponents();
            
            List<Answer> possibleAnswers = _answerData.GetAllAnswers();
            
            foreach (var possibleAnswer in possibleAnswers)
            {
                foreach (var answer in userAnswer.Answers)
                {
                    //Price 1
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 1 && possibleAnswer.OrderId == 1)
                    {
                        processor += 1;
                        graphicsCard += 1;
                        storage += 2;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 1 && possibleAnswer.OrderId == 2)
                    {
                        processor += 1;
                        graphicsCard += 1;
                        storage += 3;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 1 && possibleAnswer.OrderId == 3)
                    {
                        processor += 2;
                        graphicsCard += 1;
                        storage += 4;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 1 && possibleAnswer.OrderId == 4)
                    {
                        processor += 2;
                        graphicsCard += 1;
                        storage += 4;
                    }
                    
                    //Usage 2
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 2 && possibleAnswer.OrderId == 1)
                    {
                        processor += 1;
                        storage += 1;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 2 && possibleAnswer.OrderId == 2)
                    {
                        processor += 1;
                        storage += 1;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 2 && possibleAnswer.OrderId == 3)
                    {
                        processor += 2;
                        graphicsCard += 2;
                        storage += 2;
                        ram += 6;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 2 && possibleAnswer.OrderId == 4)
                    {
                        processor += 2;
                        graphicsCard += 2;
                        storage += 2;
                        ram += 6;
                    }
                    
                    //Photo & Video 3
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 3 && possibleAnswer.OrderId == 1)
                    {
                        processor += 1;
                        graphicsCard += 2;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 3 && possibleAnswer.OrderId == 2)
                    {
                        processor += 2;
                        graphicsCard += 1;
                        storage += 2;
                    }
                    
                    //Game Genre 4
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 4 && possibleAnswer.OrderId == 1)
                    {
                        processor += 2;
                        graphicsCard += 2;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 4 && possibleAnswer.OrderId == 2)
                    {
                        processor += 2;
                        graphicsCard += 1;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 4 && possibleAnswer.OrderId == 3)
                    {
                        processor += 2;
                        graphicsCard += 2;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 4 && possibleAnswer.OrderId == 4)
                    {
                        processor += 3;
                        graphicsCard += 2;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 4 && possibleAnswer.OrderId == 5)
                    {
                        processor += 4;
                        graphicsCard += 3;
                    }
                    
                    //Actual Games 5
                    
                    //Professional photo and video editing 6
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 6 && possibleAnswer.OrderId == 1)
                    {
                        processor += 3;
                        graphicsCard += 3;
                        storage += 2;
                        ram += 3;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 6 && possibleAnswer.OrderId == 2)
                    {
                        processor += 1;
                        ram += 1;
                    }
                    
                    //Many programs open usually 7
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 7 && possibleAnswer.OrderId == 1)
                    {
                        ram += 3;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 7 && possibleAnswer.OrderId == 2)
                    {
                        ram += 5;
                        storage += 2;
                    }
                    
                    //More fps or graphics 8
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 8 && possibleAnswer.OrderId == 1)
                    {
                        processor += 1;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 8 && possibleAnswer.OrderId == 2)
                    {
                        graphicsCard += 3;
                    }
                    
                    //Screen size 9
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 9 && possibleAnswer.OrderId == 1)
                    {
                        screenSize = 1;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 9 && possibleAnswer.OrderId == 2)
                    {
                        screenSize = 2;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 9 && possibleAnswer.OrderId == 3)
                    {
                        screenSize = 3;
                    }
                    if (answer.AnswerId == possibleAnswer.Id.ToString() && possibleAnswer.QuestionId == 9 && possibleAnswer.OrderId == 4)
                    {
                        screenSize = 4;
                    }
                }
            }

            laptop.Id = Guid.NewGuid();
            laptop.Processor = GetClosestComponent(processor, components, ComponentTypes.Processor).Name;
            laptop.GraphicsCard = GetClosestComponent(graphicsCard, components, ComponentTypes.GraphicsCard).Name;
            laptop.Storage = GetClosestComponent(storage, components, ComponentTypes.Storage).Name;
            laptop.ScreenSize = GetClosestComponent(screenSize, components, ComponentTypes.ScreenSize).Name;
            laptop.Ram = GetClosestComponent(ram, components, ComponentTypes.Ram).Name;
            
            return laptop;
        }

        public Component GetClosestComponent(int componentNumber, List<Component> components, ComponentTypes componentTypes)
        {
            List<Component> ComponentList = new List<Component>();
            
            //Processor
            if (componentTypes == ComponentTypes.Processor)
            {
                foreach (var processor in GetProcessors(components))
                {
                    ComponentList.Add(processor);
                }
            }
            
            //GraphicsCard
            if (componentTypes == ComponentTypes.GraphicsCard)
            {
                foreach (var graphicsCard in GetGraphicsCard(components))
                {
                    ComponentList.Add(graphicsCard);
                }
            }
            
            //Storage
            if (componentTypes == ComponentTypes.Storage)
            {
                foreach (var storage in GetStorage(components))
                {
                    ComponentList.Add(storage);
                }
            }
            
            if (componentTypes == ComponentTypes.ScreenSize)
            {
                foreach (var screenSize in GetScreenSize(components))
                {
                    ComponentList.Add(screenSize);
                }
            }
            
            if (componentTypes == ComponentTypes.Ram)
            {
                foreach (var ram in GetRam(components))
                {
                    ComponentList.Add(ram);
                }
            }
            
            var component = ComponentList.OrderBy(x => Math.Abs(x.Score - componentNumber)).First();
            return component;
        }

        public List<Component> GetProcessors(List<Component> components)
        {
            return components.Where(x => x.Type == ComponentTypes.Processor.ToString()).ToList();
        }
        private List<Component> GetGraphicsCard(List<Component> components)
        {
            return components.Where(x => x.Type == ComponentTypes.GraphicsCard.ToString()).ToList();
        }
        private List<Component> GetStorage(List<Component> components)
        {
            return components.Where(x => x.Type == ComponentTypes.Storage.ToString()).ToList();
        }
        private List<Component> GetScreenSize(List<Component> components)
        {
            return components.Where(x => x.Type == ComponentTypes.ScreenSize.ToString()).ToList();
        }
        private List<Component> GetRam(List<Component> components)
        {
            return components.Where(x => x.Type == ComponentTypes.Ram.ToString()).ToList();
        }
    }
}