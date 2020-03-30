using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityElement
{
    class Solution
    {
        public static int MajorityElement(int[] nums)
        {
            var itemDic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (itemDic.ContainsKey(item))
                {
                    var counter = 0;
                    if (itemDic.TryGetValue(item, out counter))
                    {
                        counter++;
                        itemDic.Remove(item);
                        itemDic.Add(item, counter);
                    }
                }
                else
                    itemDic.Add(item, 1);

            }

            var colVal = itemDic.Values;
            foreach (KeyValuePair<int, int> item in itemDic)
                if (item.Value > nums.Length / 2) return item.Key;

            return 0;
        }
    }
}
