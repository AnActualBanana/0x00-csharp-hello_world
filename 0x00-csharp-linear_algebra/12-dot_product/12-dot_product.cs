public class VectorMath {

  public static double DotProduct(double[] vector1, double[] vector2) {
    if (vector1.length != vector2.length || (vector1.length != 2 && vector1.length != 3)) {
      return -1;
    }
    
    double dotProduct = 0;
    for (int i = 0; i < vector1.length; i++) {
      dotProduct += vector1[i] * vector2[i];
    }
    
    return dotProduct;
  }

}
