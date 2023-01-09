public static int[] CreatePrint(int size) {
    if (size < 0) {
        System.out.println("Size cannot be negative");
        return null;
    }
    if (size == 0) {
        System.out.println();
        return new int[0];
    }
    int[] array = new int[size];
    for (int i = 0; i < size; i++) {
        array[i] = i;
        System.out.print(array[i] + " ");
    }
    System.out.println();
    return array;
}
