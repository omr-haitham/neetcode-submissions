public class DynamicArray {
    int[] arr;
    int cap;
    int lastPos;
    public DynamicArray(int capacity) {
        arr = new int[capacity];
        cap = capacity;
        lastPos = -1;
    }
    public int Get(int i) {
        return arr[i];
    }

    public void Set(int i, int n) {
        arr[i]=n;
    }

    public void PushBack(int n) {
        if(lastPos == cap-1){
            Resize();
        }
        lastPos++;
        arr[lastPos] = n;
    }
    public int PopBack() {
        lastPos= lastPos -1;
        return arr[1+lastPos];
    }
    private void Resize() {
        int[] tempArr = arr;
        arr = new int[cap*2];
        for(int i  =0; i<cap;i++){
            arr[i] = tempArr[i];
        }
        cap = cap*2;
    }
    public int GetSize() {
        return lastPos+1;
    }
    public int GetCapacity() {
        return cap;
    }
}
