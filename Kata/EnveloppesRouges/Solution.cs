namespace EnveloppesRouges;

internal class Solution
{
    internal static int LuckyMoney(int money, int giftees)
    {
        int result = 0;
        while(money > 0 && giftees > 0)
        {
            money = money - 8;
            giftees = giftees - 1;
            if (money == 4)
                break;
            result++;
        }

        return result;
    }
}
