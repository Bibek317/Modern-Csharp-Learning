namespace Csharp.Mathnet;

//using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
//using MathNet.Numerics.Statistics;
//using MathNet.Numerics.Distributions;

public static class Mathnet{
    
    public static Matrix<double> SimpleMatrix(){
        return Matrix<double>.Build.DenseOfArray(
            new double[,] {
                {1,2,3,4,5},
                {6,7,8,9,10}
            }
        );
    }
}