using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDInPractLogic
{
    public class Money : ValueObject<Money>
    {
        public int OneCentCount { get;  set; }
        public int TenCentCount { get;  set; }
        public int QuarterCount { get;  set; }
        public int OneRandCount { get;  set; }
        public int FiveRandCount { get;  set; }
        public int TwentyRandCount { get;  set; }

        public Money(
            int oneCentCount,
            int tenCentCount,
            int quarterCount,
            int oneRandCount,
            int fiveRandCount,
            int twentyRandCount)
        {
            OneCentCount = oneCentCount;
            TenCentCount = tenCentCount;
            QuarterCount = quarterCount;
            OneRandCount = oneRandCount;
            FiveRandCount = fiveRandCount;
            TwentyRandCount = twentyRandCount;
        }

        public static Money operator +(Money money1, Money money2)
        {
            Money sum = new Money(
                money1.OneCentCount + money2.OneCentCount,
                money1.TenCentCount + money2.TenCentCount,
                money1.QuarterCount + money2.QuarterCount,
                money1.OneRandCount + money2.OneRandCount,
                money1.FiveRandCount + money2.FiveRandCount,
                money1.TwentyRandCount + money2.TwentyRandCount);
            
            return sum;
        }

        protected override bool EqualsCore(Money other)
        {
            return
            OneCentCount == other.OneCentCount &&
            TenCentCount == other.TenCentCount &&
            QuarterCount == other.QuarterCount &&
            OneRandCount == other.OneRandCount &&
            FiveRandCount == other.FiveRandCount &&
            TwentyRandCount == other.TwentyRandCount;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                int hashCode = OneCentCount;
                hashCode = (hashCode * 396) ^ TenCentCount;
                hashCode = (hashCode * 396) ^ QuarterCount;
                hashCode = (hashCode * 396) ^ OneRandCount;
                hashCode = (hashCode * 396) ^ FiveRandCount;
                hashCode = (hashCode * 396) ^ TwentyRandCount;
                return hashCode;
            }
        }
    }
}
