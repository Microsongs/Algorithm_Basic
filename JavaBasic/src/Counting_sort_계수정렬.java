import java.io.*;

public class Counting_sort_계수정렬 {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));

        String[] temp = br.readLine().split(" ");
        int[] data = new int[temp.length];
        for(int i=0; i<data.length; i++){
            data[i] = Integer.parseInt(temp[i]);
        }

        // 최대값 100으로
        int max = 100;
        int[] count = new int[max];

        // 카운트 배열에 데이터값-1만큼 더해줌
        for(int i=0; i<data.length; i++){
            count[data[i]-1]++;
        }
        for(int i=0; i<data.length; i++){
            if(count[i] != 0){
                for(int j=0; j<count[i]; j++)
                    System.out.print(i+1 + " ");
            }
        }
    }
}
