
public class Solution{

public 

int[] TopKFrequent(int[] nums, int k)
{
    Array.Sort(nums);
    List<int> result = new List<int>();
    Dictionary<int, int> freqHash = new Dictionary<int, int>();
    Dictionary<int, List<int>> bucketHash = new Dictionary<int, List<int>>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (freqHash.ContainsKey(nums[i]))
        {
            freqHash[nums[i]]++;
        }
        else
        {
            freqHash.Add(nums[i], 1);
        }
    }
    foreach (KeyValuePair<int, int> kvp in freqHash)
    {
        if(!bucketHash.ContainsKey(kvp.Value))
        {
            bucketHash.Add(kvp.Value, new List<int>());
        }
        bucketHash[kvp.Value].Add(kvp.Key);
    }
    //List< List<int>> trail = new List< List<int>>();

    for (int i = nums.Length; result.Count != k; i--)
    {
        //Console.WriteLine(i);
        if (bucketHash.ContainsKey(i+1))
        {
            //Console.WriteLine("current step bucketHash: " + string.Join(", ", bucketHash[i+1]));
            //trail.Add(bucketHash[i+1]);
            foreach (int num in bucketHash[i+1])
            {
                result.Add(num);
                if (result.Count == k)
                {
                    return result.ToArray();
                }
            }
        }
        else continue;
        //trail.Add( new());
    }

    //Console.WriteLine("current step trail: " + string.Join(", ", trail.Select(x => string.Join(',', x))));
    //int iter = trail.Count - 1;
    //while ( k > result.Count)
    //{
    //    foreach (int num in trail[iter])
    //    {
    //        result.Add(num);
    //        if (result.Count == k)
    //        {
    //            return result.ToArray();
    //        }
    //    }
    //    iter--;
    //    Console.WriteLine("res current step: " + string.Join(", ", result));
    //}

    return result.ToArray();
}



}