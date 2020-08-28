import java.io.*;

public class Insertion_Sort_삽입정렬 {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        String[] temp = br.readLine().split(" ");
        int[] data = new int[temp.length];
        for(int i=0; i<data.length; i++){
            data[i] = Integer.parseInt(temp[i]);
        }
        for(int i=0; i<data.length-1; i++){
            int j = i;
            while(data[j] > data[j+1]){
                int tmp = data[j];
                data[j] = data[j+1];
                data[j+1] = tmp;
                j--;
                if(j < 0)
                    break;
            }
        }
        for(int i=0; i<data.length; i++){
            bw.write(String.valueOf(data[i]) + " ");
        }
        bw.flush();
        bw.close();
    }
}
