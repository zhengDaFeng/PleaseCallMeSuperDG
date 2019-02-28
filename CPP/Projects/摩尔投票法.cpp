int majorityElement(vector<int>& nums) {
    int len = nums.size();
    int count = 0, temp = 0;
    
    for (int i = 0; i < len; i++) {
        if (count == 0) {
            temp = nums[i];
            count++;
        }
        else {
            temp == nums[i] ? count++ : count--;
        }
    }
    
    return temp;
}