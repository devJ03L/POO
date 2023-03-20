namespace POO.Colecciones
{
    public class TestMiColeccion
    {
        public static void Ejecutar()
        {
            string[] arr = { "Sultan", "Rocky", "Randy" };
            MiColeccion<string> mc = new MiColeccion<string>(5);

            Array.ForEach(arr, x => mc.insertar(x, 0));

            string aux;

            for (int i = 0; i < mc.cantidad(); i++)
            {
                aux = mc.obtener(i);
                Console.WriteLine(aux + " - " + aux.Length + " caracteres");
            }
        }
    }
}