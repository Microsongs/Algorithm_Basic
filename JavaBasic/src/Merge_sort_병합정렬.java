import java.io.*;

public class Merge_sort_병합정렬 {
    static int[] sorted;
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        // 데이터 삽입 과정
        String[] temp = br.readLine().split(" ");
        int[] data = new int[temp.length];
        sorted = new int[temp.length];
        for(int i=0; i<data.length; i++){
            data[i] = Integer.parseInt(temp[i]);
        }
        MergeSort(data, 0, data.length-1);
        for(int num : data){
           //bw.write(String.valueOf(num)+ " ");
            System.out.print(num + " " );
        }

    }
    public static void MergeSort(int[] arr, int front, int rear){
        if(front < rear){
            int middle = (front + rear) / 2;
            MergeSort(arr, front, middle);
            MergeSort(arr, middle+1, rear);
            Merge(arr, front, middle, rear);
        }
    }
    public static void Merge(int[] arr, int front ,int middle, int rear){
        // front 배열의 첫 인자
        int i = front;
        // rear 배열의 첫 인자
        int j = middle + 1;
        // merge 배열의 첫 인자
        int k = front;
        // 두 수를 비교하여 sorted에 삽입
        while(i <= middle && j <= rear){
            if(arr[i] < arr[j])
                sorted[k++] = arr[i++];
            else
                sorted[k++] = arr[j++];
        }
        // i > middle이면 j를 삽입
        if(i > middle){
            for(int t = j; t<=rear; t++){
                sorted[k++] = arr[t];
            }
        }
        // j > rear이면 i를 삽입
        else{
            for(int t = i; t<=middle; t++){
                sorted[k++] = arr[t];
            }
        }
        // 정렬된 배열의 move
        for(int t=front; t<=rear; t++){
            arr[t] = sorted[t];
        }
    }
}
