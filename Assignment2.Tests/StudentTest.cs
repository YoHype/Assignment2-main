using System;
using Xunit;

namespace Assignment2.Tests
{
    public class StudentTest
    {
        [Fact]
        public void StudentToString()
        {
            Student student = new Student(113, "Danny", "Devito", 
                new DateTime(2020, 8, 1), 
                new DateTime(2024, 6, 30), 
                new DateTime(2024, 6, 25));
            
            string expected = "113, Danny Devito, Active, 01 Aug 2020 - 30 Jun 2024, Graduation: 25 Jun 2024";
            Assert.Equal(expected, student.ToString());
        }

        [Fact]
        public void StatusNew()
        {
            Student student = new Student(113, "Danny", "Devito", 
                new DateTime(2045, 8, 1), 
                new DateTime(2049, 4, 30), 
                null);

            Status expected = Status.New;
            Assert.Equal(expected, student.status);
        }

        [Fact]
        public void StatusActive()
        {
            Student student = new Student(113, "Danny", "Devito", 
                new DateTime(2020, 8, 1), 
                new DateTime(2024, 6, 30), 
                new DateTime(2024, 6, 25));

            Status expected = Status.Active;
            Assert.Equal(expected, student.status);
        }

        [Fact]
        public void StatusDropout()
        {
            Student student = new Student(113, "Danny", "Devito", 
                new DateTime(2019, 8, 1), 
                new DateTime(2020, 4, 30), 
                null);

            Status expected = Status.Dropout;
            Assert.Equal(expected, student.status);
        }

        [Fact]
        public void StatusGraduated()
        {
            Student student = new Student(113, "Danny", "Devito", 
                new DateTime(2019, 8, 1), 
                new DateTime(2020, 6, 30), 
                new DateTime(2020, 6, 30));

            Status expected = Status.Graduated;
            Assert.Equal(expected, student.status);
        }
    }
}