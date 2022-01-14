using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using nl.Commen.Interfaces;
using nl.Commen.Models;
using nl.Logic;
using nl.Tests.FakeData;

namespace nl.Tests.UnitTests
{
    public class AnswerServiceTests
    {
        private readonly AnswerService _answerService;

        public AnswerServiceTests()
        {
            _answerService = new AnswerService(new FakeAnswerData());
        }

        [Test]
        public void TestGetClosestComponent_True()
        {
            List<Component> components = new List<Component>
            {
                new Component("3", ComponentTypes.Processor.ToString(), 3),
                new Component("5", ComponentTypes.Processor.ToString(), 5),
                new Component("7", ComponentTypes.Processor.ToString(), 7)
            };
            Component component = _answerService.GetClosestComponent(5, components, ComponentTypes.Processor);
            
            Assert.True(component.Name == "5");
        }
        
        [Test]
        public void TestGetClosestComponent_False()
        {
            List<Component> components = new List<Component>
            {
                new Component("3", ComponentTypes.Processor.ToString(), 3),
                new Component("5", ComponentTypes.Processor.ToString(), 5),
                new Component("7", ComponentTypes.Processor.ToString(), 7)
            };
            Component component = _answerService.GetClosestComponent(5, components, ComponentTypes.Processor);
            
            Assert.False(component.Name == "3");
        }

        [Test]
        public void TestGetProcessors_True()
        {
            List<Component> components = new List<Component>
            {
                new Component("3", ComponentTypes.Processor.ToString(), 3),
                new Component("2060/3050-2070/3060", ComponentTypes.GraphicsCard.ToString(), 5),
                new Component("256gb", ComponentTypes.Storage.ToString(), 2),
                new Component("3", ComponentTypes.Processor.ToString(), 7)
            };
            List<Component> processorComponents = _answerService.GetProcessors(components);
            
            Assert.True(processorComponents.Count == 2);
        }
        
        [Test]
        public void TestGetProcessors_False()
        {
            List<Component> components = new List<Component>
            {
                new Component("3", ComponentTypes.Processor.ToString(), 3),
                new Component("2060/3050-2070/3060", ComponentTypes.GraphicsCard.ToString(), 5),
                new Component("256gb", ComponentTypes.Storage.ToString(), 2),
                new Component("15'6", ComponentTypes.ScreenSize.ToString(), 7)
            };
            List<Component> processorComponents = _answerService.GetProcessors(components);
            
            Assert.True(processorComponents.Count != 2);
        }
    }
}