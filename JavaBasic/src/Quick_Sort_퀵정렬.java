import java.io.*;

public class Quick_Sort_퀵정렬 {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        String[] temp = br.readLine().split(" ");
        int[]data = new int[temp.length];
        for(int i=0; i<data.length; i++){
            data[i] = Integer.parseInt(temp[i]);
        }

        quickSort(data, 0, data.length-1);

        for(int num : data){
            bw.write(String.valueOf(num + " "));
        }
        bw.flush();
        bw.close();
    }
    public static void quickSort(int[] arr, int start, int end){
        // 탈출조건 -> start가 end보다 크거나 작을 떄
        if(start >= end)
            return;

        int pivot = start;
        int left = start + 1;
        int right = end;
        // 오른쪽으로
        while(left <= end && arr[left] <= arr[pivot])
            left++;

        // 왼쪽으로
        while(right > start && arr[right] >= arr[pivot])
            right--;

        // 엇갈린 경우 Pivot값 교체
        if(left > right)
            Swap(arr, right, pivot);

        // 엇갈리지 않은 경우 좌우 교체
        else
            Swap(arr, left, right);

        // 왼쪽 탐색
        quickSort(arr, start, right-1);
        // 오른쪽 탐색
        quickSort(arr, right+1, end);
    }

    public static void Swap(int[] arr, int a, int b){
        int temp = arr[a];
        arr[a] = arr[b];
        arr[b] = temp;
    }
}
