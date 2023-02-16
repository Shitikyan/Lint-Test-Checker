// <copyright file="UnitTest1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

/// <summary>
/// Gets or sets the name of the sample.
/// </summary>
namespace TestProject
{
    /// <summary>
    /// Gets or sets the name of the sample.
    /// </summary>
    public class UnitTest1
    {
        /// <summary>
        /// Gets or sets the name of the sample.
        /// </summary>
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        /// <summary>
        /// Gets or sets the name of the sample.
        /// </summary>
        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 3));
        }

        /// <summary>
        /// Gets or sets the name of the sample.
        /// </summary>
        private static int Add(int x, int y)
        {
            return x + y;
        }
    }
}