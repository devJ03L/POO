namespace POO.Interfaces
{
    public class CriterioInt : Criterio<int>
    {
        public override int comparar(int a, int b)
        {
            int residuoA = a % 2,
                residuoB = b % 2,
                diff = residuoA - residuoB;

            return diff > 0 ? 1 : diff < 0 ? -1 : 0;
        }
    }
}