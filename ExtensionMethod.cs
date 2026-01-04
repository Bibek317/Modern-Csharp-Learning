namespace Csharp.ExtensionMethod;

public static class ExtensionMethod{
    public static void PrintArray<T>(this T[] arr){
        
        Console.WriteLine(
            arr is null or {Length: 0}
            ? "The array is empty or null"
            : $"[{string.Join(", ", arr)}]"
        );
    }
}