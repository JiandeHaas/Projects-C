namespace Simple_ATM_Software;

public class ATM
{
    public bool checkCreditcard(string creditcard)
    {
        var validate = creditcard.ToCharArray();

        var sum = 0;
        var isSecond = false;

        for (var i = validate.Length - 1; i >= 0; i--)
        {
            var number = creditcard[i] - '0';

            if (isSecond)
                number = number * 2;

            sum += number / 10;
            sum += number % 10;


            isSecond = !isSecond;
        }

        return sum % 10 == 0;
    }
}