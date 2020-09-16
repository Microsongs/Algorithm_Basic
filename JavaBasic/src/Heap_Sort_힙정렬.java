import java.io.*;

public class Heap_Sort_힙정렬 {
    public static void main(String[] args) throws IOException{
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));

        // 입력
        String[] temp = br.readLine().split(" ");
        int[] heap = new int[temp.length];
        for(int i=0; i<heap.length; i++){
            heap[i] = Integer.parseInt(temp[i]);
        }
        heapSort(heap);
        for(int data : heap){
            //bw.write(String.valueOf(data));
            System.out.print(data + " " );
        }
    }
    // 최소힙
    static void heapSort(int[] heap){
        // 힙구조 생성
        // 트리를 최대 힙 구조로 변경
        for(int i=1; i<heap.length; i++){
            int child = i;
            do {
                int root = (child - 1) / 2;
                // 부모가 자식보다 클 경우 스왑
                if (heap[child] > heap[root])
                    Swap(heap, child, root);
                child = root;
            }while(child != 0);
        }

        // 생성된 힙 구조를 하나씩 정렬
        for(int i=heap.length-1; i>=0; i--){
            Swap(heap, 0, i);
            int root = 0;
            int child = 1;
            do{
                child = 2 * root + 1;
                // child가 i-1보다 작아야 오버플로우가 안됨
                // 왼쪽과 오른쪽 값 중 더 큰값을 child에 담는다.
                if (child < i - 1 && heap[child] < heap[child+1])
                    child++;
                // 루트값과 child값을 비교하여 스왑
                if(child < i && heap[root] < heap[child])
                    Swap(heap, root, child);
                root = child;
            }while(child < i);
        }
    }

    static void Swap(int[] heap, int a, int b){
        int temp = heap[a];
        heap[a] = heap[b];
        heap[b] = temp;
    }
}
