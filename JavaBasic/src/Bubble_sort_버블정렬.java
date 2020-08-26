import java.io.*;

public class Bubble_sort_버블정렬 {
    public static void main(String[] args) throws IOException{
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));

        String[] temp = br.readLine().split(" ");
        int[] data = new int[temp.length];
        for(int i=0; i<data.length; i++){
            data[i] = Integer.parseInt(temp[i]);
        }
        for(int i=0; i<data.length; i++){
            for(int j=0; j<data.length-1 -i; j++){
                if(data[j] > data[j+1]){
                    swap(data, j, j+1);
                }
            }
        }
        for(int i=0; i<data.length; i++){
            bw.write(String.valueOf(data[i]+ " "));
        }
        bw.flush();
        bw.close();
    }
    public static void swap(int[] arr, int a, int b){
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}
