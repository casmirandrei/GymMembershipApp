namespace Cv9Gym_ManagementApp.Helpers
{
    public sealed class Utils
    {
        public static int CalculateMembership(int numberOfMonths)
        {
            //TODO: Validate against negative Periods - on client / here

            int bonusDays = 7;
            int monthlySubscriptionPeriod = 30;
            
           
                if (numberOfMonths < 2)
            {
                return monthlySubscriptionPeriod;
            }

            return (numberOfMonths * monthlySubscriptionPeriod) + (numberOfMonths * bonusDays);
        }

    }
}
