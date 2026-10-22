public class Solution
{
   public int[] TopKFrequent(int[] nums, int k)
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
        List<KeyValuePair<int, List<int>>> trail = new List<KeyValuePair<int, List<int>>>();

        foreach (KeyValuePair<int, List<int>> kvp in bucketHash)
        {
            for(int i=0; i<trail.Count; i++)
            {
                if (trail[i].Key < kvp.Key)
                {
                    trail.Insert(i,kvp);
                    break;
                }
            }
            if (!trail.Contains(kvp))
            {
                trail.Add(kvp);
            }
        }

        if (trail.Count > k)
        {
            trail.RemoveRange(k, trail.Count - k);
        }
        foreach (KeyValuePair<int, List<int>> kvp in trail)
        {
            foreach (int num in kvp.Value)
            {
                result.Add(num);
                if (result.Count == k)
                {
                    return result.ToArray();
                }
            }
        }
        return result.ToArray();
    }
}