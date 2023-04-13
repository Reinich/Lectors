/*
 * комментарии, когда их много
 */
// еще вид комментария
public class Ex_1 {
    public static void main(String[] args) { // мэйн принимает на вход массив строк, это как данность
        System.out.println("bye");
        
        String s = null;
        System.out.println(s);

        int salary = 123456;
        System.out.println(salary);
        
        float e = 2.7f; // f - показывает что именно эта часть и есть float
        System.out.println(e);

        // int[] a = {2, 4, 5, 6, 1};
        // System.out.println(a);

        var u = 147; // variable - неявная типизация
        System.out.println(u);

        String qw = "qwerty";
        System.out.println(qw.charAt(1)); // обращение по индексу
    
        int a = 123;
        System.out.println(a++); // инкремент работает ПОСЛЕ выполнения основной задачи - вывод на экран
        System.out.println(a);
        System.out.println(++a); // но также можно написать и до вывода, и тогда все работает
        
        System.out.println(a-- - --a); // 2
        System.out.println(--a - a--); // 0
        System.out.println(a);
        
        int y = 5;
        int x = 2;
        System.out.println(y | x);
        // 101
        // 010
        // 111 - вывод 7
        System.out.println(y & x);
        // 101
        // 010
        // 000 - вывод 0

        String d = "qwe1";
        boolean b = d.length() >= 5 && d.charAt(4) == '1'; // из-за того, что это быстрое сравнение, он не берет в расчет вторую часть значения и ошибки не будет
        // boolean b1 = d.length() >= 5 & d.charAt(4) == '1'; // а обычное сравнение проверит ОБЕ части и может вывалить ошибки
        System.out.println(b);
        // System.out.println(b1);
        // операция || и | работает также

        int[] arr = new int[10];
        System.out.println(arr.length); // 10
        arr = new int[] {1, 2, 3, 4, 5}; // так делается статичное заполнение

        int[] matrix[] = new int[3][5]; // int[][] - тоже многомерный массив, массив массивов
        for (int[] i : matrix) {
            for (int j : i) {
                System.out.printf("%d ", j);
            }
            System.out.println();
        }

        System.out.println();
        for (int m = 0; m < matrix.length; m++) { // второй способ вывода массива
            for (int n = 0; n < matrix[m].length; n++) {
                System.out.printf("%d ", matrix[m][n]);
            }
            System.out.println();
        }

        int t = 1, v =2;
        int min = t < v ? t : v; // тернарный оператор
        System.out.println(min);


    

    }
}
