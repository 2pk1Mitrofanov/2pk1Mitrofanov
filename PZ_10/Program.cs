namespace PZ_10
{
    internal class Program
    {
        static void Main()
        {
            string text = "Los pinguinos me la van a mascar kawasaki.";

            string NormalText = Normal(text);

            Console.WriteLine(NormalText);
        }
        static string Normal(string text)
        {
            string [] offers = text.Split('.');
            for (int i = 0; i < offers.Length; i++)
            {
                offers[i] = offers[i].Trim().ToLower();

                if (!string.IsNullOrWhiteSpace(offers[i]){
                    offers[i] = char.ToUpper(offers[i][0]) + offers[i].Substring(1);
                }
            }
            string NormalText = string.Join(" ", offers) + ".";

            return NormalText;
        }
    }
}
