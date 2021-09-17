using System;
using Xunit;

namespace Assignment2.Tests
{
    public class StudentTest
    {
        [Fact]
        public void ToStringTest()
        {
            Student student = new Student(113, "Danny", "Devito", 
                new DateTime(2020, 8, 1), 
                new DateTime(2024, 6, 30), 
                new DateTime(2024, 6, 25));
            
            string expected = "113, Danny Devito, active, "
            Assert[]
        }
    }
}