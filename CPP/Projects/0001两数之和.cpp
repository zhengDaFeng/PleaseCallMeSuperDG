/************************************************
 * ����һ���������� nums ��һ��Ŀ��ֵ target�������ڸ��������ҳ���ΪĿ��ֵ���� ���� ���������������ǵ������±ꡣ
 * ����Լ���ÿ������ֻ���Ӧһ���𰸡����ǣ��㲻���ظ��������������ͬ����Ԫ�ء�
 * ʾ��:
 * ���� nums = [2, 7, 11, 15], target = 9
 * ��Ϊ nums[0] + nums[1] = 2 + 7 = 9
 * ���Է��� [0, 1]
 ************************************************/
#include <map>
#include <vector>

vector<int> function(vector<int> nums, int target) {
    map<int, int> m;
    map<int, int>::iterator iter;
    vector<int> res;
    int len = nums.size();
    for (int i = 0; i < len; i++) {
        int temp = target - nums[i]; // ��÷���Ҫ���ֵ
        if (m.find(temp) != m.end()) { // �� map ��Ѱ���Ƿ���ڸ�ֵ�������򷵻����±����飬�������򽫵�ǰ��ֵ���� map
            res.push_back(temp);
            res.push_back(nums[i]);
            break;
        }
        m.insert(pair<int, int>(nums[i], i));
    }
    return res;
}