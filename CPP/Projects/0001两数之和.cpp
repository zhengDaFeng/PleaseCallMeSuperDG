/************************************************
 * 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
 * 你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。
 * 示例:
 * 给定 nums = [2, 7, 11, 15], target = 9
 * 因为 nums[0] + nums[1] = 2 + 7 = 9
 * 所以返回 [0, 1]
 ************************************************/
#include <map>
#include <vector>

vector<int> function(vector<int> nums, int target) {
    map<int, int> m;
    map<int, int>::iterator iter;
    vector<int> res;
    int len = nums.size();
    for (int i = 0; i < len; i++) {
        int temp = target - nums[i]; // 求得符合要求的值
        if (m.find(temp) != m.end()) { // 在 map 中寻找是否存在该值。存在则返回其下标数组，不存在则将当前数值存入 map
            res.push_back(temp);
            res.push_back(nums[i]);
            break;
        }
        m.insert(pair<int, int>(nums[i], i));
    }
    return res;
}