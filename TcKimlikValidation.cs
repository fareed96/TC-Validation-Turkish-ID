namespace TCValidation
{
    public class TcKimlikValidation
    {
        public bool IsValid(object value)
        {
            if (value == null)
                return false;

            var tc = value.ToString();

            if (tc.Length != 11)
                return false;

            if (!tc.All(char.IsDigit))
                return false;

            if (tc[0] == '0')
                return false;

            int[] numbers = tc.Select(ch => ch - '0').ToArray();

            int n1 = numbers[0];
            int n2 = numbers[1];
            int n3 = numbers[2];
            int n4 = numbers[3];
            int n5 = numbers[4];
            int n6 = numbers[5];
            int n7 = numbers[6];
            int n8 = numbers[7];
            int n9 = numbers[8];
            int n10 = numbers[9];
            int n11 = numbers[10];

            if (((n1 + n3 + n5 + n7 + n9) * 7 - (n2 + n4 + n6 + n8)) % 10 != n10)
                return false;

            if ((n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10) % 10 != n11)
                return false;

            return true;
        }
    }
}