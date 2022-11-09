namespace LocalMethod;

public class MyClass
{
    public int Method(int x)
    {
        x = SquareLocal(x);
        x = CubeLocal(x);

        x = Tetra(x);

        return x;

        int SquareLocal(int x)
        {
            return x * x;
        }

        static int CubeLocal(int x)
        {
            return x * x * x;
        }
    }


    private int Tetra(int x)
    {
        return x * x * x * x;
    }
}
