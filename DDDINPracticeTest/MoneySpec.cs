using DDDInPractLogic;
using FluentAssertions;
using System;
using Xunit;

namespace DDDINPracticeTest
{
    public class MoneySpec
    {
        [Fact]
        public void Sum_of_two_monies_produce_correct_result()
        {
            Money money1 = new Money(1, 2, 3, 4, 5, 6);
            Money money2 = new Money(1, 2, 3, 4, 5, 6);

            Money sum = money1 + money2;

            //Assert.Equal(2, sum.OneCentCount);.. cos we are using Fluent Assertions
            sum.OneCentCount.Should().Be(2);
        }
    }
}
