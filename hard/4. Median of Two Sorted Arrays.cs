public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int totalLength=nums1.Length+nums2.Length;
        int[] allnums=new int[totalLength];
        int medianIndexLeft=0;
        int medianIndexRight=0;
        if(totalLength%2==0)
        {
            medianIndexLeft=totalLength/2-1;
            medianIndexRight=totalLength/2;
        }
        else
        {
            medianIndexLeft=totalLength/2;
            medianIndexRight=totalLength/2;
        }
        int idx1=0;
        int idx2=0;
        while(idx1<nums1.Length || idx2<nums2.Length)
        {
            if(idx1+idx2-1==medianIndexRight)
                return double.Parse((allnums[medianIndexLeft]+allnums[medianIndexRight]).ToString())/2;
            else
            {
                if(idx1>=nums1.Length)
                {
                    allnums[idx1+idx2]=nums2[idx2];
                    idx2++;
                }
                else if(idx2>=nums2.Length)
                {
                    allnums[idx1+idx2]=nums1[idx1];
                    idx1++;
                }
                else if(nums1[idx1]<=nums2[idx2])
                {
                    allnums[idx1+idx2]=nums1[idx1];
                    idx1++;
                }
                else
                {
                    allnums[idx1+idx2]=nums2[idx2];
                    idx2++;
                }
            }
        }
        if(idx1+idx2-1==medianIndexRight)
            return double.Parse((allnums[medianIndexLeft]+allnums[medianIndexRight]).ToString())/2;
        return 0;
    }
}