import java.util.Scanner;
public class Ex_2 {
    public static void main(String[] args) {
        Scanner iScanner = new Scanner(System.in);
        System.out.printf("name: ");
        String name = iScanner.nextLine();
        System.out.printf("Привет, %s!\n", name);
        
        // Scanner iScanner = new Scanner(System.in);
        System.out.printf("int a: ");
        boolean flag = iScanner.hasNextInt(); // проверка на правильность типа данных
        System.out.println(flag);
        int x = iScanner.nextInt();
        System.out.printf("double a: ");
        double y = iScanner.nextDouble();
        System.out.printf("%d + %.3f = %.3f\n", x, y, x + y);
        
        System.out.println("зачение 1 или 2: ");
        var value = iScanner.nextInt();
        int month = value;
        String text = "";
        switch (month){
            case 1: text = "Autumn";
                break;
            case 2: // когда нужно несколько вариантов с одним выводом
            case 3:
            case 4:
                text = "Spring";
                break;
            default:
                text = "mistake";
                break;
        }
        System.out.println(text);
        


        iScanner.close();
        // iScanner2.close();



    }
}
