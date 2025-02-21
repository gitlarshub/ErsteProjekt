using System;

public class Program
{
    public static (int sum, int carry) HalbAddierer(int a, int b)
    {
        int sum = a ^ b;
        int carry = a & b;
        return (sum, carry);
    }

    public static (int sum, int carry) VollAddierer(int a, int b, int carryIn)
    {
        var halfAdder1 = HalbAddierer(a, b);
        var halfAdder2 = HalbAddierer(halfAdder1.sum, carryIn);

        int sum = halfAdder2.sum;
        int carry = (halfAdder1.carry | halfAdder2.carry);

        return (sum, carry);
    }

    public static (int result, int carryOut) VierBitAddierer(int a, int b)
    {
        int carryIn = 0;
        int result = 0;

        for (int i = 0; i < 4; i++)
        {
            int bitA = (a >> i) & 1;
            int bitB = (b >> i) & 1;

            var fullAdder = VollAddierer(bitA, bitB, carryIn);
            result |= (fullAdder.sum << i);

            carryIn = fullAdder.carry;
        }

        return (result, carryIn);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Gib die erste 4-Bit Zahl ein (z.B. 1101):");
        string inputA = Console.ReadLine();
        int a = Convert.ToInt32(inputA, 2);

        Console.WriteLine("Gib die zweite 4-Bit Zahl ein (z.B. 1011):");
        string inputB = Console.ReadLine();
        int b = Convert.ToInt32(inputB, 2);

        var (result, carryOut) = VierBitAddierer(a, b);

        Console.WriteLine($"Ergebnis: {Convert.ToString(result, 2).PadLeft(4, '0')} (binär), Übertrag: {carryOut}");
        Console.WriteLine($"Ergebnis in Dezimal: {result + (carryOut << 4)}");
    }
}