using System;
using Xunit;

namespace Assignment2.Tests
{
    public class ImmutableStudentTest
    {
        
        [Fact]
        public void StudentToString()
        {
            ImmutableStudent student = new ImmutableStudent(113, "Danny", "Devito", 
                new DateTime(2020, 8, 1), 
                new DateTime(2024, 6, 30), 
                new DateTime(2024, 6, 25));
            
            string expected = "ImmutableStudent { id = 113, givenName = Danny, surname = Devito, status = Active, startDate = 01/08/2020 00:00:00, endDate = 30/06/2024 00:00:00, graduationDate = 25/06/2024 00:00:00 }";
            Assert.Equal(expected, student.ToString());
        }

        [Fact]
        public void StatusNew()
        {
            ImmutableStudent student = new ImmutableStudent(113, "Danny", "Devito", 
                new DateTime(2045, 8, 1), 
                new DateTime(2049, 4, 30), 
                null);

            Status expected = Status.New;
            Assert.Equal(expected, student.status);
        }

        [Fact]
        public void StatusActive()
        {
            ImmutableStudent student = new ImmutableStudent(113, "Danny", "Devito", 
                new DateTime(2020, 8, 1), 
                new DateTime(2024, 6, 30), 
                new DateTime(2024, 6, 25));

            Status expected = Status.Active;
            Assert.Equal(expected, student.status);
        }

        [Fact]
        public void StatusDropout()
        {
            ImmutableStudent student = new ImmutableStudent(113, "Danny", "Devito", 
                new DateTime(2019, 8, 1), 
                new DateTime(2020, 4, 30), 
                null);

            Status expected = Status.Dropout;
            Assert.Equal(expected, student.status);
        }

        [Fact]
        public void StatusGraduated()
        {
            ImmutableStudent student = new ImmutableStudent(113, "Danny", "Devito", 
                new DateTime(2019, 8, 1), 
                new DateTime(2020, 6, 30), 
                new DateTime(2020, 6, 30));

            Status expected = Status.Graduated;
            Assert.Equal(expected, student.status);
        }

        [Fact]
        public void IdenticalsAreEqual()
        {
            ImmutableStudent student = new ImmutableStudent(113, "Danny", "Devito", 
                new DateTime(2020, 8, 1), 
                new DateTime(2024, 6, 30), 
                new DateTime(2024, 6, 25));

            ImmutableStudent student2 = new ImmutableStudent(113, "Danny", "Devito", 
                new DateTime(2020, 8, 1), 
                new DateTime(2024, 6, 30), 
                new DateTime(2024, 6, 25));

            Assert.Equal(student, student2);
        }
    }
}