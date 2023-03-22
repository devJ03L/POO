namespace POO.Interfaces
{
    public abstract class Criterio<T>
    {
        public abstract int comparar(T a, T b);
    }
}