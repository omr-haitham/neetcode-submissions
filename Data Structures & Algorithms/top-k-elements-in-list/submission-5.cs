
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
    List< List<int>> trail = new List< List<int>>();
    for (int i = 0; i < nums.Length; i++)
    {
        trail.Add(new List<int>());
    }
    foreach (KeyValuePair<int, List<int>> kvp in bucketHash)
    {
        
        if (trail[kvp.Key-1] == null)
        {
            trail[kvp.Key-1]= kvp.Value;
        }
        else
        {
            trail[kvp.Key-1].AddRange(kvp.Value);
        }
       
    }

    
    int iter = trail.Count - 1;
    while ( k > result.Count)
    {
        foreach (int num in trail[iter])
        {
            result.Add(num);
            if (result.Count == k)
            {
                return result.ToArray();
            }
        }
        iter--;
        
    }

    return result.ToArray();
}



}