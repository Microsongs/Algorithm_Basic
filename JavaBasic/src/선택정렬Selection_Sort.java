import java.io.*;

public class 선택정렬Selection_Sort {
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        // 입력
        System.out.print("데이터 입력 : ");
        String[] temp = br.readLine().split(" ");
        int[] data = new int[temp.length];
        for(int i=0; i<temp.length;i++){
            data[i] = Integer.parseInt(temp[i]);
        }

        // Selection Sort
        for(int i=0; i<data.length; i++){
            int min = 2147483647;
            int index = 0;
            for(int j=i; j<data.length; j++){
                if(min > data[j]){
                    min = data[j];
                    index = j;
                }
            }
            Swap(data,i,index);
        }
        // print
        for(int num : data){
            bw.write(String.valueOf(num + " "));
        }
        bw.flush();
        bw.close();
    }
    public static void Swap(int[] data, int i, int j){
        int temp = data[i];
        data[i] = data[j];
        data[j] = temp;
    }
}
